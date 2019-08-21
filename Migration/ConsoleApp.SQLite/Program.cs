using System;
using System.Linq;

namespace ConsoleApp.SQLite
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new BloggingContext())
            {
                //var elliotBlog = new Blog { Url = "http://elliot.com/blog", Author = "Elliot" };
                //var aprilBlog = new Blog { Url = "http://blog.april.co.uk", Author = "April" };


                //db.Blogs.Add(elliotBlog);
                //db.Blogs.Add(aprilBlog);

                //var count = db.SaveChanges();

                //Console.WriteLine($"{count} records saved to database");

                //db.Posts.Add(new Post { Blog = elliotBlog, Title = "Blog 1" });
                //db.Posts.Add(new Post { Blog = elliotBlog, Title = "Blog 2" });
                //db.Posts.Add(new Post { Blog = aprilBlog, Title = "Blog 1" });
                //db.Posts.Add(new Post { Blog = aprilBlog, Title = "Blog 2" });
                //count = db.SaveChanges();

                //Console.WriteLine($"{count} posts saved to the database");

                //Console.WriteLine( );

                //select count(*) from Blogs
                var blogCount = db.Blogs.Count();

                Console.WriteLine($"{db.Blogs.Count()} blogs in database:");

                //select * from Blogs;
                var allBlogs = db.Blogs;

                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }

                Console.WriteLine($"\nBlog Authors: ");

                //select Author from Blogs;
                var blogAuthors = db.Blogs.Select(b => b.Author);

                foreach (var author in db.Blogs)
                {
                    Console.WriteLine($" - {author}");
                }

                //select Url from Blogs where Author = 'Elliot';
                var elliotsBlogUrl = db.Blogs
                                    .Where(b => b.Author == "Elliot")
                                    .Select(b => b.Url)
                                    .Single();

                Console.WriteLine($"\nElliot's blog URL: {elliotsBlogUrl}");

                //select BlogId from Blogs where Author = 'April'
                //select Title from Posts where BlogId = <subquery>
                var aprilsBlogID = db.Blogs.Where(b => b.Author == "April")
                                        .Select(b => b.BlogID)
                                        .Single();

                var aprilsPostTitles = db.Posts.Where(p => p.BlogId == aprilsBlogID)
                                                .Select(p => p.Title);

                Console.WriteLine("\nApril's posts: ");

                foreach (var title in aprilsPostTitles)
                {
                    Console.WriteLine($" - {title}");
                }

                //same thing...
                //Console.WriteLine("\nApril's posts another way: ");

                //var aprilsBlog = db.Blogs.Where(b => b.Author == "April").Single();

                //foreach(var p in aprilsBlog.Posts)
                //{
                //    Console.WriteLine($" - {p.Title}");
                //}
            }



        }
    }
}
