using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void FindMethod()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestDateFound()
        {
            clsOrder AnOrder =new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderId = 1;
            Found = AnOrder .Find(OrderId);
            if(AnOrder.Date != Convert.ToDateTime("12/12/2009"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestOrderNameFound()
            {
                clsOrder AnOrder = new clsOrder();
                Boolean Found = false;
                Boolean Ok = true;
                Int32 OrderId = 1;
                Found = AnOrder.Find(OrderId);
                if (AnOrder.OrderName != "Shoes")
                {
                    Ok = false;
                }
                Assert.IsTrue(Ok);
            }
            [TestMethod]
            public void TestOrderQuantityFound()
            {
                clsOrder AnOrder = new clsOrder();
                Boolean Found = false;
                Boolean Ok = true;
                Int32 OrderId = 1;
                Found = AnOrder.Find(OrderId);
                if (AnOrder.OrderQuantity != 1)
                {
                    Ok = false;
                }
                Assert.IsTrue(Ok);
            }
        [TestMethod]
        public void TestPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean Ok = true;
            Int32 OrderId = 1;
            found = AnOrder.Find(OrderId);
            if (AnOrder.Price != 40)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestPymentMethodFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean Ok = true;
            Int32 OrderId = 1;
            found = AnOrder.Find(OrderId);
            if (AnOrder.PaymentMethod != "card")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean found = false;
            Boolean Ok = true;
            Int32 OrderId = 1;
            found = AnOrder.Find(OrderId);
            if (AnOrder.Status != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
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
