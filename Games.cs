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
                Link = "https://fableofgriselda.com",
                Description = "A bootleg demake of The Legend of Zelda on the original NES."
            },
            new Game
            {
                Name = "Donkey Kong ASCII",
                Link = "/donkey-kong-ascii.html",
                Description = ""
            },
            new Game
            {
                Name = "Mario TD",
                Link = "/mario-td.html",
                Description = ""
            }
        };
    }

    public class Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public string ToHtml()
        {
            return $"\t<div class='game'>\r\n\t\t<h2>{Name}</h2>\r\n\t\t{Description}\r\n\t</div>";
        }
    }
}
