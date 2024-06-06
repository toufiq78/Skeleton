<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 291px; top: 341px; position: absolute" Text="Yes" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 444px; top: 341px; position: absolute" Text="No" />
        <p>
            <asp:Label ID="lbl" runat="server" style="z-index: 1; left: 274px; top: 271px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </p>
    </form>
</body>
</html>
