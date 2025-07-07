namespace ECommerce.Application.ViewModels.Products;

public class Vm_Update_Product
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int Stock { get; set; }
    public float Price { get; set; }

}