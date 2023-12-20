using System.Collections.Generic;

namespace MythicantSite
{
    class Games
    {
        public static List<Game> List = new List<Game>
        {
            new Game
            {
                Name = "Fable of Griselda",
                Link = "/fable-of-griselda",
                Image = "images/fable-of-griselda.png",
                Description = "A bootleg demake of The Legend of Zelda on the original NES."
            },
            new Game
            {
                Name = "Donkey Kong ASCII",
                Link = "/donkey-kong-ascii",
                Image = "images/donkey-kong-ascii.png",
                Description = "Donkey Kong inspired, but with ASCII."
            },
            new Game
            {
                Name = "Maisemore",
                Link = "/maisemore",
                Image = "images/maisemore.png",
                Description = "Real time, multiplayer text based adventure, inspired by games like Zork. Watch out for grues!"
            },
            new Game
            {
                Name = "Space Invaders ASCII",
                Link = "/space-invaders-ascii",
                Image = "images/space-invaders-ascii.png",
                Description = "And you thought the original space invaders was old school."
            },
            new Game
            {
                Name = "Mario TD",
                Link = "/mario-td",
                Image = "images/mario-td.png",
                Description = "Tower defense, but with 100% more Mario! Specifically, Super Mario Bros. 3!"
            },
            new Game
            {
                Name = "Ninja Robot Winning Gameshow",
                Link = "/ninja-robot-winning-gameshow",
                Image = "images/ninja-robot-winning-gameshow.png",
                Description = "Play as a ninja? And a robot? Awesome! Having to stop for commercial breaks when you die? Less awesome."
            },
            new Game
            {
                Name = "Gauntlet ASCII - Survival Edition",
                Link = "/gauntlet-ascii-survival-edition",
                Image = "images/gauntlet-ascii-survival-edition.png",
                Description = "Like Gauntlet. But zombies. Lots of zombies. Oh, and ASCII."
            }
        };
    }

    public class Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }

        public string ToHtml()
        {
            var target = Link.StartsWith("http") ? " target='_blank' rel='noreferrer'" : "";
            return $"\t<div class='game'>\r\n\t\t<a href='{Link}'{target}><h2>{Name}</h2></a>\r\n\t\t<a href='{Link}'{target}><img src='{Image}' alt='{Name}'></a>\r\n\t\t{Description}\r\n\t</div>";
        }
    }
}
