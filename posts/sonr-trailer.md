<div style="padding:75% 0 0 0;position:relative;"><iframe src="https://player.vimeo.com/video/13443384?badge=0&amp;autopause=0&amp;player_id=0&amp;app_id=58479&amp;h=b680ce21e1" frameborder="0" allow="autoplay; fullscreen; picture-in-picture" allowfullscreen style="position:absolute;top:0;left:0;width:100%;height:100%;" title="SONR Trailer"></iframe></div><script src="https://player.vimeo.com/api/player.js"></script>

SONR was originally started as an entry in the [TIGSource Assemblee competition](https://forums.tigsource.com/index.php?board=38.0).  Unfortunately, I didn’t really get far enough to submit anything for the competition, but I liked the game, so I’ve kept working on it. 

I decided a while ago I should make a trailer for SONR before actually finishing the game.  I’m not sure exactly why I decided that would be a good idea.  Maybe because I knew it would be a while before the whole game got done?  I’ve never made an actual trailer for a game before.  Gameplay videos yes, trailers no.  I’d appreciate any feedback on it that anyone has.  Cool?  Lame?  Confusing?  Waste of time?  I was hoping it would convey some of the emotions that I hope the final game will contain. 

Speaking of my hopes for the final game, I thought I’d make a list of my reasons for making/goals behind SONR.  Because, you know, the `<ul>` tag doesn’t get enough lovin’ in this world.

* I guess the first reason I should mention for making SONR is to participate in a TIGSource competition.  If you haven’t done it before and have any inclination to do so I would highly recommend it.  You don’t have to be a coder.  You can do art, music, level design or even just play testing.  People often team up to work on entries.

* One of the requirements for the competition was that you had to use assets provided in the first part of the competition and you couldn’t modify them outside of code.  I thought it sounded like fun to do all the graphics manipulations and enhancements in code.  And it kind of was.  One of my goals with SONR is to make it look cool.  And I think so far it’s turned out looking pretty good.  Not perfect, but pretty good.  But I think going forward I might relax some of the requirements from the competition.

* I feel like my games so far have lacked something.  Depth?  Emotion?  Something like that.  I want this one to have more emotion.  I decided to use something Edmund McMillen said about making [Aether](https://en.wikipedia.org/wiki/Aether_(video_game)) and use some experiences from my own life.  Or at least some emotions I’ve felt strongly at one point or another in my life.  We’ll see how that goes.

* As mentioned previously, Ninja Robot Winning Gameshow ended up being much harder than I meant it to be.  I wanted it to be more fun than hard.  With SONR I’m going to try again for more fun than hard.  I’m hoping the visuals + emotion + exploration + easier movement and good combat + reasonable AI + having buddies to help you out = fun gameplay.  And I’m going to let more people test it than I did with NRWG.

* And finally, I wanted some of the stuff that I built for SONR to translate over into framework items that I could use in other, future games.  I’m hoping after coding some more games I’ll have a pretty good idea of what things I’ll want to reuse and which things I don’t.

* I guess another way to sum most of that up is, I want SONR to have, as ⦁	Kurt puts it, “soul”.

So those are some of my goals.  After I actually get done I’ll plan to do a bit of a retrospective as I have for some other games and see how well I did.  In the meantime, there are a few things I’ve already learned and some changes I’m going to make going forward.

* Doing pixel-level collision detection really isn’t nearly as fun as it sounds, if you can imagine that!

* As mentioned above, doing all the effects and image manipulation in code is an interesting exercise, but in the end not terribly interesting.  I’d rather let someone who enjoys doing that write some tool for me (like the excellent [Paint.NET](https://www.getpaint.net/)) and just use that.  Much faster that way.

* Having a two year old son does terrible things to one’s supply of available game playing time, and even worse things to one’s supply of available game making time.  Though I was quite pleased that one of his new favorite videos to watch is actually this SONR trailer.  It gives me high hopes for his future video game playing and general geekiness levels.

* Sadly, after creating all the collision detection, image scaling and rotation and game loop code by hand, I think I’m going to basically scrap it all going forward and use a third party game framework.  At the moment I’m leaning towards [Flat Red Ball](https://flatredball.com/).  It’s kind of a hard decision for me to make.  No one likes to throw away perfectly good code.  And while my code does work, it has some limitations that I’m not terribly interested in building solutions to.  I’ve decided I would like hardware acceleration, better camera support, better image rotation and collision detection, better framerate control among other things.  A lot of that comes for free with a game framework and doesn’t come for free if I have to code it.  I’d rather spend time making my game than writing multi-threaded frame rendering code.  Plus I think a good amount of my code will be reusable.  Most of the game logic and characters and stuff should be able to translate over fairly well I think.  So I’m going to try it and see what happens.  If I crash and burn terribly, I’ll be sure to let you know.

* My combat system still sucks.  It’s better than it was originally, but still needs some work.  Having buddies follow you around and help you makes it funner, but it’s still not where I want it to be.  Once I transition to a new framework, combat is going to be my biggest area of focus.

* So far I’ve only implemented keyboard support.  I think using a gamepad will probably make the game funner.  I want to avoid requiring a gamepad though, since I know not everyone has one.

Well, that’s probably enough talking (or rather writing) for now.  SONR still needs lots of code and it’s not going to write itself.  So let me know what you think of the trailer and the current look of SONR, and I’ll go write some awesome code. 

P.S. All the footage in the video is current in-game video.  The video looks okay, but the actual game looks way better.  The video has a bunch of compression artifacts which the actual game does not (especially noticeable at larger sizes).  I need to get some better video editting tools than what I currently have.
