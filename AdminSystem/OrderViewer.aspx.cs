﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write(AnOrder.Price);
        Response.Write(AnOrder.OrderId);
        Response.Write(AnOrder.OrderName);
        Response.Write(AnOrder.OrderQuantity);
        Response.Write(AnOrder.Date);
        Response.Write(AnOrder.PaymentMethod);
        Response.Write(AnOrder.Status);
    }
}