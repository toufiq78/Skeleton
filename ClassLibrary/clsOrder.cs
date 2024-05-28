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

        public bool Find(int orderId)
        {
            mOrderId = 1;
            mOrderName = "Shoes";
            mPrice = 40;
            mDate =Convert.ToDateTime("12/12/2009");
            mPaymentMethod = "card";
            mOrderQuantity = 1;
            mStatus = true;
            return true;
        }
    }
}