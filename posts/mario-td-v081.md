I had a little bit of time so I worked on Mario TD.  I probably should have been grading, but this was more fun.  At Rebecca's suggestion I slowed down and thinned out the enemies.  That was probably a good idea.  I have to remember that not everyone has played all the levels 400 times.

The most noticeable change is in the UI.  It always bugged me that the upgrade buttons were on top of the map, so I moved them off to the side.  I added in some little explanations about what the buttons do when you mouse over them too.  I really like how the images gray out when the buttons are disabled.  I wanted to do that, but I was afraid I was going to have to make my own buttons that did that, but lo and behold the .NET buttons already know how to do that!

 ![Mario TD v0.8.1 screenshot](/images/mario-td-v081-1.png)

The other change that took a lot longer to get working right but that is probably a lot less noticeable is that I added support for enemy projectiles in addition to player projectiles.  So that means that the enemies can throw things now too.  At the moment the Boomerang Bros. are the only ones that take advantage of that, but I'm working on another enemy type that will use that capability as well.  It should be pretty cool when I get it done.  Doing that reminded me how inflexible my enemy architecture is.  I don't think I'll probably fix it for this project, but it's something to remember for the future.

Anyway, the requirements and installation procedure (okay, unzipping procedure) are the same as before.  Enjoy!
