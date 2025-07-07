namespace ECommerce.Application.ViewModels.Products;

public class VM_Create_Product
{
    public string Name { get; set; } = string.Empty;
    public int Stock { get; set; }
    public float Price { get; set; }
}