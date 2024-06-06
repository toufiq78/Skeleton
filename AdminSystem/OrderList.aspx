<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderbox" runat="server" Height="554px" Width="884px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 128px; top: 575px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 206px; top: 573px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 130px; top: 617px; position: absolute; right: 1324px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 278px; top: 574px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
