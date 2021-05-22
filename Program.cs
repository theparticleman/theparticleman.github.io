using System;
using System.IO;
using System.Linq;

namespace MythicantSite
{
    class Program
    {
        const string IndexPath = "docs/index.html";

        static void Main(string[] args)
        {
            GenerateIndexPage();
        }

        private static void GenerateIndexPage()
        {
            var template = File.ReadAllText("template");
            var gamesHtml = string.Join("\r\n", Games.List.Select(x => x.ToHtml()));
            gamesHtml = $"<div class='games-list'>\r\n{gamesHtml}\r\n</div>";
            var indexHtml = template.Replace("{template}", gamesHtml);
            File.WriteAllText(IndexPath, indexHtml);
        }
    }


}
