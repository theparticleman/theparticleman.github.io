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
                Link = "https://www.fableofgriselda.com",
                Image = "fable-of-griselda.png",
                Description = "A bootleg demake of The Legend of Zelda on the original NES."
            },
            new Game
            {
                Name = "Donkey Kong ASCII",
                Link = "/donkey-kong-ascii.html",
                Image = "donkey-kong-ascii.png",
                Description = "Donkey Kong inspired, but with ASCII."
            },
            new Game
            {
                Name = "Mario TD",
                Link = "/mario-td.html",
                Image = "mario-td.png",
                Description = "Tower defense, but with 100% more Mario! Specifically, Super Mario Bros. 3!"
            },
            new Game
            {
                Name = "Maisemore",
                Link = "https://maisemore.azurewebsites.net",
                Description = "Real time, multiplayer text based adventure, inspired by games like Zork. Watch out for grues!"
            },
            new Game
            {
                Name = "Ninja Robot Winning Gameshow",
                Link = "/ninja-robot-winning-gameshow.html",
                Description = "Play as a ninja? And a robot? Awesome! Having to stop for commercial breaks when you die? Less awesome."
            },
            new Game
            {
                Name = "Space Invaders ASCII",
                Link = "/space-invaders-ascii.html",
                Description = "And you thought the original space invaders was old school."
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
            var target = Link.StartsWith("http") ? " target='_blank'" : "";
            return $"\t<div class='game'>\r\n\t\t<a href='{Link}'{target}><h2>{Name}</h2></a>\r\n<a href='{Link}'{target}><img src='{Image}'></a>\r\n\t\t{Description}\r\n\t</div>";
        }
    }
}
