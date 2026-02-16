using LibraryApi.Data;
using LibraryApi.Models;

namespace LibraryApi.Data;

public static class DbInitializer
{
    public static void Initialize(LibraryDbContext context)
    {
        // Ensure the database is created
        context.Database.EnsureCreated();

        // Check if we already have data
        if (context.Books.Any())
        {
            return; // Database has been seeded
        }

        var books = new Book[]
        {
            new Book
            {
                Title = "Clean Code",
                Author = "Robert C. Martin",
                PublishedDate = new DateTime(2008, 8, 1),
                IsAvailable = true
            },
            new Book
            {
                Title = "The Pragmatic Programmer",
                Author = "David Thomas and Andrew Hunt",
                PublishedDate = new DateTime(2019, 9, 13),
                IsAvailable = true
            },
            new Book
            {
                Title = "Design Patterns",
                Author = "Erich Gamma",
                PublishedDate = new DateTime(1994, 10, 31),
                IsAvailable = false
            },
            new Book
            {
                Title = "Refactoring",
                Author = "Martin Fowler",
                PublishedDate = new DateTime(2018, 11, 20),
                IsAvailable = true
            },
            new Book
            {
                Title = "Domain-Driven Design",
                Author = "Eric Evans",
                PublishedDate = new DateTime(2003, 8, 20),
                IsAvailable = true
            }
        };

        context.Books.AddRange(books);
        context.SaveChanges();
    }
}
