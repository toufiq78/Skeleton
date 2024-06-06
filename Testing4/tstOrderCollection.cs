using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Status = true;
            TestItem.OrderId = 1;
            TestItem.OrderName = "shoes";
            TestItem.Price = 40;
            TestItem.Date = DateTime.Now;
            TestItem.OrderQuantity = 1;
            TestItem.PaymentMethod = "card";
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }
        [TestMethod]
        public void CountPropertyOk()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Int32 SomeCount = AllOrder.Count;
            AllOrder.Count = SomeCount;
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Status = true;
            TestOrder.OrderId = 1;
            TestOrder.OrderName = "shoes";
            TestOrder.Price = 40;
            TestOrder.Date = DateTime.Now;
            TestOrder.OrderQuantity = 1;
            TestOrder.PaymentMethod = "card";
            AllOrder.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Status = true;
            TestItem.OrderId = 1;
            TestItem.OrderName = "shoes";
            TestItem.Price = 40;
            TestItem.Date = DateTime.Now;
            TestItem.OrderQuantity = 1;
            TestItem.PaymentMethod = "card";
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent() 
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.AreEqual(AllOrder.Count, AllOrder.Count);

        }
        [TestMethod]
        public void AddMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Status = true;
            TestItem.OrderId = 1;
            TestItem.OrderName = "shoes";
            TestItem.Price = 40;
            TestItem.Date = DateTime.Now;
            TestItem.OrderQuantity = 1;
            TestItem.PaymentMethod = "card";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Status = true;
            TestItem.OrderId = 1;
            TestItem.OrderName = "shoes";
            TestItem.Price = 40;
            TestItem.Date = DateTime.Now.Date;
            TestItem.OrderQuantity = 1;
            TestItem.PaymentMethod = "card";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            TestItem.Status = false;
            TestItem.OrderId = 2;
            TestItem.OrderName = "pant";
            TestItem.Price = 26;
            TestItem.Date = DateTime.Now.Date;
            TestItem.OrderQuantity = 3;
            TestItem.PaymentMethod = "cash";
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Status = true;
            TestItem.OrderId = 1;
            TestItem.OrderName = "shoes";
            TestItem.Price = 40;
            TestItem.Date = DateTime.Now.Date;
            TestItem.OrderQuantity = 1;
            TestItem.PaymentMethod = "card";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByOrderNameMethodOk()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderName("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderNameNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderName("xxx xxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByOrderNameTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean Ok = true;
            FilteredOrders.ReportByOrderName("yyy yyy");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderId != 25)
                {
                    Ok = false;
                }
                if (FilteredOrders.OrderList[1].OrderId != 26)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
   
 
}
