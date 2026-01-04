// Question 8: Composition – Order and Product Relationship
// Explain and design Order and Product classes using composition instead of inheritance.
// Part - 1
public class OrderAndProductRelationship
{
    public string ProductId{get; set;}
    public string ProductName{get; set;}
    public double ProductPrice{get; set;}

    public OrderAndProductRelationship(){}
    public OrderAndProductRelationship(string ProductId, string ProductName,double ProductPrice)
    {
        this.ProductId = ProductId;
        this.ProductName = ProductName;
        this.ProductPrice = ProductPrice;
    }
}