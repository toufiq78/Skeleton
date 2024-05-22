using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();

            Assert.IsNotNull(AnOrder );
        }
        [TestMethod]
        public void StatusPropertyOk() 
        {
        clsOrder AnOrder =new clsOrder();

        Boolean TestData = true;

            AnOrder.Status = TestData;

            Assert.AreEqual(AnOrder.Status, TestData);
        }
        [TestMethod]
        public void DatePropertyOk() 
        { 
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.Date = TestData;

            Assert.AreEqual(AnOrder.Date, TestData);
        }
        [TestMethod]
        public void OrderIdPropertyOk() 
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.OrderId = TestData;

            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        [TestMethod]
        public void OrderNamePropertyOk()
        {
            clsOrder AnOrder = new clsOrder();

            string TestData = "shirt";

            AnOrder.OrderName = TestData;

            Assert.AreEqual(AnOrder.OrderName, TestData);
        }
        [TestMethod]
        public void PricePropertyOk() 
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.Price = TestData;

            Assert.AreEqual(AnOrder.Price, TestData);
        }
        [TestMethod]
        public void OrderQuantityPropertyOk() 
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.OrderQuantity = TestData;

            Assert.AreEqual(AnOrder.OrderQuantity, TestData);
        }
        [TestMethod]
        public void PaymentMethodPropertyOk() 
        {
            clsOrder AnOrder = new clsOrder();

            string TestData = "cash";

            AnOrder.PaymentMethod = TestData;

            Assert.AreEqual(AnOrder.PaymentMethod, TestData);
        }

    }
}
