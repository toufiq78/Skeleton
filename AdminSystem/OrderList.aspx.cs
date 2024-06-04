using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == true)
        {
            DisplayOrder();
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();
        lstOrderList.DataSource = Order.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderName";
        lstOrderList.DataBind();
    }
}