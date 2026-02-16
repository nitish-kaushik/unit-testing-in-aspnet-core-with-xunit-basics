using LibraryApi.Models;

namespace LibraryApi.Repositories;

public interface IBookRepository
{
    Task<Book?> GetBookByIdAsync(int id);
    Task<IEnumerable<Book>> GetAllBooksAsync();
    Task<Book> CreateBookAsync(Book book);
    Task<bool> UpdateBookAsync(int id, Book book);
    Task<bool> DeleteBookAsync(int id);
}
