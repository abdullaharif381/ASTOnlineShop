using System.ComponentModel.DataAnnotations;

public class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Product name is required")]

    public string Name { get; set; }

    public string Description { get; set; }

    // Price of the product

    [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number")]

    public decimal Price { get; set; }

  

    // Quantity of the product in stock

    [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]

    public int Quantity { get; set; }

    public string Category { get; set; }

    public string ImageUrl { get; set; } // URL to the product image

    public string Manufacturer { get; set; } // Manufacturer of the product

    public string SKU { get; set; } // Stock Keeping Unit code for the product

    // Add any other relevant properties as needed
}
