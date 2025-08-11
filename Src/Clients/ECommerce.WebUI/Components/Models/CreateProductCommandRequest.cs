namespace ECommerce.WebUI.Components.Models;

public class CreateProductCommandRequest
{
    public string Name { get; set; } = string.Empty;
    public int Stock { get; set; }
    public decimal Price { get; set; }
}
