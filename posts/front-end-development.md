A friend of mine sent me a link to [this]() article a while back and asked my thoughts. It's taken me entirely too long to respond, but here are my thoughts.

The article's overall tone is more negative than how I feel. But I think the author is more heavily involved in the front-end community than I am. Perhaps the greater negativity is warranted. I don't know. I like the old adage, "Don't attribute to malice that which can be attributed to incompetence."

But the underlying premise of the article, that "modern" front-end development is overly complex, I completely agree with.

In thinking about complexity, a few quotes come to mind.

First, [this gem]() from Brian Kerningham:

> Controlling complexity is the essence of computer programming.

Not algorithms, not tools, not syntax, but controlling complexity is the essense of computer programming. But why is this? Why is complexity so important to software development? [Another quote]() from Mary and Tom Poppendieck:

> The cost of complexity is not linear, it is exponential, and the cost of complexity eventually comes to dominate all other costs in most software systems. Complex code is brittle and breaks easily, making it almost impossible to change safely. Wise software development organizations place top priority on keeping the code base simple, clean, and small.

The term "exponential cost" should terrify anyone running a business or hoping to maintain something over time.

But is front-end development really _that_ complex? Let's take a look at a contrived but hopefully not completely unrealistic example.

Let's say I want a static web page. I could create a new Angular or React application. That would require installing Node and my package manager of choice (if I choose not to use NPM or if it does not come with my Node installation). I'll need to make sure whatever version of Node I install is compatible with the version of the front-end library I choose. I might as well go ahead and install NVM because I'll probably want to work on other projects as well and that will likely need a different version of Node. 

I'll probably want the CLI tool for either Angular or React so I can create a new project and interact with it. Let's install that.

I'll want some type of CSS library. Bootstrap or Tailwind or something. Let's install that as well. Hopefully the version of that is compatible with the version of my front-end framework I chose.

I can now start creating my static web page. This is before I add any actual functionality to my page. That might require installing additional dependencies. But we'll keep it simple for now.

All of that isn't _so_ complex, is it? One could definitely make the argument that the above example is significantly less complex than other examples. I'll give you that.

But do you know what's _less_ complex than the above example? An HTML file with a `<style>` tag in the `<head>`. No frameworks, no installs, no dependencies. Just a text editor a file.

Now, I hear you saying, "But that HTML won't scale!" It depends on what you mean by "scale". If you mean from a performance standpoint, they most definitely _will_ scale. Web servers are very good at serving static content. If you mean from a maintainability perspective, you might be right. If that single HTML file turns in to multiple pages and significant CSS rules, won't that eventually become challenging or difficult to maintain?

Yes, it will. But don't do that.

If you need the additional complexity of having multiple web pages