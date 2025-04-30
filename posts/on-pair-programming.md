In an online community I'm a part of, recently someone was asking some questions about pair programming. Specifically they were asking about how to get started with pair programming, how to influence their team/org to adopt it, as well as generally why they might want to do pair programming. I thought I'd take a crack at answering those questions and share my thoughts on the topic.

As a little context, I've done primarily pair or mob programming for the last 12-ish years of my software development career. For the 10-ish years before that, I was working primarily solo coding, with some occasional collaborative work, but nothing I would consider dedicated pair programming.

### Getting Started

I want to start with the question "How Do I Get Started with Pair Programming?" 

* Ideally, find someone else who is also interested in pair programming. If you're trying to learn how to pair program _and_ trying to convince someone to pair program at the same time, your job will be harder.
* Start small. If pairing on actual code is too much, try pairing on a [code kata](http://codekata.com/).
* Start short. Pair programming is a skill you need to develop over time. Going from zero pairing to pairing for eight hours straight will be a big jump. It's okay if you only pair for 30 or 60 minutes before you and your pair are ready for a break. If you both are up for more, great, but don't push so hard that you get burned out.
* Make sure you can both contribute. If your first pairing session is one person typing and one person watching, that may not be a great experience. Both members of the pair should be able to see all the code and contribute to that (whether in person or remote).
* Don't worry about doing it "the wrong way." There are lots of different ways to do pair programming. Find what works for you. [This article](https://martinfowler.com/articles/on-pair-programming.html) on Martin Fowler's site has a lot of ideas. If you're not sure, I'd suggest you start with Ping Pong pairing and [Strong-style pairing](http://llewellynfalco.blogspot.com/2014/06/llewellyns-strong-style-pairing.html) and iterate from there.

### How Do I Influence My Team/Org?

This one can be hard. Influencing people (even ourselves) to change their behavior is hard even at the best of times. For general guidance on influencing change, I'd highly recommend the books [Fearless Change and More Fearless Change](https://fearlesschangepatterns.com/). Both are excellent.

A lot of the items from the Getting Started section above are your best bet. Achieving small successes and progressing from there is almost always more likely to succeed than any kind of big bang approach.

It may be worth doing some initial investigation to see if there are areas of the management hierarchy that are vehemently opposed to pair programming. Supportive leadership can be a great asset in adopting pair programming, but leadership that is against it can kill it just as quickly.

### Why Would I Want To Pair Program?

And finally, why would you want to pair program at all? Isn't it a waste of time? Couldn't two people working separately work twice as fast as two working together? Isn't it uncomfortable always having someone looking over your shoulder?

There definitely can be some downsides to pair programming, especially when implemented poorly or when working with an incompatible partner. But for me, I've found the pros to outweigh the cons. Here are some of those pros as I see them:

* You're always getting the best out of two ideas, rather than just the best you can come up with at the time. Is it possible for two people working together to come up with two ideas that both suck? Sure, but it's a lot less likely than with just one person.
* Real time code reviews. Rather than waiting for asynchronous code reviews (like in a traditional PR model) you get a code review the instant you need it. You also get it _before_ you write a bunch of code that relies on incorrect assumptions. In other words, you get feedback faster.
* It helps me stay focused better. It's easy for me to get caught up in making relatively minor decisions that don't matter than much. It's often easier for the other person and me to come to a decision much more quickly than when I'm working by myself.
* The learning can be amazing. The other person you're working with is presumably an expert on one or more things you're not. That might be the programming language you're using, the tools you're working with, or the problem domain. If they are, you can soak up tons of their knowledge in a relatively short period of time. And if they aren't an expert, that means _you_ are (even if only when compared to them) and they can suck up your knowledge.
* It's easier to have a sense of shared code ownership. I'm of the opinion that for virtually all production code, it's superior to have that code owned by a group of people rather than a single individual. When you work on code with another person it's a lot easier to think of the code as "our code" than it is when you write it in isolation.

### Conclusion

Pair programming can be hard, especially if you're just starting out with it. It can be uncomfortable. At least one other person will see the messy, sometimes wandering way you get the results that you do. You'll probably have to say, "I don't know" more than you do when you code on your own. And you'll be amazed and embarrassed at how you lose all ability to type when another person is watching.

But for me at least, working through that discomfort has made me a better developer. That's not just because of the benefits I've experienced with pair programming. But also because going through that discomfort makes me humbler and more empathetic as a human being.
