I'm a big fan of KC Green's _This is Fine_ comic.
You should [check it out](http://gunshowcomic.com/648) if you're not familiar with it.
You should also go visit [KC's site](http://kcgreendotcom.com/index.html) and support him if you feel so inclined.

In my [last post](grumble-grumble) I wrote about a command line tool inspired by The Legend of Zelda.
I made another one, but this time inspired by the _This is Fine_ comic!

![This is Fine command line tool](/images/this-is-fine.gif)

Pretty much the same as the `grumble` command line tool, but this time with 100% more This is Fine.
I used [Spectre.Console](https://spectreconsole.net/) again, but this time I figured out a way to use the CanvasImage but still draw the image centered on the screen.
It was much quicker to just edit the image and then draw it instead of having to translate every pixel into code.
Maybe I'll go back and refactor `grumble` to do the same thing...

On some of the drawable items in Spectre.Console there is an extension method to easily center things.
Not so with CanvasImage (or at least not that I've found so far).
It may still be worth submitting a pull request for that.

This time in addition to providing just a Windows version, there are also MacOS and Linux versions.
I don't have a great way to test them, so there are probably issues.
But it's a start at least.
If you find any issues with them, [let me know](/contact).

[Download This is Fine command line tool v1.0](https://github.com/theparticleman/ThisIsFine/releases)

[Get the source code](https://github.com/theparticleman/ThisIsFine)