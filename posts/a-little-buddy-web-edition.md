Several years ago, I made a little desktop companion app based on [Mega Man](a-little-buddy). It's fun to run sometimes and have Mega Man run around my desktop, especially if I'm sharing my screen on Zoom or the like during these pandemic times.

Unfortunately, it's a little hard for other people to enjoy Mega Man. I wrote it in 2008 using .NET Framework, so it's not cross platform at all. It does run on Windows 11, but you have to download the correct version of the .NET Framework (which happens automatically when you try to run the executable, but it's not a great user experience).

Fortunately, we do live in an age when making things in a browser sucks a lot less than it used to. And I am on something of a [web kick](https://www.fableofgriselda.com) lately. So I remade my little Mega Man desktop buddy to run in a browser!

You can check him out on the [home page](/) for this site. I also put him on the [main blog page](/blog). I thought it might be nice for people scrolling through my list of blog posts to have a companion while they do so. I might put him on other pages too. We'll see.

Oh, yeah! He's also on the page for [this blog post](a-little-buddy-web-edition). That seemed appropriate. If you want to give him a break for a bit you can click the button in the upper right corner with his face on it.

<a href="/"><img src="/images/a-little-buddy-web-edition-1.png" alt="Mega Man buddy screenshot"></a>

Some things I learned (or maybe remembered) while making this:
* I wanted all the code for this to be in a single `.js` file. I wanted to just be able to include it on a page and the script would do everything it needed, including having all the images. Embedding base64 encoded images in a Javascript file is pretty easy. I wouldn't recommend always using that method for images, but in this case it worked well.

* `position: fixed` is your friend for this kind of stuff.
* Creating HTML elements and adding them to the DOM programmatically isn't my favorite thing, but really isn't that bad in modern vanilla JS.
* Using local storage in vanilla JS is pretty easy too.
* The responsive/mobile dev tools in Chromium can get in to a weird state where they just don't work right. They report viewport sizes incorrectly and all kinds of stuff that wreaks havoc when trying to get something like this working properly.
* `imageRendering: pixelated` is my new favorite CSS property.

<script async src='/megaman.js'></script>