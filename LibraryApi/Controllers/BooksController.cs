using LibraryApi.Models;
using LibraryApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController(IBookRepository bookRepository) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
    {
        var books = await bookRepository.GetAllBooksAsync();
        return Ok(books);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBooks2()
    {
        var books = await bookRepository.GetAllBooksAsync();
        return Ok(books);
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> GetAllBooks3()
    {
        var books = await bookRepository.GetAllBooksAsync();
        return books;
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        var book = await bookRepository.GetBookByIdAsync(id);

        if (book == null)
            return NotFound();

        return Ok(book);
    }

    [HttpPost]
    public async Task<ActionResult<Book>> CreateBook(Book book)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        try
        {
            var createdBook = await bookRepository.CreateBookAsync(book);
            return CreatedAtAction(nameof(GetBook), new { id = createdBook.Id }, createdBook);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ex.Message);
        }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateBook(int id, Book book)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        try
        {
            var success = await bookRepository.UpdateBookAsync(id, book);

            if (!success)
                return NotFound();

            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        var success = await bookRepository.DeleteBookAsync(id);

        if (!success)
            return NotFound();

        return NoContent();
    }
}
