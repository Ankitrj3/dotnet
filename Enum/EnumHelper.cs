namespace Enum1
{
    public enum WeekDays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thrusday,
        Friday,
        Saturday
    }
    public enum ProductCategory
    {
        Electronics = 1,
        Groceries = 2,
        Clothing = 3,
        Furniture = 4
    }
    public class EnumHelper
    {
        public string GetWeekDays(WeekDays weekDays)
        {
            return weekDays.ToString();
        }
        public string ProductCategory(ProductCategory productCategory)
        {
            return productCategory.ToString();
        }
    }
}