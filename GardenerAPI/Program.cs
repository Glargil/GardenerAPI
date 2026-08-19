using Scalar.AspNetCore;
using GardenerAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi(); // .NET 9 built-in OpenAPI (or use AddSwaggerGen if you're on .NET 8)
builder.Services.AddDbContext<ProjectDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Optional: auth services, etc.

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // exposes /openapi/v1.json
}

// Scalar UI
app.MapScalarApiReference(options =>
{
    options.WithTitle("Gardener API");
    // options.WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

