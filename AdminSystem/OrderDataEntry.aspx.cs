using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string Price = txtPrice.Text;
        string OrderId = txtOrderId.Text;
        string OrderName = txtOrderName.Text;
        string OrderQuantity = txtOrderQuantity.Text;
        string Date = txtDate.Text;
        string PaymentMethod = txtPaymentMethod.Text;
        string Status = chkStatus.Text;
        string Error = "";
        Error = AnOrder.Valid(OrderName, Date, Price, OrderQuantity, PaymentMethod);
        if (Error == "")
        {
            AnOrder.OrderId = Convert.ToInt32( OrderId); 
            AnOrder.OrderName = OrderName;
            AnOrder.Date = Convert.ToDateTime(Date);
            AnOrder.Price = Convert.ToInt32(Price);
            AnOrder.OrderQuantity = Convert.ToInt32(OrderQuantity);
            AnOrder.PaymentMethod = PaymentMethod;
            AnOrder.Status = chkStatus.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (Convert.ToInt32(OrderId) == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(Convert.ToInt32(OrderId));
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true) 
        {
            txtOrderName.Text = AnOrder.OrderName;
            txtPrice.Text = AnOrder.Price.ToString();
            txtDate.Text = AnOrder.Date.ToString();
            txtOrderQuantity.Text = AnOrder.OrderQuantity.ToString();
            txtPaymentMethod.Text = AnOrder.PaymentMethod;
            chkStatus.Checked = AnOrder.Status;

        }
    }
    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ThisOrder.Find(OrderId);
        txtOrderId.Text = Order.ThisOrder.OrderId.ToString();
        txtOrderName.Text = Order.ThisOrder.OrderName.ToString();
        txtPrice.Text = Order.ThisOrder.Price.ToString();
        txtDate.Text = Order.ThisOrder.Date.ToString();
        txtOrderQuantity.Text = Order.ThisOrder.OrderQuantity.ToString();
        txtPaymentMethod.Text = Order.ThisOrder.PaymentMethod.ToString();
        chkStatus.Checked = Order.ThisOrder.Status;
    }
}