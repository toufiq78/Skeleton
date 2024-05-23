<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin-bottom: 292px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 614px; top: 55px; position: absolute; width: 93px"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 477px; top: 55px; position: absolute" Text="Order Id"></asp:Label>
            <asp:TextBox ID="txtOrderName" runat="server" style="z-index: 1; left: 615px; top: 103px; position: absolute; width: 93px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderName" runat="server" style="z-index: 1; left: 477px; position: absolute; top: 101px; " Text="OrderName" width="54px"></asp:Label>
        <asp:Label ID="lblOrderQuantity" runat="server" style="z-index: 1; left: 479px; top: 141px; position: absolute" Text="Order Quantity" width="54px"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 477px; top: 191px; position: absolute" Text="Price" width="54px"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 477px; top: 227px; position: absolute" Text="Date" width="54px"></asp:Label>
        <asp:Label ID="lblPaymentMethod" runat="server" style="z-index: 1; left: 477px; top: 272px; position: absolute" Text="Payment Method" width="54px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 615px; top: 191px; position: absolute; width: 93px"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 616px; top: 230px; position: absolute; width: 93px"></asp:TextBox>
        <asp:TextBox ID="txtOrderQuantity" runat="server" style="z-index: 1; left: 615px; top: 149px; position: absolute; width: 93px"></asp:TextBox>
        <asp:TextBox ID="txtPaymentMethod" runat="server" style="z-index: 1; left: 618px; top: 279px; position: absolute; width: 93px"></asp:TextBox>
        <asp:CheckBox ID="chkStatus" runat="server" style="z-index: 1; left: 600px; top: 339px; position: absolute" Text="Status" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 491px; top: 384px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 541px; top: 426px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 649px; top: 423px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
