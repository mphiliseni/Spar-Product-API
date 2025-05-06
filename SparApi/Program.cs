using Microsoft.OpenApi.Models;
using SparApi.Db;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Super Spar Api", Description ="Add to cart the product you like!", Version = "v1" });
});
var app = builder.Build();

if (app.Environment.IsDevelopment()) // Enable Swagger in development mode
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SparApi v1"));
}

app.MapGet("/", () => Results.Text("<h1 style='text-align:center;'>Welcome to Super Spar Api</h1>", "text/html"));

app.MapGet("/products/{id}", (int id) => ProductDb.GetProductById(id));     // Get product by ID
app.MapGet("/products", () => ProductDb.GetProducts()); // Get all products
app.MapPost("/products", (Product Product) => ProductDb.CreateProduct(Product));    // Create new product
app.MapPut("/products", (Product Product) => ProductDb.UpdateProduct(Product)); // Update product
app.MapDelete("/products/{id}", (int id) => ProductDb.RemoveProduct(id)); // Delete product


app.Run();
