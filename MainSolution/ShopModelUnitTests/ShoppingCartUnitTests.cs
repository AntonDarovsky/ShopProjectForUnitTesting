using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Core.Discounts;

namespace ShopModelUnitTests
{
    [TestClass]
    public class ShoppingCartUnitTests
    {
        [TestMethod]

        public void ShoppingCartCheckerPositive()
        {

            Discount_1 discount = new Discount_1();

            ValueCalculator calculator = new ValueCalculator();

            Product[] products =
           {
                new Product {ProductID = 1, Name = "Lays", Price = 20},
                new Product {ProductID = 2, Name = "Pringles", Price = 40}
            };

            ShoppingCart cart = new ShoppingCart(discount, calculator) { Products = products }; 

            decimal actualResult = cart.CalculateTotal();

            Assert.AreEqual(59.4M, actualResult);
            
        }

        [TestMethod]

        public void ShoppingCartCheckerNegative()
        {

            Discount_1 discount = new Discount_1();

            ValueCalculator calculator = new ValueCalculator();

            Product[] products =
           {
                new Product {ProductID = 1, Name = "Lays", Price = 20},
                new Product {ProductID = 2, Name = "Pringles", Price = 40}
            };

            ShoppingCart cart = new ShoppingCart(discount, calculator) { Products = products };

            decimal actualResult = cart.CalculateTotal();

            Assert.AreNotEqual(59.8M, actualResult);

        }
    }
}
