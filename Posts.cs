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
                Name = "grumble-grumble",
                Title = "Grumble, Grumble...",
                PublishDate = DateTimeOffset.Parse("2022-03-18")
            },
            new Post
            {
                Name = "a-little-buddy-web-edition",
                Title = "A Little Buddy - Web Edition",
                PublishDate = DateTimeOffset.Parse("2022-2-8")
            },
            new Post
            {
                Name = "presentation-videos",
                Title = "Presentation Videos",
                PublishDate = DateTimeOffset.Parse("2021-10-29")
            },
            new Post
            {
                Name = "a-website-reborn",
                Title = "A Website Reborn",
                PublishDate = DateTimeOffset.Parse("2021-05-23")
            },
            new Post
            {
                Name = "getting-started-presenting",
                Title = "Getting Started Presenting",
                PublishDate = DateTimeOffset.Parse("2019-10-19")
            },
            new Post
            {
                Name = "living-in-a-world-without-qa",
                Title = "Living In A World Without QA",
                PublishDate = DateTimeOffset.Parse("2018-07-13")
            },
            new Post
            {
                Name = "practice-matters",
                Title = "Practice Matters",
                PublishDate = DateTimeOffset.Parse("2018-11-09")
            },
            new Post
            {
                Name = "shu-ha-ri",
                Title = "Shu Ha Ri",
                PublishDate = DateTimeOffset.Parse("2018-06-01")
            },
            new Post
            {
                Name = "what-does-deployment-look-like-at-pluralsight",
                Title = "What Does Deployment Look Like at Pluralsight?",
                PublishDate = DateTimeOffset.Parse("2016-12-19")
            },
            new Post
            {
                Name = "different-types-of-unit-tests",
                Title = "Different Types of Unit Tests",
                PublishDate = DateTimeOffset.Parse("2019-04-12")
            },
            new Post
            {
                Name = "sonr-trailer",
                Title = "SONR Trailer",
                PublishDate = DateTimeOffset.Parse("2010-07-18")
            },
            new Post
            {
                Name = "ninja-robot-winning-gameshow-around-and-about",
                Title = "Ninja Robot Winning Gameshow Around and About",
                PublishDate = DateTimeOffset.Parse("2010-04-23")
            },
            new Post
            {
                Name = "becoming-a-keyboard-sith",
                Title = "Becoming a Keyboard Sith!",
                PublishDate = DateTimeOffset.Parse("2010-06-30")
            },
            new Post
            {
                Name = "introducing-ninja-robot-winning-gameshow",
                Title = "Introducing Ninja Robot Winning Gameshow",
                PublishDate = DateTimeOffset.Parse("2009-06-16")
            },
            new Post
            {
                Name = "finally-another-post",
                Title = "Finally, Another Post",
                PublishDate = DateTimeOffset.Parse("2009-02-25")
            },
            new Post
            {
                Name = "a-little-buddy",
                Title = "A Little Buddy",
                PublishDate = DateTimeOffset.Parse("2008-10-06")
            },
            new Post
            {
                Name = "hurray-for-griselda",
                Title = "Hurray for Griselda!",
                PublishDate = DateTimeOffset.Parse("2008-09-20")
            },
            new Post
            {
                Name = "fable-of-griselda-finalish",
                Title = "Fable of Griselda - Final(ish)",
                PublishDate = DateTimeOffset.Parse("2008-09-07")
            },
            new Post
            {
                Name = "fable-of-griselda-try-it-out",
                Title = "Fable of Griselda - Try it Out",
                PublishDate = DateTimeOffset.Parse("2008-08-21")
            },
            new Post
            {
                Name = "fable-of-griselda",
                Title = "Fable of Griselda",
                PublishDate = DateTimeOffset.Parse("2008-08-16")
            },
            new Post
            {
                Name = "competitions",
                Title = "Competitions",
                PublishDate = DateTimeOffset.Parse("2008-08-05")
            },
            new Post
            {
                Name = "why-blogging-sucks-and-other-commentaries",
                Title = "Why Blogging Sucks and Other Commentaries",
                PublishDate = DateTimeOffset.Parse("2008-06-25")
            },
            new Post
            {
                Name = "mario-td-v0980",
                Title = "Mario TD v0.9.8.0",
                PublishDate = DateTimeOffset.Parse("2008-04-15")
            },
            new Post
            {
                Name = "excuses-and-a-few-other-random-thoughts",
                Title = "Excuses and a Few Other Random Thoughts",
                PublishDate = DateTimeOffset.Parse("2008-2-15")
            },
            new Post
            {
                Name = "a-bit-of-a-change",
                Title = "A Bit of a Change",
                PublishDate = DateTimeOffset.Parse("2008-01-09")
            },
            new Post
            {
                Name = "mario-td-v090",
                Title = "Mario TD v0.9.0",
                PublishDate = DateTimeOffset.Parse("2007-12-28")
            },
            new Post
            {
                Name = "donkey-kong-ascii",
                Title = "Donkey Kong - ASCII",
                PublishDate = DateTimeOffset.Parse("2007-12-13")
            },
            new Post
            {
                Name = "space-invaders-ascii",
                Title = "Space Invaders - ASCII",
                PublishDate = DateTimeOffset.Parse("2007-12-08")
            },
            new Post
            {
                Name = "mario-td-v081",
                Title = "Mario TD v0.8.1",
                PublishDate = DateTimeOffset.Parse("2007-12-02")
            },
            new Post
            {
                Name = "mario-td-screenshots",
                Title = "Mario TD Screenshots",
                PublishDate = DateTimeOffset.Parse("2007-11-24 4:39PM")
            },
            new Post
            {
                Name = "mario-td-v08",
                Title = "Mario TD v0.8",
                PublishDate = DateTimeOffset.Parse("2007-11-24 4:00PM")
            },
            new Post
            {
                Name = "gauntlet-ascii-survival-edition",
                Title = "Gauntlet ASCII - Survival Edition",
                PublishDate = DateTimeOffset.Parse("2007-11-24")
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
