using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderList : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {

        clsOrderCollection Order = new clsOrderCollection();
        lstOrderbox.DataSource = Order.OrderList;
        lstOrderbox.DataValueField = "OrderId";
        lstOrderbox.DataTextField = "OrderName";
        lstOrderbox.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        
        if (lstOrderbox.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderbox.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit"; 
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderbox.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderbox.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}