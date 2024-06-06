using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.NetworkInformation;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        string OrderName = "Audi";
        string Date = DateTime.Now.ToShortDateString();
        string Price = "2600";
        string OrderQuantity = "2";
        string PaymentMethod = "card";
        [TestMethod]
        public void FindMethod()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 7;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderId = 7;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Date != Convert.ToDateTime("06/06/2024"))
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
            Int32 OrderId = 7;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 7)
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
                Int32 OrderId = 7;
                Found = AnOrder.Find(OrderId);
                if (AnOrder.OrderName != "Lambo")
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
                Int32 OrderId = 7;
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
            Int32 OrderId = 7;
            found = AnOrder.Find(OrderId);
            if (AnOrder.Price != 25600)
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
            Int32 OrderId = 7;
            found = AnOrder.Find(OrderId);
            if (AnOrder.PaymentMethod != "cash")
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
            Int32 OrderId = 7;
            found = AnOrder.Find(OrderId);
            if (AnOrder.Status != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        
        [TestMethod]
        public void ValidMethodOk() 
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "a";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "aa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "aaaaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "aaaaaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "aaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderNameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderName = "aaaaaaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameExtremeMax()
            {
                clsOrder AnOrder = new clsOrder();
                String Error = "";
                string OrderName = "";
                OrderName = OrderName.PadRight(500, 'a');
                Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
                Assert.AreNotEqual(Error, "");
            }
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "1";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "11";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "11111";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "111111";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "111";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "1111111";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Price = "";
            OrderName = OrderName.PadRight(500, '1');
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void OrderQuantityMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderQuantityMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "2";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQuantityMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "22";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQuantityMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "22222";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQuantityMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "222222";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQuantityMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "222";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQuantityMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "2222222";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderQuantityExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string OrderQuantity = "";
            OrderName = OrderName.PadRight(500, '2');
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "a";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "aa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "aaaaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "aaaaaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "aaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "aaaaaaa";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string PaymentMethod = "";
            OrderName = OrderName.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(100);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string Date = "This is not a date!";
            Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
            Assert.AreNotEqual(Error, "");
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
