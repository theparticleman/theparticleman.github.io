using System;
using System.Collections.Generic;

namespace MythicantSite
{
    public class Posts
    {
        public static List<Post> List = new List<Post>
        {
            new Post
            {
                Name = "a-website-reborn",
                Title = "A Website Reborn",
                PublishDate = DateTimeOffset.Parse("2020-05-23")
            },
            new Post
            {
                Name = "getting-started-presenting",
                Title = "Getting Started Presenting",
                PublishDate = DateTimeOffset.Parse("2019-10-19")
            },
            new Post
            {
                Name = "different-types-of-unit-tests",
                Title = "Different Types of Unit Tests",
                PublishDate = DateTimeOffset.Parse("2019-04-12")
            },
            new Post
            {
                Name = "a-brief-introduction",
                Title = "A Brief Introduction",
                PublishDate = DateTimeOffset.Parse("2007-11-24")
            }
        };
    }

    public class Post
    {
        public string Name { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public string Title { get; internal set; }

        public string ToHtml()
        {
            return $"<h2>{Title}</h2>\r\n<div class='published-date'>Published • {PublishDate.ToString("MMMM dd, yyyy")}</div>\r\n";
        }
    }
}
