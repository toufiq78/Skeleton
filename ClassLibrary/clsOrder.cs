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

        public string Valid(string ordername, string Date, string price, string orderquantity, string paymentmethod)
        {
            String Error = "";
            DateTime DateTemp;
            if (ordername.Length == 0)
            {
                Error = Error + "The order name may not be blank : ";
            }
            if (ordername.Length > 6) 
            {
                Error = Error + "The order name must be less then 6 charecter : ";
            }
            if (price.Length == 0)
            {
                Error = Error + "The price may not be blank : ";
            }
            if (price.Length > 6)
            {
                Error = Error + "The price must be less then 6 charecter : ";
            }
            if (orderquantity.Length == 0)
            {
                Error = Error + "The order quantity may not be blank : ";
            }
            if (orderquantity.Length > 6)
            {
                Error = Error + "The order quantity must be less then 6 charecter : ";
            }
            if (paymentmethod.Length == 0)
            {
                Error = Error + "The payment method may not be blank : ";
            }
            if (paymentmethod.Length > 6)
            {
                Error = Error + "The payment method must be less then 6 charecter : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date can not be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date can not be in the future : ";
                }
            }
            catch 
            {
                Error = Error + "The date was not a valid date : ";
            }
            return Error;
        }
    }
}