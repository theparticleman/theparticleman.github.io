A friend of mine asked me the other day about learning resources for some junior developers he knows. I sent him a list of a few resources off the top of my head. But my brain kept thinking of others to suggest. So I figured I'd write down a list with a bit more thought put in to it.

# Disclaimer

By putting together this list, I'm not implying that every junior developer should immediately use every single one of these resources. Even after 20 years of professional software development there are still books that I should have read but haven't, or coding problems I should have implemented but haven't. Please don't look at this list as a wall of "look at all the things I haven't done" shame. I hope people will look at it more as a list of things they could learn more about.

And hopefully it's obvious, but this is by no means a complete list. I'm sure there will be resources that I would have put on here given only a little more thought on my part, not to mention all the resources from other peoples' experiences and opinions. But this is my list, so I'm not going to worry about every else's lists right now.

# Books

There are a lot of good books related to software development these days. One could argue that there are too many good books and no one has time to read them all. That's probably true. But here are a few that I often recommend to people:

* For some basic, all around good software development advice, `The Pragmatic Programmer` by Dave Thomas and Andy Hunt is a great read for any software developer.

* I'm a big fan of the ideas from the software craftsmanship movement. Some books that I think have a lot of valuable material on the topic include `The Software Craftsman` by Sandro Mancuso and `The Clean Coder` and `Clean Craftsmanship` by Robert Martin.

* `Test Driven Development By Example` by Kent Beck is kind of like sitting next to Kent Beck as he writes code using TDD, just in book format. It's great to be able to learn directly from one of the masters of TDD. If you're just looking to learn more about unit testing in general, this book might be a bit more than you want.

* I wish I'd had the book `Apprenticeship Patterns` by Dave Hoover and Adewale Oshineye when I was starting out my career. It has a bunch of patterns (surprising given the name, I know) about how to learn and grow in your career as a software developer.

* Ron Jeffries' `The Nature of Software Development` is a good discussion of the principles of agile software development, without all the baggage that Scrum and its following bring. I think he intended it more for engineering managers, but I think it's approachable enough that pretty much any software developer could benefit from it.

* In addition to agile software development, I think knowing about lean software development would benefit most software developers. `This is Lean` by Niklas Modig and Par Ahlstrom is a great intro to lean principles in general. If you want to go super in-depth, `Principles of Product Development Flow` by Don Reinertsen is great. But beware! It is pretty deep. If you want something more specific to software development, `Implementing Lean Software Development` by Mary and Tom Poppendieck is pretty awesome.

* If you have code that doesn't have tests and you want to learn how to get it under test, `Working Effectively With Legacy` by Michael Feathers is _the_ book on the topic.

Like I said, it could be argued that there are too many good books on software development. And I could certainly add many more books to the "good" list. But I think this is a good list of topics that junior devs might otherwise not get exposed to.

# Katas

There are some ideas and concepts that can be communicated well in books. But there are other ideas that translate better when learned through actually coding. 

The idea of a kata comes from martial arts, where the same forms are practiced repeatedly. Code katas are slightly different, but with a similar intent. They are specific problems that can be repeated to practice various software development skills such as refactoring, test driven development, pair programming, etc.

Some of these code katas are fairly simple, self-contained problems. Some examples include

* The [Roman Numeral Kata](https://github.com/UtahSC/roman-numeral-kata) is one of my favorites for practicing test driven development.
* [Flexbox Froggy](https://flexboxfroggy.com/) is a great way to practice using flexbox in CSS.
* The [Gilded Rose Kata](https://github.com/emilybache/GildedRose-Refactoring-Kata) is a great kata that focuses on refactoring and getting mostly untested code under test.
* There are lots of other lists of general code katas. The [Utah Software Craftsmanship](http://utahsc.org) group has a [list of common code katas](https://github.com/UtahSC/coding-exercises?tab=readme-ov-file#examples-exercises) (which includes the Roman Numeral Kata). There is also [this list](https://github.com/gamontal/awesome-katas) as well as many others.
* Emily Bache (the author of the Guilded Rose Kata mentioned above) has a [large list of katas](https://github.com/emilybache?tab=repositories) she has created, many of which are focused on refactoring.

Small, self-contained problems are great for some types of practice. But sometimes it's helpful to have a real world (or at least closer to real world) problem to practice with and learn from. Personal side projects can be a great way to do this. But sometimes it's hard to come up with good inspiration for a side project you're passionate about. In that case, a closer-to-real-world code kata might help. Here are a few examples:

* [XorTag](https://xortag.azurewebsites.net/) - Write code to play tag with other players in real time over HTTP. This kata involves making HTTP calls and sending and parsing JSON. It's best done with a group, but can be done solo as well.
* [Distributed Calculator](https://github.com/davidadsit/distributed-calculator) - Another kata that uses interactions over HTTP. But this one has you creating your own web server that interacts with another web application.
* [Vanilla Web](https://github.com/theparticleman/VanillaWebKata) - With web applications it can be easy to get caught up in all the latest front-end frameworks. Sometimes it's nice to remember that all you really need to create a website is some HTML, CSS, and Javascript text files created using a simple text editor. This kata is about practicing those skills.

A few more honorable mentions:

* [Advent of Code](https://adventofcode.com/) - Advent of Code is a coding-based advent calendar that gets updated every December. The problems are usually fairly algorithm focused, but they can be great if that's the type of thing you're practicing. You can always go back and solve the problems from previous years too.
* [Exercism](https://exercism.org/) - Exercism used to be all about solving toy problems and getting feedback from others on your solution. But now it has all kinds of learning paths and other things as well. Check it out and see if it would help meet some of your learning needs.

# Other Stuff

Sometimes reading a book is the right way to learn. Other times writing some code is the right way to learn. And still other times something completely different is in order. Here are a few resources in the "completely different" category:

* [Code Retreat](https://www.coderetreat.org/) - The idea of a code retreat is all around practice and does typically involve coding. But it's more about challenging your preconceptions about how code can and should be written than it is about the specific code you write. Rather than explain all the details about how a code retreat works, I'll just let you read on the website. But if you get the chance to participate in a code retreat, I would highly recommend it. There is a Global Day of Code Retreat event every year, usually in November.
* [Coding with Jon and Mike](https://www.youtube.com/@codingwithjonandmike3931) - When learning some types of skills, it can be helpful to see someone else actually using those skills. My friend Mike and I have put together some YouTube videos to show people actually practices skills like pair programming, test driven development, and refactoring.
* [Emily Bache videos](https://www.youtube.com/@EmilyBache-tech-coach) - Emily Bache (already mentioned above) has recently started her own YouTube channel with videos on topics like refactoring and test driven development. I've only watched a few of her videos so far, but look forward to getting to help people practice using them more in the future.

# Conclusion
Again, this is by no means an exhaustive list. If you have other must-have learning resources that you think should be on this list, [let me know](/contact). And if you haven't (or don't ever) get to everything on this list, don't feel bad! But if you're looking for ways to practice and learn new skills so you can level up from a junior developer and progress in your career, hopefully some of the things in this list help!
