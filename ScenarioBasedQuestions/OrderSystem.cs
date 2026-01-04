using System.Collections.Generic;

// Question 8: Composition – Order and Product Relationship
// Explain and design Order and Product classes using composition instead of inheritance.
// Part - 2
public class OrderSystem
{
    public string OrderID{get; set;}
    public List<OrderAndProductRelationship> ProductAdd;

    public OrderSystem()
    {
        
    }
    public OrderSystem(string OrderID)
    {
        this.OrderID = OrderID;
        ProductAdd = new List<OrderAndProductRelationship>();
    }

    public void AddProduct(OrderAndProductRelationship product)
    {
        ProductAdd.Add(product);
    }
    public double PriceCalculation()
    {
        double total = 0;
        foreach(var products in ProductAdd)
        {
            total += products.ProductPrice;
        }
        return total;
    }
}