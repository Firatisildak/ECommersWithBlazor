namespace ECommerce.WebUI.Components.Models;

public class GetAllProductsResponse
{
    public int TotalCount { get; set; }
    public List<Product> Products { get; set; } = new();
}
