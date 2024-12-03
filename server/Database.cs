using Microsoft.EntityFrameworkCore;
namespace Gfa;

public class Database: DbContext
{
    public DbSet<Person> Person { get; set; } = null!;

    public Database(DbContextOptions<Database> options)
        : base(options)
    {
    }
}
