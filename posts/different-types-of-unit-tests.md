_This blog post was originally posted on the [Pluralsight Tech Blog](https://www.pluralsight.com/tech-blog/different-types-of-unit-tests/)_

There are lots of different types of tests. There are lots of different types of automated tests. In this post we’ll talk about unit tests, specifically a few different types of unit tests and when you might want to use each. We’ll be using examples in C# using Nunit.

### Example Code
We’ll use some example code for parts of the discussion in this post. This code takes a username and password and, assuming they match the stored username and password, will generate a signed JWT for the user and store it in a cookie.

    public class SignInCommand
    {
        //Constants and class variables removed for brevity.
    
        public SignInCommand(ICookieHelper cookieHelper, ITokenGenerator     tokenGenerator, IUserRepository userRepository, IPasswordHasher     passwordHasher)
        {
            this.cookieHelper = cookieHelper;
            this.tokenGenerator = tokenGenerator;
            this.userRepository = userRepository;
            this.passwordHasher = passwordHasher;
        }
    
        public async Task<bool> Execute(string username, string password)
        {
            var user = await userRepository.Load(username);
            if (user == null) return false;
            if (!passwordHasher.DoesPasswordMatch(user.Salt, user.Hash, password))     return false;
            var token = tokenGenerator.Encode(username, user.PlayerName);
            cookieHelper.SetCookie(CookieName, token);
            return true;
        }
    }

### Arrange-Act-Assert
The canonical unit test is one where you want to test a piece of code one single way and you want to verify that one effect of that code was correct. Depending on the complexity of the code, some setup might be necessary before the code under test can be executed. This pattern of setting up proper conditions for a test, running the code under test, and then verifying the result is often called the _arrange-act-assert_ pattern.

Using our example code above, here is an arrange-act-assert unit test for the case when the username is valid but an incorrect password is supplied.

    public class WhenExecutingSignInWithIncorrectPassword :     WithAnAutomocked<SignInCommand>
    {
        [Test]
        public void ItShouldFail()
        {
            GetMock<IUserRepository>().Setup(x => x.Load(IsAny<string>())).Returns    (Task.FromResult(new User()));
            GetMock<IPasswordHasher>().Setup(x => x.DoesPasswordMatch(IsAny<string>    (), IsAny<string>(), IsAny<string>())).Returns(false);
    
            var result = ClassUnderTest.Execute("username", "incorrect password").    Result;
    
            Assert.That(result, Is.False);
        }
    }

The `WithAnAutomocked<T>` base class is just a helper class that instantiates the class provided (the `SignInCommand` class in the code above) and injects all of the constructor dependencies for that class as Moq mocks. It uses [AutoMoq](https://github.com/darrencauthon/AutoMoq) to do this.

With this example test you can see a strong arrange-act-assert pattern. There is code to set up some behavior on some mocks that the code under test depends on (arrange). The code under test is then executed (act), and finally we check to make sure the code did what is was supposed to (assert).

This type of test is great when you want to test for a specific situation or a specific set of inputs. It is also great when you want to verify a single thing about the execution of your code.

### One Act, Many Assertions
Sometimes when testing a piece of code, we want to execute the code and then make assertions about multiple effects that code had. Again, we could create a standard arrange-act-assert style test to handle this case. We would just need to add multiple assertions to the end of our test. Some people are vehemently opposed to having multiple assertions in their tests. I’m not entirely opposed to it, but I do consider it a smell. One of the problems with multiple assertions is that when a test fails it can become difficult to determine what part of the code has actually failed. If the assertions are independent, but they all pass or fail together it can be necessary to resort to stack traces or error messages to determine what part of the code has actually failed. Also, in the case of Nunit at least, the failure of a single assertion in a test will cause the execution of the test to halt. So a failure early on in a test can mask additional failures later in the test.

Fortunately, there is a solution to this problem. The solution is to use a style sometimes referred to as behavior driven development (BDD) testing or _specification testing_.


    public class WhenExecutingValidSignIn : WithAnAutomocked<SignInCommand>
    {
        private bool result;
        private string tokenValue = "token value";
    
        [SetUp]
        public void SetUp()
        {
            var user = new User { Username = "username", PlayerName = "Player     Name" };
            GetMock<IUserRepository>().Setup(x => x.Load("username")).Returns(Task.    FromResult(user));
            GetMock<ITokenGenerator>().Setup(x => x.Encode("username", "Player     Name")).Returns(tokenValue);
            GetMock<IPasswordHasher>().Setup(x => x.DoesPasswordMatch(IsAny<string>    (), IsAny<string>(), IsAny<string>())).Returns(true);
            result = ClassUnderTest.Execute("username", "password").Result;
        }
    
        [Test]
        public void ShouldSucceed() => Assert.That(result, Is.True);
    
        [Test]
        public void ShouldSetCookie() => GetMock<ICookieHelper>().Verify(x => x.    SetCookie(SignInCommand.CookieName, tokenValue));
    }

In this example we go back to the `SignInCommand` example. But in this case we are testing the path where sign in was successful. With this particular code we want to make sure that the correct result is returned and that the cookie was set. These two results could easily succeed or fail independently from each other. So putting them as two assertions in the same test doesn’t make sense for the reasons mentioned above.

This type of test is great when there are multiple effects a piece of code can have that can all succeed or fail independently. In this particular example there are only two such assertions, but you can imagine more complex pieces of code could have many more. This particular example just uses Nunit to get this style of test, but there are also testing frameworks geared specifically for this type of test. Some examples in .NET include [Machine.Specifications](https://github.com/machine/machine.specifications) and [Nunit.Specifications](https://github.com/derekgreer/nunit.specifications).

### Test Cases
Sometimes we have code where we want to test a lot of different inputs matched with a lot of different outputs. Since our previous example code for the `SignInCommand` doesn’t lend itself terribly well to this type of test, let’s use a different example for this type of unit test. Imagine we wanted to test some code that takes an integer and returns that integer value converted to a [Roman numeral](https://github.com/theparticleman/RomanNumeralKataSolution). For this type of algorithmic code we’ll want to provide lots of different inputs to test all the different Roman numeral conversions and verify that we get the correct output back. We could write a new arrange-act-assert style test for each input and output set we want to test. But if we did that we’d end up with a lot of duplicate code. And you should make sure your test code is maintainable as possible, just like with your production code.

Fortunately, it’s possible to write unit tests for these types of scenarios as well. Nunit has a feature specifically for this type of test. If your unit testing library of choice doesn’t have such a feature you can always create some type of collection to store your input-output pairs and then iterate over that collection. It’s not quite as slick as when the capability is built in to your unit testing library, but it can still remove duplicate code and allow you to add new test cases quickly.

    public class RomanNumeralConversionTests
    {
        [TestCase(0, "")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(10, "X")]
        [TestCase(9, "IX")]
        [TestCase(40, "XL")]
        [TestCase(50, "L")]
        [TestCase(90, "XC")]
        [TestCase(100, "C")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        public void ConvertTests(int arabic, string roman)
        {
            Assert.That(ArabicToRoman.Convert(arabic), Is.EqualTo(roman));
        }
    }

In this example you can see that if we had different arrange-act-assert style tests for every input and output combination there would be a lot of duplicate code. And every time we wanted to add an additional test case, it would involve duplicating more code. Using the `TestCase` attribute from Nunit, we can remove a lot of duplication and make it easy to add test cases in the future. We also are able to more clearly indicate what it is we are trying to test. We’re not trying to test that `1` converts to `I` necessarily. We’re really trying to test that the entire conversion process works as expected. Putting all of our conversion related tests together using _test cases_ like this allows us to better show our intent.

### Which Type of Unit Test Should You Use?
The three types of unit tests described above are each great in their own context. If you’re testing code that has multiple effects that can succeed or fail independently, a _specification test_ might be a great option. If you’re testing code where you want to make sure that multiple sets of input and output are correct, a _test case_ style test might be a great option. And when in doubt, a standard _arrange-act-assert test_ is a great place to start.

Remember that test code is code too. It should be crafted with care, just like production code. It should have duplication removed, should be refactored to increase maintainability, and should evolve over time. Hopefully the examples given here will give you some ideas to help your test code be even better than it already is.