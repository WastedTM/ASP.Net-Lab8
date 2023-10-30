namespace lab8.Models;

public class Product
{
    public Product(int id, string name, double price, DateTime createDate)
    {
        Id = id;
        Name = name;
        Price = price;
        CreateDate = createDate;
    }

    public int Id { set; get; }
    public string Name { set; get; }
    public double Price { set; get; }
    public DateTime CreateDate { set; get; }
    
    
}