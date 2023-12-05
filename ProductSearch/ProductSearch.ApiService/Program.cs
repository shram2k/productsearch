using ProductSearch.Core;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire components.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapGet("/GetProductsByNameAsync", (string productName) =>
{
    return new Product
    {
        Name = productName,
        Description = productName,
        Price = 12.45m,
        Rating = 3,
        Reviews = ["Good", "Better"]
    };
});

app.MapDefaultEndpoints();

app.Run();

