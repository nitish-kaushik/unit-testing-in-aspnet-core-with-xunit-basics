using LibraryApi.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.UnitTests.Fixtures;


public class LibraryDbContextFixture : IAsyncLifetime
{
    public LibraryDbContext DbContext { get; private set; } = default!;

    public async ValueTask InitializeAsync()
    {
        var options = new DbContextOptionsBuilder<LibraryDbContext>()
            .UseInMemoryDatabase("TestLibraryDb")
            .Options;

        DbContext = new LibraryDbContext(options);
        await DbContext.Database.EnsureCreatedAsync();
        DbInitializer.Initialize(DbContext);
    }

    public async ValueTask DisposeAsync()
    {
        await DbContext.Database.EnsureDeletedAsync();
        await DbContext.DisposeAsync();
    }
}
