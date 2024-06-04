using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        { 
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder =new clsOrder();
                AnOrder.Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.OrderQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderQuantity"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                mOrderlist.Add( AnOrder );
                Index++;
            }
            clsOrder TestItem = new clsOrder();
            TestItem.Status = true;
            TestItem.OrderId = 1;
            TestItem.OrderName = "Shoes";
            TestItem.Price = 40;
            TestItem.Date = DateTime.Now.Date;
            TestItem.OrderQuantity = 1;
            TestItem.PaymentMethod = "card";
            mOrderlist.Add(TestItem);
            TestItem = new clsOrder();
            TestItem.Status = false;
            TestItem.OrderId = 2;
            TestItem.OrderName = "pant";
            TestItem.Price = 26;
            TestItem.Date = DateTime.Now.Date;
            TestItem.OrderQuantity = 3;
            TestItem.PaymentMethod = "cash";
            mOrderlist.Add(TestItem);
        }

        private void Execute(string v)
        {
            throw new NotImplementedException();
        }

        List<clsOrder> mOrderlist = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderlist;
            }
            set
            {
                mOrderlist = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderlist.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@OrderQuantity", mThisOrder.OrderQuantity);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@Status", mThisOrder.Status);
            return DB.Execute("sproc_tblOrder_Insert");
        }
        
    }
}