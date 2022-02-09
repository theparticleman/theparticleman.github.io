using System;
using System.IO;
using System.Linq;
using MarkdownSharp;
using WilderMinds.RssSyndication;

namespace MythicantSite
{
    class Program
    {
        const string IndexPath = "docs/index.html";
        const string MainBlogPath = "docs/blog.html";
        const string ContactPath = "docs/contact.html";
        private const string MegaManScriptTag = "\r\n<script async src='megaman.js'></script>";
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
            GenerateRssFeed();
        }

        private static void GenerateContactPage()
        {
            ConvertMarkdownToHtml("contact.md", ContactPath);
        }

        private static void GenerateMainBlogPage()
        {
            var blogHtml = "";
            blogHtml += "<div id='rss-link'><a href='/rss.xml'>RSS Feed</a></div>";
            foreach (var post in Posts.List.OrderByDescending(x => x.PublishDate))
            {
                blogHtml += $"\r\n<a class='blog-list-item' href='/blog/{post.Name}'>\r\n";
                blogHtml += post.ToHtml();
                blogHtml += "</a>\r\n";
            }
            blogHtml += MegaManScriptTag;
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
            gamesHtml = $"<div class='games-list'>\r\n{gamesHtml}\r\n</div>" + MegaManScriptTag;
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

        private static void GenerateRssFeed()
        {
            System.Console.WriteLine("Generating rss.xml");
            var feed = new Feed
            {
                Title = "Mythicant Games",
                Link = new Uri("https://mythicant.com/"),
                Copyright = "© " + DateTime.Now.Year
            };
            foreach (var post in Posts.List.OrderByDescending(x => x.PublishDate).Take(20))
            {
                var item = new Item
                {
                    Title = post.Title,
                    PublishDate = post.PublishDate.DateTime,
                    Link = new Uri($"https://mythicant.com/blog/{post.Name}"),
                    FullHtmlContent = markdownConverter.Transform(File.ReadAllText($"posts/{post.Name}.md"))
                };
                feed.Items.Add(item);
            }
            var rss = feed.Serialize();
            File.WriteAllText("docs/rss.xml", rss);
        }
    }

}
