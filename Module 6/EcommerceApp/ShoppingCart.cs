using System.Collections.Generic;

namespace EcommerceApp
{
    public class ShoppingCart
    {
        private List<Product> _products = new List<Product>();
        public IReadOnlyList<Product> Products => _products.AsReadOnly();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.Price;
            }
            return total;
        }

        public decimal ApplyDiscount(decimal discountPercentage)
        {
            decimal discountAmount = CalculateTotalPrice() * (discountPercentage / 100);
            return CalculateTotalPrice() - discountAmount;
        }
    }
}
