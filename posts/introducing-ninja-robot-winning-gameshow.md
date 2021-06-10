Can anyone else say, “About time!”?  I’ve had this almost ready to release for quite some time.  But I wanted to add some finishing touches to it.  There are more finishing touches that I’d like to add, but at least now it’s to a point where I feel like I can let other people download it, play it, and rag on it.

Before I give my blurb about the game, here’s a gameplay video.  If you’re a super anti-spoiler type person, it does show how to get past the first few levels.  They’re not that great of levels though.

[Ninja Robot Winning Gameshow Gameplay](https://mythicantdownloads.blob.core.windows.net/public/nrwg1.avi)

_(Editor's note: Upon rewatching this video I realize how bad it is, especially the audio. But I chose to leave it here for historical purposes.)_

So the idea here is that you can switch which direction gravity pulls.  I thought that seemed like a kind of robot-y, ninja-y sort of thing to be able to do.  I guess you’d classify this as a puzzle platformer?  I had a couple of aims in making this game.  In no particular order:

* I wanted a break from a bigger project that I’m embarking on.  With this bigger project I’m in the phase that requires a lot of thinking and not a lot of coding.  Since I like to code, this was a nice break from that.
* I wanted to try an exercise in simplicity of game code.  Being a software architect at work let’s me learn about all kinds of good programming practices.  I wanted to test applying them in a game (not that I didn’t apply some good programming practices in other games, I just wanted it to be more of an emphasis in this one).  I think it turned out pretty well.  The main game engine itself is only around 400 lines of code.  The executable is only 67Kb, most of which I’m sure is embedded PNGs.  I even added some unit tests.  They were sucky unit tests, and I didn’t create very many of them, but even a small number of sucky unit tests saved my bacon more than once.
* I wanted a snazzy level editor.  I ended up with a so-so editor, but it’s a better editor than I’ve made before.  All the level editing is done in the editor (no creating images outside and then loading them in or anything like that) and is WYSIWYG.  It even lets you go straight from editing to play testing the level.  Very handy.  It still has a fair amount of work before I’d release it to the general public, but at least it’s something I would consider releasing to someone else.

I’m sure there were some other aims too, but those are the ones I could think of right now.

So what’s in the future for Ninja Robot Winning Gameshow?  There are some improvements that I’d like to make at some point in the future.  I don’t know that I’ll actually make any of them, much less all of them.  But it’s a list, and we all like lists, right?  When and how many I make will probably depend on how many people ask for them.  So if you want them, ask for them.

* More levels.  I think the game as it is has 15 levels.  More levels = good, right?
* Going along with more levels, I’d like to release the level editor publicly.  Maybe let some other people make some levels for me.  I’m sure that there are many better level designers out there than me.  Someone who played the game told me that the levels were way too hard.  I thought they were way too easy.  I’m sure I could have a much better progression from easy to difficult.
* Revisit the music.  I like all the individual tracks that are in the game, but I don’t think they all go together terribly well.  I’d like to revisit the music and probably add more tracks.
* More death phrases and commercials would be good I’m sure.
* I thought it’d be cool to add an instant replay if you die in a particularly interesting way (determining what that means programmatically would be half the fun).
* Remember which levels you’ve beaten and let you resume the last level you were on even if you quit the game.  I didn’t think it was that important with only 15 levels (all of which I thought were too easy anyway, as previously mentioned), but with more levels it would be more important.
* I don’t like the sound engine I used much at all (more on that in another post).  I’d like to replace it with something better.  I encapsulated it away, so hopefully that will be easy to do in the future.

Is that a big enough list of improvements for something that’s just barely being released?  I hope so.  Makes me feel depressed. 🙂

Enough talk.  On to the game!  The game requires the .NET Framework 2.0 or later.  I created it on a dual core 1.7Ghz machine with 2GB of RAM.  On my machine it uses almost no CPU power, so I’m assuming it will run on something with much lower specs.
To install the game, simply unzip the files and put them somewhere.  Run NinjaRobot.exe to start the game.  You move around using the arrows keys.  Jump using the control key.  When you’re playing you can press ‘N’ to switch to a different music track (actually a random music track, so it won’t always be different).
A couple of hints:

* Don’t touch the spikes.  Or the baddies.  They both hurt.
* You can’t run out of lives.  You can keep playing forever.  But if you die too frequently then you’ll have to go to a commercial break and do an endorsement of “This Product”.
* If you’re having trouble jumping over things, push in the opposite direction gravity is pulling to stay in the air longer when you jump.  This let’s you jump both higher and farther.
* If you think that the game is too hard and that one of the levels is impossible, I know that they are all beatable.  I did it once, honest!  I may provide a walkthrough video at some point if anyone is interested in it.
* If you think that the game is too easy and that there aren’t enough levels, let me know and I’ll send you the level editor and let you make some more!
* If you want to put in your own music, put some MP3s in the Sound\Music directory.  The game will look for any files that have “level” in the file name and try to play those during the levels.  I know MP3s and WAVs work.  I haven’t tried any other formats.
* The lame audio library I used has 32-bit and 64-bit versions (part of why I want to replace it with something else).  I made two versions of the game, one with the 32-bit audio DLL, the other with the 64-bit version (it’s just that one DLL that’s different between the two).  Download the appropriate version for your machine.  (Start with the 32-bit version if you’re not sure which you need.  If it doesn’t work, try the 64-bit version.)
I think that’s about it.  Is this the best game you’ve ever played?  Does it totally suck?  Let me know what you think.  I hope you enjoy.

Download Section

[Ninja Robot Winning Gameshow 32-bit](https://mythicantdownloads.blob.core.windows.net/public/nrwg32.zip)

[Ninja Robot Winning Gameshow 64-bit](https://mythicantdownloads.blob.core.windows.net/public/nrwg64.zip)
