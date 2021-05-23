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
                Description = "Donkey Kong ASCII description."
            },
            new Game
            {
                Name = "Mario TD",
                Link = "/mario-td.html",
                Description = ""
            },
            new Game
            {
                Name = "Ninja Robot Winning Gameshow",
                Link = "/ninja-robot-winning-gameshow.html",
                Description = ""
            },
            new Game
            {
                Name = "Space Invaders ASCII",
                Link = "/space-invaders-ascii.html",
                Description = ""
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
            return $"\t<div class='game'>\r\n\t\t<a href='{Link}'><h2>{Name}</h2></a>\r\n<img src='{Image}'>\r\n\t\t{Description}\r\n\t</div>";
        }
    }
}
