using NUnit.Framework;

namespace EcommerceTesting.Tests
{
    [TestFixture]
    public class ShoppingCartTests
    {
        [Test]
        public void AddAndRemoveProduct()
        {
            // Arrange
            var cart = new EcommerceApp.ShoppingCart();
            var product = new EcommerceApp.Product { Name = "Test Product", Price = 100 };

            // Act
            cart.AddProduct(product);
            var initialCount = cart.Products.Count;
            cart.RemoveProduct(product);
            var finalCount = cart.Products.Count;

            // Assert
            Assert.That(initialCount, Is.EqualTo(1));
            Assert.That(finalCount, Is.EqualTo(0));
        }

        [Test]
        public void CalculateTotalPrice()
        {
            // Arrange
            var cart = new EcommerceApp.ShoppingCart();
            var product1 = new EcommerceApp.Product { Price = 100 };
            var product2 = new EcommerceApp.Product { Price = 200 };
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            // Act
            var total = cart.CalculateTotalPrice();

            // Assert
            Assert.That(total, Is.EqualTo(300));
        }

        [Test]
        public void ApplyDiscount()
        {
            // Arrange
            var cart = new EcommerceApp.ShoppingCart();
            var product = new EcommerceApp.Product { Price = 100 };
            cart.AddProduct(product);

            // Act
            var totalAfterDiscount = cart.ApplyDiscount(10); // 10% discount

            // Assert
            Assert.That(totalAfterDiscount, Is.EqualTo(90));
        }
    }
}
