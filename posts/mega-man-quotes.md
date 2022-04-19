At various times in the past I've used quotes from industry experts to teach and inspire others, as well as spark discussions with my co-workers.
The last few years my sharing has taken the form of Slack bots, primarily one named Mega Man.
I've used Mega Man to share a variety of software development and software craftsmanship-related quotes.

Some people have been ambivalent about Mega Man and the quotes he's shared.
One or two people have been negative about it.
(Remind me to tell you the story sometime about the time someone called me, the guy with two black kids, a racist because of one of the quotes Mega Man shared. Good times.)
But overall the responses to Mega Man and the quotes he's shared have been pretty postive.

While I've found my Mega Man Slack bot to be an effective tool for sharing knowledge, I've occasionally run into some technical challenges.
For example, over the years I've stored the quotes Mega Man shares in a couple of different formats.
Mostly I've done whatever was expedient to the code I was writing at the time.
But I've ended up with several different copies and several different versions of the quotes.
Having multiple copies in multiple formats has certainly made it much more difficult to update my list of quotes effectively.

And what kind of software developer would I be if I didn't try solving all my problems by writing code?

Introducing [Mega Man Quotes as a Service](https://megamanquotes.com) (MMQaaS)!

![Mega Man Quotes website](/images/mega-man-quotes-web.png)

I now have a central place to put all my quotes.
It's exposed via an HTTP+JSON API so I can access the same list of quotes from different apps that I write.
So far [megamanquotes.com](https://megamanquotes.com) (which is obviously a web app) uses the API, as does the command line tool I wrote.

![Mega Man Quotes cli](/images/mega-man-quotes.gif)

Now I just need to go update my existing Slack bots to use this new API so that I can reap all the benefits I just professed to get from this new code.

[Visit megamanquotes.com](https://megamanquotes.com)

[Read the documentation for the API](https://megamanquotes.com/api)

[Download the Mega Man Quotes CLI](https://github.com/theparticleman/MegaManQuotesCli/releases/tag/v1.0)

[Get the source code for the Mega Man Quotes CLI](https://github.com/theparticleman/MegaManQuotesCli)