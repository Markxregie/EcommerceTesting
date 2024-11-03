namespace EcommerceApp
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public decimal CalculateDiscount(decimal percentage)
        {
            return Price * (percentage / 100);
        }

        public decimal CalculateTax(decimal taxRate)
        {
            return Price * (taxRate / 100);
        }
    }
}
