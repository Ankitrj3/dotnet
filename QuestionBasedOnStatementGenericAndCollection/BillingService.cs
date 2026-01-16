namespace Bill
{
    public enum Category
    {
        Electronics,
        Food,
        Clothing
    }
    public class Item
    {
        public string ItemName{get; set;}
        public Category category{get; set;}
        public int Quantity{get; set;}
        public double price{get; set;}

        public Item()
        {

        }
    }
    public class BillingService
    {
        private IDictionary<Category, double> _taxRate = new Dictionary<Category, double>();
        public void AddTaxRate(Category category, double Taxrate)
        {
             if (!_taxRate.ContainsKey(category))
                {
                    _taxRate.Add(category,Taxrate);
                }
        }
        public void CalculateBill(IList<Item> items)
        {
            double total = 0;
            foreach(Item i in items)
            {
                if (!_taxRate.ContainsKey(i.category))
                {
                    throw new ArgumentException("No tax found for this category");
                }
                double tax = _taxRate[i.category];
                total += i.price * i.Quantity + (i.price * i.Quantity * tax)/100;
            }
            Console.WriteLine("Total bill "+total);
        }
    }
}