using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder.Price = Convert.ToInt32(txtPrice.Text);
        AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
        AnOrder.OrderName = (txtOrderName.Text);
        AnOrder.OrderQuantity = Convert.ToInt32(txtOrderQuantity.Text);
        AnOrder.Date = DateTime.Now;
        AnOrder.PaymentMethod = (txtPaymentMethod.Text);
        AnOrder.Status = chkStatus.Checked;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");

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
}