<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
</body>
</html>
    <asp:TextBox ID="txtManufacturer" runat="server" style="z-index: 1; left: 152px; top: 94px; position: absolute"></asp:TextBox>
    <asp:Label ID="lblStockID" runat="server" style="z-index: 1; left: 33px; top: 43px; position: absolute; height: 27px" Text="Stock ID"></asp:Label>
    <asp:Label ID="lblManufacturerID" runat="server" style="z-index: 1; left: 5px; top: 97px; position: absolute" Text="Manufacturer" width="85px"></asp:Label>
    <asp:TextBox ID="txtStockID" runat="server" style="z-index: 1; left: 155px; top: 42px; position: absolute"></asp:TextBox>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Label ID="lblModel" runat="server" style="z-index: 1; left: 19px; top: 157px; position: absolute" Text="Model" width="85px"></asp:Label>
    <asp:TextBox ID="txtModel" runat="server" style="z-index: 1; left: 148px; top: 157px; position: absolute"></asp:TextBox>
    <p>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 20px; top: 207px; position: absolute; height: 27px" Text="Colour"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblCondition" runat="server" style="z-index: 1; left: 10px; top: 260px; position: absolute" Text="Condition" width="66px"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 23px; top: 315px; position: absolute; width: 66px" Text="Price"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 149px; top: 204px; position: absolute"></asp:TextBox>
    </p>
    <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 149px; top: 257px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 148px; top: 313px; position: absolute"></asp:TextBox>
    <p>
        &nbsp;</p>
    <p>
        <asp:CheckBox ID="IDchckActive" runat="server" style="z-index: 1; left: 168px; top: 368px; position: absolute" Text="Active" width="90px" />
    </p>
    <asp:Label ID="lblerror" runat="server" style="z-index: 1; left: 168px; top: 414px; position: absolute" Text="lblerror" width="90px"></asp:Label>
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; top: 460px; position: absolute; left: 35px" Text="OK" width="90px" />
    <p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 168px; top: 461px; position: absolute; margin-bottom: 0px" Text="Cancel" />
    </p>
    </form>

