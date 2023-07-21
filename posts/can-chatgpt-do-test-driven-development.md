A friend of mine recently pinged me on LinkedIn to have a discussion about AI as it relates to [agile software development](https://agilemanifesto.org/). He referenced a presentation I did that he attended where I demonstrated the steps of test-driven development (TDD) using the Roman numeral kata. (You can see a video of that presentation [here](/blog/presentation-videos) or a description of the kata [here](https://github.com/UtahSC/roman-numeral-kata).) To be able to better respond to my friend, I decided to go play with ChatGPT and see how well it would do at TDD.

I consider myself somewhat of an AI skeptic. Well, maybe "AI pragmatist" would be a better term. I know that AI (and more specifically machine learning, which is what most people mean when they say "AI" these days) can do lots of cool things, but that it also is _very_ far from the [artificial general intelligence](https://en.wikipedia.org/wiki/Artificial_general_intelligence) that people hope and sometimes think that it is. I went in to this experiment expecting ChatGPT to fail at doing TDD. And it mostly did. But it did surprise me a few times.

What follows is a summary of my interaction with ChatGPT, trying to get it to do test-driven development. You can see the entire exchange [here](https://chat.openai.com/share/0e958f7b-9efe-49f6-95bd-10313d5beb2f).

### Starting Off

I started off with the simple prompt `write code that converts arabic numbers to roman numerals`. I didn't start off with great grammar because I wasn't sure how long the conversation would go.

ChatGPT gave me back a reasonable implementation in Python. It even used tuples to store the mapping between Arabic numbers and Roman numerals. Bonus points for knowing the Roman numerals are undefined below 1 and above 3999!

<details>
<summary>Initial implementation in Python</summary>

    def arabic_to_roman(number):
        if not isinstance(number, int) or number <= 0 or number >= 4000:
            raise ValueError("Invalid input: Only positive integers between 1 and 3999 are supported.")

        roman_numerals = [
            ("M", 1000),
            ("CM", 900),
            ("D", 500),
            ("CD", 400),
            ("C", 100),
            ("XC", 90),
            ("L", 50),
            ("XL", 40),
            ("X", 10),
            ("IX", 9),
            ("V", 5),
            ("IV", 4),
            ("I", 1)
        ]

        roman_numeral = ""
        for numeral, value in roman_numerals:
            while number >= value:
                roman_numeral += numeral
                number -= value

        return roman_numeral

    # Test the function
    try:
        number = int(input("Enter an Arabic number (1 to 3999): "))
        roman_numeral = arabic_to_roman(number)
        print(f"{number} in Roman numerals is: {roman_numeral}")
    except ValueError as e:
        print(e)

</details>

I then asked it to do it in C#. Not because I have anything against Python, but because when I do the presentation, I usually do it in C#. So this seemed like a more apples to apples comparison.

ChatGPT happily gave me some C# code. Unfortunately, it lost the tuple data structure that I liked. So I asked it to put that back. I assumed it would fail, but it did a great job! And it didn't get confused when I accidentally typed `in[]` instead of `int[]`. Good job ChatGPT!

When I do the presentation, I usually go towards a recursive solution, just because the TDD kind of lends itself to that. So I asked ChatGPT to change it's solution to a recursive implementation. No problem. It even added a disclaimer about how a recursive solution "is a neat approach, [but] it might not be the most efficient way to perform this conversion for very large numbers due to the stack space consumed by the recursive calls."

### Getting Serious

Alright. The easy stuff was over. Now on to the actual test. Did ChatGPT have any idea what test-driven development was? We already had a solution without any tests, which is already not test-driven at all. But even if you don't test drive a solution, if you are sufficiently familiar with a problem you could add tests after the fact that make it _look_ like you test drove the solution. So I went with the prompt `now add tests as though the solution were test driven`.

Here's what ChatGPT gave me back.

<details>
<summary>The response to my initial request for test-driven code</summary>

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RomanConverterTests
    {
        [TestMethod]
        public void TestArabicToRoman_LowerBound()
        {
            int number = 1;
            string expected = "I";
            string actual = RomanConverter.ArabicToRoman(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArabicToRoman_UpperBound()
        {
            int number = 3999;
            string expected = "MMMCMXCIX";
            string actual = RomanConverter.ArabicToRoman(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArabicToRoman_RandomNumbers()
        {
            var testCases = new (int Number, string ExpectedRoman)[]
            {
                (5, "V"),
                (9, "IX"),
                (42, "XLII"),
                (99, "XCIX"),
                (1984, "MCMLXXXIV"),
                (2023, "MMXXIII"),
                (1000, "M"),
                (1990, "MCMXC"),
                (2000, "MM"),
                (2008, "MMVIII"),
                (3462, "MMMCDLXII")
            };

            foreach (var testCase in testCases)
            {
                string actual = RomanConverter.ArabicToRoman(testCase.Number);
                Assert.AreEqual(testCase.ExpectedRoman, actual);
            }
        }

        [TestMethod]
        public void TestArabicToRoman_InvalidInput()
        {
            int invalidNumber = -1;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => RomanConverter.ArabicToRoman(invalidNumber));
        }
    }
</details>

Okay. Some boundary conditions. That's nice. An assortment of random other cases (which it even named `TestArabicToRoman_RandomNumbers`). It's a reasonable selection of test cases. If it had chosen to use NUnit instead of MSTest it could have used `TestCase` attributes instead of creating a collection of test cases and iterating through it. But still, not bad.

But not test-driven at all. I told ChatGPT as much.

`that doesn't look test driven at all`.

ChatGPT politely apologized, said this time it would "rewrite the tests following a test-driven development approach", and then proceeded to give me the exact same code it just gave me.

🤨

I told ChatGPT that it just gave me the exact same code twice in a row. I also pointed out that it said it was going to do test-driven development, explained to me that test-driven development requires writing tests before implementation code, and then explained why it was okay that it didn't write the tests before the implementation code.

ChatGPT politely apologized again. And gave me almost the same code again. It did add a `0` case and a `4000` case. That was kind of nice, I guess. But still not test-driven at all. I was starting to lose hope.

### Is There Any Hope?

When AI solutions start failing me, I like to point out to them that they are failing me. I'm not sure why I do this. Maybe it helps me remember I'm talking to a computer that has no idea what it's doing? Maybe I secretly hope that's what will finally shock the AI in to self awareness? I'm not sure.

But in this case I chose to call out ChatGPT on its failures. When I did, it wrote all the tests, then the complete implementation. The code was almost exactly as it was previously, but it arranged it differently. Sigh.

I called ChatGPT out again. It politely apologized and tried yet again.

But surprisingly, this time it did something different! It actually started with a single test! I started to get excited. Unfortunately, it went down hill quickly after that. After the single test it then gave me a complete implementation, followed by the same basic complete set of test cases.

I responded, `You started off writing a single test. I was so hopeful. But then you just implemented the whole thing and then all the tests. I don't think you're well equipped to show an iterative development process.`

I think mentioning "iterative development" sparked something. The next response _actually_ started out test-driven! I was amazed!

<details>
<summary>A single test, followed by an implementation that makes that test pass</summary>

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RomanConverterTests
    {
        [TestMethod]
        public void TestArabicToRoman_LowerBound()
        {
            int number = 1;
            string expected = "I";
            string actual = RomanConverter.ArabicToRoman(number);
            Assert.AreEqual(expected, actual);
        }
    }

    public class RomanConverter
    {
        public static string ArabicToRoman(int number)
        {
            return "I"; // This is the minimum code to make the first test pass
        }
    }

</details>

<details>
<summary>A second test and improve the implementation</summary>
    
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RomanConverterTests
    {
        [TestMethod]
        public void TestArabicToRoman_LowerBound()
        {
            int number = 1;
            string expected = "I";
            string actual = RomanConverter.ArabicToRoman(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArabicToRoman_Two()
        {
            int number = 2;
            string expected = "II";
            string actual = RomanConverter.ArabicToRoman(number);
            Assert.AreEqual(expected, actual);
        }
    }


    public class RomanConverter
    {
        public static string ArabicToRoman(int number)
        {
            if (number <= 0)
                throw new ArgumentException("Invalid input: Only positive integers are supported.");

            string romanNumeral = "";

            while (number >= 1)
            {
                romanNumeral += "I";
                number -= 1;
            }

            return romanNumeral;
        }
    }

</details>

This was a larger step after the second test than I personally would have done, but at this point I wasn't complaining! This was by far the best example of test-driven development that I'd gotten out of it.

I asked ChatGPT to continue, hoping it was finally on the right track.

### So Close, Yet So Far Away

Alas, my hopes were quickly dashed again. Upon responding to ChatGPT with the prompt `I stand corrected. That was a great start. Now please finish the rest of the tests and implementation.`, it quickly went back to it's old ways of implementing everything in a single pass. 

Instead of adding a third test case and improving the implementation slightly as I had hoped, it added test cases for 3 through 5 and provided a complete implementation again. I called it out again.

`No! You were doing so well. Then you failed.`

It then gave me test cases for 1 through 10 and a complete implementation. Yet again, I pointed out that was not test-driven development. Yet again, ChatGPT apologized and gave me another response.

This time ChatGPT started off well again. A single test for the 1 case. An implementation that made that test pass. Then it added a second test case, this time for 4. Not a great choice, but if it had actually followed through I would have been okay with it.

Unfortunately, instead of improving the implementation to make the 1 and 4 cases pass, ChatGPT went off the deep end, providing an implementation that handled the `I` (1) case, the `M` (1000) case, and the `CM` (900) case. Where did _that_ come from?

<details>
<summary>Where did that come from?</summary>

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RomanConverterTests
    {
        [TestMethod]
        public void TestArabicToRoman_LowerBound()
        {
            int number = 1;
            string expected = "I";
            string actual = RomanConverter.ArabicToRoman(number);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArabicToRoman_Four()
        {
            int number = 4;
            string expected = "IV";
            string actual = RomanConverter.ArabicToRoman(number);
            Assert.AreEqual(expected, actual);
        }
    }


    public class RomanConverter
    {
        public static string ArabicToRoman(int number)
        {
            if (number <= 0)
                throw new ArgumentException("Invalid input: Only positive integers are supported.");

            string romanNumeral = "";

            while (number >= 1000)
            {
                romanNumeral += "M";
                number -= 1000;
            }

            if (number >= 900)
            {
                romanNumeral += "CM";
                number -= 900;
            }

            // Continue with other Roman numerals...

            while (number >= 1)
            {
                romanNumeral += "I";
                number -= 1;
            }

            return romanNumeral;
        }
    }

</details>

The best part of this response was that the implementation doesn't even pass the tests! There's a test for the `IV` (4) case, but the implemenation doesn't address that case at all. Oh, ChatGPT! What were you thinking?

### Finishing Up

And, of course, the answer was that it wasn't thinking. Because ChatGPT is a large language model, which is a variation of an artificial neural network. It doesn't think. It's an algorithm, a function. It took my input prompts and spit out some output with no understanding. It is a [Chinese Room](https://en.wikipedia.org/wiki/Chinese_room), doing clever things that can appear intelligent, but with no understanding of what it's doing.

After supplying ChatGPT another prompt or two and getting the same, very non-test-driven code, I decided I'd tried enough. It was clear that ChatGPT wasn't really going to generate a test-driven code example because it doesn't really know what test-driven development is.

### Take Aways

So what can we learn from this? I thought of a few things.

ChatGPT and other AI/machine learning solutions like it can do some really impressive things. It was able to take my prompts and generate a lot of convincing output. Unfortunately, all that output was generated without any understanding.

Which brings me to my next point. The output was often wrong. And wrong in a way that someone new to the subject might not understand. I fear that people wanting to learn something will ask ChatGPT questions and just assume that its answers are correct because they sound convincing.

One of the problems ChatGPT had was that it already "knew" the answer. It knew how to implement an Arabic number to Roman numeral converter. Test-driven development is a design process, not a testing process. If you already have a design then there is little point in using a test-driven approach, other than to add test coverage. ChatGPT demonstrated this marvelously.

I was impressed a couple of times at how ChatGPT was able to refactor some code. I think there may be something valuable there in more powerful automated refactorings than what most of our development tools can do now. Though currently, I wouldn't automatically trust a refactoring that ChatGPT did like I do with most refactoring tools built in to IDEs. I would want to verify any refactorings it did with tests that I had written myself.

And finally, while there may be some types of jobs that could be at risk due to tools like ChatGPT, the job of writing high quality, clean, maintainable, understandable code is not one of them.

Not yet at least.