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
        const string ContactPath = "docs/contact.html";
        static string template;
        static Markdown markdownConverter;

        static void Main(string[] args)
        {
            template = File.ReadAllText("template");
            markdownConverter = new Markdown();

            GenerateIndexPage();
            GenerateContactPage();
            GenerateGamePages();
            GenerateBlogPages();
            GenerateMainBlogPage();
        }

        private static void GenerateContactPage()
        {
            ConvertMarkdownToHtml("contact.md", ContactPath);
        }

        private static void GenerateMainBlogPage()
        {
            var blogHtml = "";
            foreach (var post in Posts.List.OrderByDescending(x => x.PublishDate))
            {
                blogHtml += $"\r\n<a class='blog-list-item' href='/blog/{post.Name}'>\r\n";
                blogHtml += post.ToHtml();
                blogHtml += "</a>\r\n";
            }
            blogHtml = template.Replace("{template}", blogHtml);
            File.WriteAllText(MainBlogPath, blogHtml);
        }

        private static void GenerateBlogPages()
        {
            var postMarkdownFilePaths = Directory.EnumerateFiles("posts", "*.md");
            foreach (var postMarkdownFile in postMarkdownFilePaths)
            {
                string name = Path.GetFileNameWithoutExtension(postMarkdownFile);
                var postMetadata = Posts.List.Single(x => x.Name == name);
                var htmlFilename = name + ".html";
                var markdown = File.ReadAllText(postMarkdownFile);
                var htmlWithoutTemplate = markdownConverter.Transform(markdown);
                htmlWithoutTemplate = "\r\n" + postMetadata.ToHtml() + "\r\n" + htmlWithoutTemplate;
                var fullHtml = template.Replace("{template}", htmlWithoutTemplate);

                File.WriteAllText(Path.Combine("docs", "blog", htmlFilename), fullHtml);
            }
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
            gameMarkdownFilePaths = gameMarkdownFilePaths.Except(new[] { ".\\readme.md" }).ToList();
            foreach (var markdownFilePath in gameMarkdownFilePaths)
            {
                var htmlFilename = Path.GetFileNameWithoutExtension(markdownFilePath) + ".html";
                ConvertMarkdownToHtml(markdownFilePath, Path.Combine(".", "docs", htmlFilename));
            }
        }

        private static void ConvertMarkdownToHtml(string markdownFilePath, string htmlFilePath)
        {
            System.Console.WriteLine($"Converting {markdownFilePath} to {htmlFilePath}");
            string html = GenerateHtml(markdownFilePath);
            File.WriteAllText(htmlFilePath, html);
        }

        private static string GenerateHtml(string markdownFilePath)
        {
            var markdown = File.ReadAllText(markdownFilePath);
            var htmlWithoutTemplate = markdownConverter.Transform(markdown);
            return template.Replace("{template}", htmlWithoutTemplate);
        }
    }

}
