using Microsoft.EntityFrameworkCore;
using Bokcitat.Api.Models;

namespace Bokcitat.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}