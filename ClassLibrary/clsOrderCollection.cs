using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsOrderCollection
    {
        public clsOrderCollection()
        { 
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
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
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@OrderQuantity", mThisOrder.OrderQuantity);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.Execute("sproc_tblOrder_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.Execute("sproc_tblOrder_Delete");
        }
        public void ReportByOrderName(string orderName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderName", orderName);
            DB.Execute("sproc_tblOrder_FilterByOrderName");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderlist = new List<clsOrder>();
            while (Index<RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                AnOrder.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.OrderQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderQuantity"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                mOrderlist.Add(AnOrder);
                Index++;
            }
        }
    }
}