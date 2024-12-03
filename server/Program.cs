using Gfa;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var dbPath = Path.Join("var", "main.db");
builder.Services.AddDbContext<MainDbContext>(
    options => options.UseSqlite($"Data Source={dbPath}")
);

var app = builder.Build();
app.MapControllers();
var url = "http://localhost:3000";
Console.WriteLine("Launching at {0}", url);
app.Run(url);
