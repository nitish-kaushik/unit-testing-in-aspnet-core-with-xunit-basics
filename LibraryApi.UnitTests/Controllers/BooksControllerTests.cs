using LibraryApi.Controllers;
using LibraryApi.Repositories;
using Moq;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.UnitTests.Controllers;

public class BooksControllerTests
{
    [Fact]
    public async Task GetAllBooks_Returns_OkResult()
    {
        // Arrange
        List<Book> output =
        [
            new Book()
            {
                Id = 1, Title = "Book 1", Author = "Author 1", IsAvailable = true, PublishedDate = DateTime.Now
            },
            new Book()
            {
                Id = 2, Title = "Book 2", Author = "Author 2", IsAvailable = false, PublishedDate = DateTime.Now
            }
        ];

        var booksRepositoryMock = new Mock<IBookRepository>();
        booksRepositoryMock.Setup(x => x.GetAllBooksAsync().Result).Returns(output);
        var controller = new BooksController(booksRepositoryMock.Object);

        // Act
        var result = await controller.GetAllBooks();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var books = Assert.IsAssignableFrom<IEnumerable<Book>>(okResult.Value);
        var book1 = okResult.Value as IEnumerable<Book>;
        Assert.Equal("Book 1", books.First().Title);
        Assert.Equal(2, books.Count());
        booksRepositoryMock.Verify(x => x.GetAllBooksAsync(), Times.Once);
    }

    [Fact]
    public async Task GetBook_Returns_ValidBook()
    {
        var output = new Book()
        {
            Id = 1, Title = "Book 1", Author = "Author 1", IsAvailable = true, PublishedDate = DateTime.Now
        };

        var booksRepositoryMock = new Mock<IBookRepository>();
        booksRepositoryMock.Setup(x => x.GetBookByIdAsync(It.Is<int>(y => y > 10)).Result).Returns(output);

        var controller = new BooksController(booksRepositoryMock.Object);

        var result = await controller.GetBook(2);

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var book = Assert.IsAssignableFrom<Book>(okResult.Value);
        Assert.Equal("Book 1", book.Title);
    }
}