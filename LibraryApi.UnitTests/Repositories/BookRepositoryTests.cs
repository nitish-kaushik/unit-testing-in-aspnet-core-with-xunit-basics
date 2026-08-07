using LibraryApi.Data;
using LibraryApi.Repositories;
using LibraryApi.UnitTests.Fixtures;

namespace LibraryApi.UnitTests.Repositories;

//[Collection("LibraryDbContextCollection")]
public class BookRepositoryTests : IClassFixture<LibraryDbContextFixture>
{
    private readonly LibraryDbContext _dbContext;
    private readonly IBookRepository _bookRepository;

    public BookRepositoryTests(LibraryDbContextFixture fixture)
    {
        _dbContext = fixture.DbContext;
        _bookRepository = new BookRepository(_dbContext);
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
