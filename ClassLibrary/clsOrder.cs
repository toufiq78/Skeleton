using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderId;
        private DateTime mDate;
        private bool mStatus;
        private string mOrderName;
        private Int32 mOrderQuantity;
        private Int32 mPrice;
        private string mPaymentMethod;


        public bool Status
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }
        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        public string OrderName
        {
            get
            {
                return mOrderName;
            }
            set
            {
                mOrderName = value;
            }
        }

        public Int32 Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public int OrderQuantity
        {
            get
            {
                return mOrderQuantity;
            }
            set
            {
                mOrderQuantity = value;
            }
        }
        public string PaymentMethod
        {
            get
            {
                return mPaymentMethod;
            }
            set
            {
                mPaymentMethod = value;
            }
        }

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMethod"]);
                mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["OrderQuantity"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}