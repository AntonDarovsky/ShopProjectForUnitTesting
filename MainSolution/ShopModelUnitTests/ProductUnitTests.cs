using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Core.Discounts;

namespace ShopModelUnitTests
{
    [TestClass]
    public class ProductUnitTests
    {
        [TestMethod]

        public void ToStringChecker()
        {
            Product product = new Product();
           string actualResult = product.ToString();
            Assert.AreEqual("".GetType(), actualResult.GetType());
        }

        [TestMethod]

        public void FirstEqualsCheckerPositive()
        {
           Product product1 = new Product { ProductID = 1, Name = "Lays", Price = 20 };
            Product product2 = new Product { ProductID = 1, Name = "Lays", Price = 20 };

            bool actualResult = product1.Equals(product2);
            Assert.IsTrue(actualResult);
        }

        [TestMethod]

        public void FirstEqualsCheckerNegative()
        {
            Product product1 = new Product { ProductID = 1, Name = "Lays", Price = 20 };
            Product product2 = new Product { ProductID = 2, Name = "Lays", Price = 40 };

            bool actualResult = product1.Equals(product2);
            Assert.IsFalse(actualResult);
        }

        [TestMethod]

        public void GetHashCodeChecker()
        {
            
            Product product1 = new Product { ProductID = 1, Name = "Lays", Price = 20 };
            Product product2 = new Product { ProductID = 1, Name = "Lays", Price = 20 };

            var actualResult = product1.GetHashCode();

            Assert.AreEqual(product2.GetHashCode() , actualResult);

        }


    }
}
