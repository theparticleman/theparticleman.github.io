using System;
using System.IO;
using System.Linq;

namespace MythicantSite
{
    class Program
    {
        const string IndexPath = "docs/index.html";
        const string MainBlogPath = "docs/blog.html";
        static string template;

        static void Main(string[] args)
        {
            template = File.ReadAllText("template");

            GenerateIndexPage();
            GenerateMainBlogPage();
        }

        private static void GenerateMainBlogPage()
        {
            var blogHtml = template.Replace("{template}", "");
            File.WriteAllText(MainBlogPath, blogHtml);
        }

        private static void GenerateIndexPage()
        {
            var gamesHtml = string.Join("\r\n", Games.List.Select(x => x.ToHtml()));
            gamesHtml = $"<div class='games-list'>\r\n{gamesHtml}\r\n</div>";
            var indexHtml = template.Replace("{template}", gamesHtml);
            File.WriteAllText(IndexPath, indexHtml);
        }
    }


}
