<%@ Page Language="C#" AutoEventWireup="true" CodeFile="deleteRequest.aspx.cs" Inherits="deleteRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label2" runat="server" Text="Request ID: "></asp:Label>
            <asp:TextBox ID="txt_req" runat="server"></asp:TextBox>
        &nbsp;
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        </div>
    </form>
</body>
</html>
