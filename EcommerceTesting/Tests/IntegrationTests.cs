using NUnit.Framework;

namespace EcommerceTesting.Tests
{
    [TestFixture]
    public class IntegrationTests
    {
        [Test]
        public void AddProductToCart_ShouldStoreProductInformation()
        {
            // Arrange
            var cart = new EcommerceApp.ShoppingCart();
            var product = new EcommerceApp.Product
            {
                Name = "Test Product",
                Price = 100,
                Description = "A product for integration testing"
            };

            // Act
            cart.AddProduct(product);

            // Assert
            Assert.That(cart.Products.Count, Is.EqualTo(1));
            Assert.That(cart.Products[0].Name, Is.EqualTo("Test Product"));
            Assert.That(cart.Products[0].Price, Is.EqualTo(100));
        }

        [Test]
        public void CalculateTotalPrice_WithDiscount_ShouldCalculateCorrectly()
        {
            // Arrange
            var cart = new EcommerceApp.ShoppingCart();
            var product1 = new EcommerceApp.Product { Price = 100 };
            var product2 = new EcommerceApp.Product { Price = 200 };
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            // Act
            var totalBeforeDiscount = cart.CalculateTotalPrice();
            var totalAfterDiscount = cart.ApplyDiscount(10); // Apply a 10% discount

            // Assert
            Assert.That(totalBeforeDiscount, Is.EqualTo(300));
            Assert.That(totalAfterDiscount, Is.EqualTo(270)); // 10% off of 300
        }

        [Test]
        public void RemoveProductFromCart_ShouldReduceProductCount()
        {
            // Arrange
            var cart = new EcommerceApp.ShoppingCart();
            var product = new EcommerceApp.Product { Name = "Test Product", Price = 100 };
            cart.AddProduct(product);

            // Act
            cart.RemoveProduct(product);

            // Assert
            Assert.That(cart.Products.Count, Is.EqualTo(0));
        }
    }
}
