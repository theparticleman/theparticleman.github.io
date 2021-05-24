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
                Name = "test-post",
                PublishDate = DateTimeOffset.Parse("2020-05-23")
            },
            new Post
            {
                Name = "a-brief-introduction",
                PublishDate = DateTimeOffset.Parse("2007-11-24")
            }
        };
    }

    public class Post
    {
        public string Name { get; set; }
        public DateTimeOffset PublishDate { get; set; }

        public string ToHtml()
        {
            return "\r\n" + "Published " + PublishDate.ToString("MMMM dd, yyyy");
        }
    }
}
