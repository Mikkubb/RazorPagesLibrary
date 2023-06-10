﻿using Microsoft.EntityFrameworkCore;
using RazorPagesLibrary.Data;

namespace RazorPagesLibrary.Pages.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesLibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesLibraryContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null RazorPagesLibraryContext");
                }

                // Look for any books.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "The Hobbit",
                        Author = "J. R. R. Tolkien",
                        Genre = "Fantasy",
                        Price = 7.99M
                    },

                    new Book
                    {
                        Title = "The Lord of the Rings",
                        Author = "J. R. R. Tolkien",
                        Genre = "Fantasy",
                        Price = 9.99M
                    },

                    new Book
                    {
                        Title = "Harry Potter",
                        Author = "J. K. Rowling",
                        Genre = "Fantasy",
                        Price = 8.99M
                    },

                    new Book
                    {
                        Title = "Quo vadis",
                        Author = "Henryk Sienkiewicz",
                        Genre = "Novel",
                        Price = 10.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
