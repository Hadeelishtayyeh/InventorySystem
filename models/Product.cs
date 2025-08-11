namespace InventorySystem.models{

public class Product {

  public string name { git; set;}
public decimal price{ git; set;}
public int quantity { git; set;}

public Product (string Name ,decimal Price ,int Quantity )
{
Name = name;
Price = price;
Quantity = quantity;


}

 public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
        }
}


}