using NUnit.Framework;

namespace EcommerceTesting.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void SetGetProductAttributes()
        {
            // Arrange
            var product = new EcommerceApp.Product();
            product.Name = "Test Product";
            product.Price = 100;
            product.Description = "Test Description";

            // Act & Assert
            Assert.That(product.Name, Is.EqualTo("Test Product"));
            Assert.That(product.Price, Is.EqualTo(100));
            Assert.That(product.Description, Is.EqualTo("Test Description"));
        }

        [Test]
        public void CalculateDiscount()
        {
            // Arrange
            var product = new EcommerceApp.Product { Price = 100 };

            // Act
            var discount = product.CalculateDiscount(10);

            // Assert
            Assert.That(discount, Is.EqualTo(10));
        }

        [Test]
        public void CalculateTax()
        {
            // Arrange
            var product = new EcommerceApp.Product { Price = 100 };

            // Act
            var tax = product.CalculateTax(5);

            // Assert
            Assert.That(tax, Is.EqualTo(5));
        }
    }
}
