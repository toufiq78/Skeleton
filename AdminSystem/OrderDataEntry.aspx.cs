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
    

}