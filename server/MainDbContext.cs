using Microsoft.EntityFrameworkCore;
namespace Gfa;

public class MainDbContext: DbContext
{
    public DbSet<Person> Person { get; set; } = null!;
}
