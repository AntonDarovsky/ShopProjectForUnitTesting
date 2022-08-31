using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Discounts;
using System;

namespace ShopModelUnitTests
{

    [TestClass]

    public class Discounts_5UnitTests
    {
        [TestMethod]

        public void Discount_5Checker()
        {
            Discount_5 discount = new Discount_5();

            decimal actualResult = discount.PercentageValue(50);
           
            Assert.AreEqual(47.5M, actualResult, "Wrong discount!");

          

        }
    }
}
