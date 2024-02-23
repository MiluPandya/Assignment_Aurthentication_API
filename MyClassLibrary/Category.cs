public class Category
{
    public int Id { get; set; }
    public string Description { get; set; }
}

// Add Category property to Product model
public class Product
{
    // other properties
    public Category Category { get; set; }
}
