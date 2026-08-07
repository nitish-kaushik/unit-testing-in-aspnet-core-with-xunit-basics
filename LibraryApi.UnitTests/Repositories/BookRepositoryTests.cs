using LibraryApi.Data;
using LibraryApi.Repositories;
using LibraryApi.UnitTests.Fixtures;

namespace LibraryApi.UnitTests.Repositories;

[Collection("LibraryDbContextCollection")]
public class BookRepositoryTests
{
    private readonly IBookRepository _bookRepository;

    public BookRepositoryTests(LibraryDbContextFixture fixture)
    {
        _bookRepository = new BookRepository(fixture.DbContext);
    }

    [Fact]
    public async Task GetAllBooksTest()
    {
        var output = await _bookRepository.GetAllBooksAsync();

        Assert.Equal(5, output.Count());
    }

    [Fact]
    public async Task GetBookByIdTest()
    {
        var output = await _bookRepository.GetBookByIdAsync(5);
        Assert.Equal(5, output.Id);
    }
}
