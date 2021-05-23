using System;
using System.IO;
using System.Linq;
using MarkdownSharp;

namespace MythicantSite
{
    class Program
    {
        const string IndexPath = "docs/index.html";
        const string MainBlogPath = "docs/blog.html";
        static string template;
        static Markdown markdownConverter;

        static void Main(string[] args)
        {
            template = File.ReadAllText("template");
            markdownConverter = new Markdown();

            GenerateIndexPage();
            GenerateGamePages();
            GenerateMainBlogPage();
        }

        private static void GenerateMainBlogPage()
        {
            var blogHtml = template.Replace("{template}", "Coming Soon");
            File.WriteAllText(MainBlogPath, blogHtml);
        }

        private static void GenerateIndexPage()
        {
            var gamesHtml = string.Join("\r\n", Games.List.Select(x => x.ToHtml()));
            gamesHtml = $"<div class='games-list'>\r\n{gamesHtml}\r\n</div>";
            var indexHtml = template.Replace("{template}", gamesHtml);
            File.WriteAllText(IndexPath, indexHtml);
        }
        
        private static void GenerateGamePages()
        {
            var gameMarkdownFilePaths = Directory.EnumerateFiles(".", "*.md");
            foreach (var markdownFilePath in gameMarkdownFilePaths)
            {
                var htmlFilename = Path.GetFileNameWithoutExtension(markdownFilePath) + ".html";
                var markdown = File.ReadAllText(markdownFilePath);
                var htmlWithoutTemplate = markdownConverter.Transform(markdown);
                var html = template.Replace("{template}", htmlWithoutTemplate);
                File.WriteAllText(Path.Combine(".", "docs", htmlFilename), html);
            }
        }
    }


}
