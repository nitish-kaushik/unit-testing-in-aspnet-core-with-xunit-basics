using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Repositories;

public class BookRepository(LibraryDbContext context) : IBookRepository
{
    public async Task<Book?> GetBookByIdAsync(int id)
    {
        return await context.Books.FindAsync(id);
    }
    
    public async Task<IEnumerable<Book>> GetAllBooksAsync()
    {
        return await context.Books.ToListAsync();
    }
    
    public async Task<Book> CreateBookAsync(Book book)
    {
        context.Books.Add(book);
        await context.SaveChangesAsync();
        return book;
    }
    
    public async Task<bool> UpdateBookAsync(int id, Book book)
    {
        var existingBook = await GetBookByIdAsync(id);
        if (existingBook == null)
            return false;
        
        existingBook.Title = book.Title;
        existingBook.Author = book.Author;
        existingBook.IsAvailable = book.IsAvailable;
        existingBook.PublishedDate = book.PublishedDate;
        
        context.Books.Update(existingBook);
        await context.SaveChangesAsync();
        return true;
    }
    
    public async Task<bool> DeleteBookAsync(int id)
    {
        var book = await GetBookByIdAsync(id);
        if (book == null)
            return false;
        
        context.Books.Remove(book);
        await context.SaveChangesAsync();
        return true;
    }
}
