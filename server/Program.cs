var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var app = builder.Build();
app.MapControllers();
var url = "http://localhost:3000";
Console.WriteLine("Launching at {0}", url);
app.Run(url);
