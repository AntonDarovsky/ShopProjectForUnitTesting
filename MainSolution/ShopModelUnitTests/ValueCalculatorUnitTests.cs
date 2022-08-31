using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace ShopModelUnitTests
{
    [TestClass]
    public class ValueCalculatorUnitTests
    {
        [TestMethod]


        public void ValueCalculatorCheckerPositive()
        {
            ValueCalculator calculator = new ValueCalculator();

            Product [] products =
           {
                new Product {ProductID = 1, Name = "Lays", Price = 20},
                new Product {ProductID = 2, Name = "Pringles", Price = 40}
            };

            decimal actualResult = calculator.ValueCalc(products);

            Assert.AreEqual(60, actualResult, "Wrong sum of the products");
        }
        
        [TestMethod]


        public void ValueCalculatorCheckerNegative()
        {
            ValueCalculator calculator = new ValueCalculator();

            Product[] products =
           {
                new Product {ProductID = 1, Name = "Lays", Price = 20},
                new Product {ProductID = 2, Name = "Pringles", Price = 40}
            };

            decimal actualResult = calculator.ValueCalc(products);

            Assert.AreNotEqual(80, actualResult, "Right sum of the products");
        }
    }
}
