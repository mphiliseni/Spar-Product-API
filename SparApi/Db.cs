namespace SparApi.Db;

public record Product{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal  Price { get; set; }  
    public int Stock { get; set; }
    public string? ImageUrl { get; set; }
    public string? Category { get; set; }
}

public class ProductDb()
{
    private static List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Description = "Coffee", Price = 10.99m, Stock = 100, ImageUrl = "https://postimg.cc/kVJtmVpX", Category = "Category 1" },
        new Product { Id = 2, Name = "Product 2", Description = "Milk", Price = 20.99m, Stock = 50, ImageUrl = "https://postimg.cc/kVJtmVpX", Category = "Category 2" },
        new Product { Id = 3, Name = "Product 3", Description = "Sugar", Price = 30.99m, Stock = 0, ImageUrl = "https://postimg.cc/kVJtmVpX", Category = "Category 3" }
    };
    //
    public static List<Product> GetProducts()  // Get all products
    {
        return _products;
    }
    public static Product? GetProductById(int id) // Get product by ID
    {
        return _products.SingleOrDefault(p => p.Id == id);
    }
    public static Product CreateProduct(Product product) // Create a new product
    {
        _products.Add(product);
        return product;
    }
    public static Product UpdateProduct(Product update) // Update an existing pproduct
    {
        _products = _products.Select(Product =>
        {
            if (Product.Id == update.Id)
            {
                Product.Name = update.Name;
                Product.Description = update.Description;
                Product.Price = update.Price;
                Product.Stock = update.Stock;
                Product.ImageUrl = update.ImageUrl;
                Product.Category = update.Category;
            }
            return Product;
        }).ToList();
        return update;
    }

    //delete product
    public static void RemoveProduct(int id)
    {
        _products = _products.FindAll(p => p.Id != id).ToList();
    }
}
