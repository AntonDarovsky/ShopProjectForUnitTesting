using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Discounts;

namespace ShopModelUnitTests
{
 
    [TestClass]
 
   public class Discounts_1UnitTests
    {
        [TestMethod]

        public void Discount_1Checker()
        {
            Discount_1 discount = new Discount_1();

            decimal actualResult = discount.PercentageValue(50);

            Assert.AreEqual(49.5M, actualResult);
        }
    }
}
