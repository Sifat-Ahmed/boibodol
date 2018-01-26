using System.Collections.Generic;
using MVC_Test.Models;

namespace MVC_Test.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_Test.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        protected override void Seed(MVC_Test.DAL.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var postTypes = new List<PostType>
            {
                new PostType { TypeName = "Review"},
                new PostType { TypeName = "Buy"},
                new PostType { TypeName = "Sell"},
                new PostType { TypeName = "Exchange"}
            };

            //postTypes.ForEach(type => context.PostTypes.AddOrUpdate(type));

            var users = new List<User>
            {
                new User
                {
                    Email = "Sifat.69@live.com",
                    Password = "sifat",
                    Verified = true
                },
                new User
                {
                    Email = "Sithil@live.com",
                    Password = "sithil",
                    Verified = true
                },
                new User
                {
                    Email = "Dima@live.com",
                    Password = "dim",
                    Verified = true
                },
                new User
                {
                    Email = "Nafi@live.com",
                    Password = "nafi",
                    Verified = true
                }
            };


            // adding $$ the Dummy user $$ in the database


            //users.ForEach(user => context.Users.AddOrUpdate(user));

            var usersDetails = new List<UserDetails>
            {
                new UserDetails
                {
                    Name = "Sifat Ahmed",
                    UserId = 1,
                    Address = "Dhaka , Bangladesh",
                    Phone = "011111111111"
                },
                new UserDetails
                {
                    Name = "Fatima Tabsun",
                    UserId = 2,
                    Address = "Dhaka , Bangladesh",
                    Phone = "0222222222"
                },
                new UserDetails
                {
                    Name = "Tasnim Ferdous",
                    UserId = 3,
                    Address = "Dhaka , Bangladesh",
                    Phone = "0333333333333"
                },
                new UserDetails
                {
                    Name = "Nafiul Nawjis",
                    UserId = 4,
                    Address = "Dhaka , Bangladesh",
                    Phone = "0411112114544"
                }
            };

            //usersDetails.ForEach(userDetails => context.UserDetails.AddOrUpdate(userDetails));

            var categories = new List<Category>
            {
                new Category { CategoryName = "Sports" },
                new Category { CategoryName = "Novel" },
                new Category { CategoryName = "Educational" },
                new Category { CategoryName = "Detective" },
                new Category { CategoryName = "Drama" }
            };

            //categories.ForEach(category => context.Categories.AddOrUpdate(category));

            var reviews = new List<Book>
            {
                new Book
                {
                    Title = "Norwich The Olympic Village",
                    CategoryId = 1,
                    PostTypeId = 1,
                    UserId = 1,
                    Date = DateTime.Now.ToString(),
                    Details =   "Norwich, Vermont, population circa 3,000, has sent contestants to the Olympics almost every year since 1984, cheering on three gold medalists in the Winter Olympics in the same span of years that the entire country of Spain has produced two. When New York Times writer Karen Crouse discovered this gem of a New England town, she had to ask: How do they do it?"
                                +"In Norwich, Crouse captures the soul of a town with a 110-year-old general store that pretty well lives up to its motto: “If we don’t have it, you don’t need it.”" +
                                 "She talks to Olympians like moguls champion Hannah Kearney, middle - distance runner Andrew Wheating and snowboarder Kevin Pearce, but surprisingly few of the conversations are about winning or losing; they’re always about the people who made a difference in these Olympians lives."
                                +"In the straightforward style of the sportswriter she is, Crouse weaves town history and sports statistics together with heartfelt conversations with the parents and coaches who support all of the community’s children, not just the best of the best. " +
                                 "Readers might expect to hear about highly competitive “tiger” moms and dads with money to burn, but that’s not what Crouse finds.Instead, she uncovers a much more laid-back philosophy: Let kids try a bunch of stuff, celebrate with them when they find activities they enjoy, and love them no matter the outcome. Because “you’re never going to make biscuits out of them kittens,” as one old - timer says.Parents in Norwich are not set on molding their children into what they want them to be, but letting them be everything they can be."
                                +"By the time readers finish Crouse’s account, they may shift from wondering how Norwich does it to asking why everybody doesn’t do it this way." ,
                    IsApproved = true
                },
                new Book
                {
                    Title = "THE NIGHT MARKET Struggling to uncover lost memories and a conspiracy",
                    CategoryId = 4,
                    PostTypeId = 1,
                    UserId = 2,
                    Date = DateTime.Now.ToString(),
                    Details = "If you’re looking for a good book to curl up with and lull you to sleep, don’t read Jonathan Moore’s The Night Market—it’ll keep you awake all night. " +
                              "Moore’s latest novel is a noirish, moody mystery shrouded with conspiracies that would make any “X - Files” fan rejoice.The story begins routinely enough with its main protagonist, homicide investigator Ross Carver and his partner, Jenner, being dispatched to the scene of an apparent murder in an upscale San Francisco neighborhood. " +
                              "But things quickly take an unexpected and somewhat gory turn when the rapidly deteriorating body is examined.As Carver and Jenner begin making their initial assessment, they’re suddenly surrounded by federal agents in full hazmat suits and are whisked away from the crime scene.",
                    IsApproved = true
                },

                new Book
                {
                    Title = "THIS LOVE STORY WILL SELF-DESTRUCT When our paths crossed",
                    CategoryId = 5,
                    PostTypeId = 1,
                    UserId = 3,
                    Date = DateTime.Now.ToString(),
                    Details = "If you’re looking for a good book to curl up with and lull you to sleep, don’t read Jonathan Moore’s The Night Market—it’ll keep you awake all night. " +
                              "Moore’s latest novel is a noirish, moody mystery shrouded with conspiracies that would make any “X - Files” fan rejoice.The story begins routinely enough with its main protagonist, homicide investigator Ross Carver and his partner, Jenner, being dispatched to the scene of an apparent murder in an upscale San Francisco neighborhood. " +
                              "But things quickly take an unexpected and somewhat gory turn when the rapidly deteriorating body is examined.As Carver and Jenner begin making their initial assessment, they’re suddenly surrounded by federal agents in full hazmat suits and are whisked away from the crime scene.",
                    IsApproved = true
                },

                new Book
                {
                    Title = "THIS LOVE STORY WILL SELF-DESTRUCT When our paths crossed",
                    CategoryId = 5,
                    PostTypeId = 1,
                    UserId = 4,
                    Date = DateTime.Now.ToString(),
                    Details = "If you’re looking for a good book to curl up with and lull you to sleep, don’t read Jonathan Moore’s The Night Market—it’ll keep you awake all night. " +
                              "Moore’s latest novel is a noirish, moody mystery shrouded with conspiracies that would make any “X - Files” fan rejoice.The story begins routinely enough with its main protagonist, homicide investigator Ross Carver and his partner, Jenner, being dispatched to the scene of an apparent murder in an upscale San Francisco neighborhood. " +
                              "But things quickly take an unexpected and somewhat gory turn when the rapidly deteriorating body is examined.As Carver and Jenner begin making their initial assessment, they’re suddenly surrounded by federal agents in full hazmat suits and are whisked away from the crime scene.",
                    IsApproved = true
                },

                new Book
                {
                    Title = "Feluda Samagra",
                    CategoryId = 4,
                    PostTypeId = 2,
                    UserId = 4,
                    Date = DateTime.Now.ToString(),
                    Details = "ফেলুদার আরেকটি দুর্দান্ত গোয়েন্দাগল্প। সমাদ্দারের চাবি গল্পটির শুরু হয় রাধারমণ সমাদ্দার নামের এক ধনী বৃদ্ধ প্রয়াত হওয়ার সূত্র ধরে।" +
                              " রাধারমণ বাবু পেশায় উকিল হলেও তাঁর ঝোঁক ছিল গান-বাজনার দিকে, তাই পয়সা ও পসার হয়ে গেলে তিনি ওকালতি ছেড়ে শুধু গান ও বাদ্যযন্ত্র সংগ্রহের দিকে মন দেন। " +
                              "সঙ্গীতের নেশা আর কৃপণস্বভাবের কারণে হাতেগোণা দুয়েকজন বাদে রাধারমণবাবুর সাথে কারোরই খুব একটা যোগাযোগ ছিল না, তাই তিনি মারা গেলে মণিমোহন সমাদ্দার নামের এক ভাইপোর হাতে তাঁর বিষয়-সম্পত্তির ভার এসে পড়ে। " +
                              "সদ্যপ্রয়াত কাকা যে যথেষ্ট ধনী ছিলেন, মণিমোহনবাবু তা জানতেন, কিন্তু কাকার ঘর তন্ন তন্ন করে খুঁজেও বাদ্যযন্ত্র ছাড়া আর কিছু খুঁজে না পেয়ে শেষ পর্যন্ত তিনি ফেলুদার শরণাপন্ন হন। অনুরোধটি অভিনব, তাই ফেলুদা হারানো টাকার হেঁয়ালী সমাধানে রাজি হয়, কিন্ত তাঁর ধারণা ছিলনা যে প্রয়াত রাধারমণের বুদ্ধি ও বর্তমান চরিত্রদের কার্যকলাপ রহস্যটিকে কতটা প্যাঁচালো করে তুলবে।" +
                              "ইংরেজি ভাষায় লিখা বই বাংলায় অনুবাদ হবে এটাই স্বাভাবিক। কিন্তু হাতে গোনা যে কয়টি বাংলা বই ইংরেজি ভাষায় অনুবাদ হয়েছিল তারমধ্যে ফেলুদা একটি।যা বাংলা সাহিত্যে এক বিরল দৃষ্টান্ত।",
                    IsApproved = true,
                    Status = "Unsold",
                    Price = 160.00m
                },
                new Book
                {
                    Title = "Feluda Samagra by Satyajit",
                    CategoryId = 4,
                    PostTypeId = 2,
                    UserId = 1,
                    Date = DateTime.Now.ToString(),
                    Details = "ফেলুদার আরেকটি দুর্দান্ত গোয়েন্দাগল্প। সমাদ্দারের চাবি গল্পটির শুরু হয় রাধারমণ সমাদ্দার নামের এক ধনী বৃদ্ধ প্রয়াত হওয়ার সূত্র ধরে।" +
                              " রাধারমণ বাবু পেশায় উকিল হলেও তাঁর ঝোঁক ছিল গান-বাজনার দিকে, তাই পয়সা ও পসার হয়ে গেলে তিনি ওকালতি ছেড়ে শুধু গান ও বাদ্যযন্ত্র সংগ্রহের দিকে মন দেন। " +
                              "সঙ্গীতের নেশা আর কৃপণস্বভাবের কারণে হাতেগোণা দুয়েকজন বাদে রাধারমণবাবুর সাথে কারোরই খুব একটা যোগাযোগ ছিল না, তাই তিনি মারা গেলে মণিমোহন সমাদ্দার নামের এক ভাইপোর হাতে তাঁর বিষয়-সম্পত্তির ভার এসে পড়ে। " +
                              "সদ্যপ্রয়াত কাকা যে যথেষ্ট ধনী ছিলেন, মণিমোহনবাবু তা জানতেন, কিন্তু কাকার ঘর তন্ন তন্ন করে খুঁজেও বাদ্যযন্ত্র ছাড়া আর কিছু খুঁজে না পেয়ে শেষ পর্যন্ত তিনি ফেলুদার শরণাপন্ন হন। অনুরোধটি অভিনব, তাই ফেলুদা হারানো টাকার হেঁয়ালী সমাধানে রাজি হয়, কিন্ত তাঁর ধারণা ছিলনা যে প্রয়াত রাধারমণের বুদ্ধি ও বর্তমান চরিত্রদের কার্যকলাপ রহস্যটিকে কতটা প্যাঁচালো করে তুলবে।" +
                              "ইংরেজি ভাষায় লিখা বই বাংলায় অনুবাদ হবে এটাই স্বাভাবিক। কিন্তু হাতে গোনা যে কয়টি বাংলা বই ইংরেজি ভাষায় অনুবাদ হয়েছিল তারমধ্যে ফেলুদা একটি।যা বাংলা সাহিত্যে এক বিরল দৃষ্টান্ত।",
                    IsApproved = true,
                    Status = "Unsold",
                    Price = 260.00m
                },
                new Book
                {
                    Title = "Feluda Samagra By Satyajit Roy",
                    CategoryId = 4,
                    PostTypeId = 2,
                    UserId = 2,
                    Date = DateTime.Now.ToString(),
                    Details = "ফেলুদার আরেকটি দুর্দান্ত গোয়েন্দাগল্প। সমাদ্দারের চাবি গল্পটির শুরু হয় রাধারমণ সমাদ্দার নামের এক ধনী বৃদ্ধ প্রয়াত হওয়ার সূত্র ধরে।" +
                              " রাধারমণ বাবু পেশায় উকিল হলেও তাঁর ঝোঁক ছিল গান-বাজনার দিকে, তাই পয়সা ও পসার হয়ে গেলে তিনি ওকালতি ছেড়ে শুধু গান ও বাদ্যযন্ত্র সংগ্রহের দিকে মন দেন। " +
                              "সঙ্গীতের নেশা আর কৃপণস্বভাবের কারণে হাতেগোণা দুয়েকজন বাদে রাধারমণবাবুর সাথে কারোরই খুব একটা যোগাযোগ ছিল না, তাই তিনি মারা গেলে মণিমোহন সমাদ্দার নামের এক ভাইপোর হাতে তাঁর বিষয়-সম্পত্তির ভার এসে পড়ে। " +
                              "সদ্যপ্রয়াত কাকা যে যথেষ্ট ধনী ছিলেন, মণিমোহনবাবু তা জানতেন, কিন্তু কাকার ঘর তন্ন তন্ন করে খুঁজেও বাদ্যযন্ত্র ছাড়া আর কিছু খুঁজে না পেয়ে শেষ পর্যন্ত তিনি ফেলুদার শরণাপন্ন হন। অনুরোধটি অভিনব, তাই ফেলুদা হারানো টাকার হেঁয়ালী সমাধানে রাজি হয়, কিন্ত তাঁর ধারণা ছিলনা যে প্রয়াত রাধারমণের বুদ্ধি ও বর্তমান চরিত্রদের কার্যকলাপ রহস্যটিকে কতটা প্যাঁচালো করে তুলবে।" +
                              "ইংরেজি ভাষায় লিখা বই বাংলায় অনুবাদ হবে এটাই স্বাভাবিক। কিন্তু হাতে গোনা যে কয়টি বাংলা বই ইংরেজি ভাষায় অনুবাদ হয়েছিল তারমধ্যে ফেলুদা একটি।যা বাংলা সাহিত্যে এক বিরল দৃষ্টান্ত।",
                    IsApproved = true,
                    Status = "Unsold",
                    Price = 180.50m
                },

            };

            //reviews.ForEach(review => context.Books.AddOrUpdate(review));

            var comments = new List<Comment>
            {
                new Comment
                {
                    PostId = 1,
                    PostTypeId = 1,
                    UserId = 1,
                    CommentText = "This review is one of the best reviews I have read in a long time. Worth Reading!",
                    Date = DateTime.Now.ToString()
                },
                new Comment
                {
                    PostId = 1,
                    PostTypeId = 1,
                    UserId = 2,
                    CommentText = "This review is one of the best reviews I have read in a long time. Worth Reading!",
                    Date = DateTime.Now.ToString()
                },
                new Comment
                {
                    PostId = 2,
                    PostTypeId = 1,
                    UserId = 3,
                    CommentText = "This review is one of the best reviews I have read in a long time. Worth Reading!",
                    Date = DateTime.Now.ToString()
                },
                new Comment
                {
                    PostId = 2,
                    PostTypeId = 1,
                    UserId = 1,
                    CommentText = "This review is one of the best reviews I have read in a long time. Worth Reading!",
                    Date = DateTime.Now.ToString()
                },
                new Comment
                {
                    PostId = 1,
                    PostTypeId = 1,
                    UserId = 3,
                    CommentText = "This review is one of the best reviews I have read in a long time. Worth Reading!",
                    Date = DateTime.Now.ToString()
                },
                new Comment
                {
                    PostId = 5,
                    PostTypeId = 2,
                    UserId = 1,
                    CommentText = "১০০ টাকা ??",
                    Date = DateTime.Now.ToString()
                },
                new Comment
                {
                    PostId = 6,
                    PostTypeId = 2,
                    UserId = 2,
                    CommentText = "১০০ টাকা ??",
                    Date = DateTime.Now.ToString()
                },


            };

            //comments.ForEach(comment => context.Comments.AddOrUpdate(comment));

            //context.SaveChanges();



        }
    }
}
