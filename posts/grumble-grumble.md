In the original Legend of Zelda game on NES (you may have noticed I have somewhat of an [interest in the game](/fable-of-griselda)), the seventh dungeon in the game was a little different than all the others.
At a certain point in the dungeon, rather than a normal room with enemies and puzzles, there is a room with a single character who just says, "Grumble, grumble...".
He can't directly be interacted with, and there are no other clues about how to get past this character.
But in order to complete the dungeon and the game you have to get past this character.
What to do?

![Hungry Goriya](/images/grumble-grumble-1.png)
(Screenshot from [zeldadungeon.net](https://www.zeldadungeon.net/the-legend-of-zelda-walkthrough/level-7-the-demon/))

It turns out the secret is to give the character (known in Legend of Zelda guides and walkthroughs as the [Hungry Goriya](https://zelda-archive.fandom.com/wiki/Hungry_Goriya)) some food.
I assume the way you're supposed to know this is to interpret "Grumble, grumble..." as the character's stomach rumbling because he's hungry?
I think it was one of the more unclear puzzles in the game, but the memory of the experience has stuck with me.

Yesterday at work, my team and I were updating some Javascript dependencies in our code.
Updating Javascript dependencies is one of those things in software development that's totally fine and doable, but seems way more complicated and difficult than it needs to be.
It isn't my favorite thing to do, but it's what we needed to do.
Doing it put me in a mood where I wanted to subtly complain about the task in order to make getting through it less obnoxious. I wanted to grumble about it.

I thought back to the Hungry Goriya.
His grumbling was apparently due to hunger.
But was he perhaps subtly complaining about his situation as well in order to help him get through his current challenge?

I commented to my team that I needed a command line tool for when I'm in that kind of grumbly mood.
I want to be able to type `grumble` in my terminal window and the tool would print out the Hungry Goriya to help me commiserate with my challenges.

So last night I made that command line tool.

![Grumble command line tool](/images/grumble.gif)

Being able to run the tool in my terminal window whenever I need it makes me happy, as did the process of creating it.
It's written in C# and uses the ability that more recent versions of .NET have to publish to a single, self-contained executable.
Even with compression and dependency tree shaking it's still around 12MB, which is kind of ridiculous for what it is.
But it also only took an hour or something to put together.
And I got to write it in C# instead of some other language I'm less familiar with.
To me that's worth a few extra megabytes in executable size.

I used [Spectre.Console](https://spectreconsole.net/) to easily print out the [Figlet](http://www.figlet.org/) text.
Spectre.Console also has the ability to read an image and print it to the console.
I was going to use that, but I wasn't able to center the image horizontally.
Maybe I'll have to open an issue or PR on their Github page or something.
But Spectre.Console does have an image canvas feature that makes drawing ASCII-based images like this easier.
I ended up using that, and it worked pretty well.
I'm just glad the sprites for Legend of Zelda aren't any bigger than they are.

So what's the take-away from this experience?
Well, for me I think the take-away is that a little grumbling from time to time can be healthy.
Acknowledging that we're going through a challenge can help make that challenge easier to get through.
It's obviously easy to go too far and let grumbling turn into pure negativity.
But as far as I'm concerned, a little grumbling now and then can be both healthy and helpful.

[Download Grumble command line tool v1.1](https://github.com/theparticleman/Grumble/releases/tag/v1.1)

[Download Grumble command line tool v1.0](https://github.com/theparticleman/Grumble/releases/tag/v1.0)

[Get the source code](https://github.com/theparticleman/Grumble)