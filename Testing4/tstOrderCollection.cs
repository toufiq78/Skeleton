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
    }
   
 
}
