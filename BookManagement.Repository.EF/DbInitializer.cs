using BookManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManagement.Repository.EF
{
    public static class DbInitializer
    {
        public static void Initialize(BookContext context)
        {
            context.Database.EnsureCreated();

            if (context.Set<Book>().Any())
            {
                return;
            }

            var user = new User
            {
                ID = Guid.NewGuid().ToString(),
                Name = "admin",
                Password = "admin"
            };
            context.Add(user);

            var books = new List<Book>
            {
                new Book
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "book1",
                    Price = 1,
                    CreateTime = DateTime.Now
                },
                new Book
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "book2",
                    Price = 2,
                    CreateTime = DateTime.Now
                },
                new Book
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = "book3",
                    Price = 3,
                    CreateTime = DateTime.Now
                }
            };
            context.AddRange(books);

            context.SaveChanges();
        }
    }
}
