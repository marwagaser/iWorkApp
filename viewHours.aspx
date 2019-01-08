<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewHours.aspx.cs" Inherits="viewHours" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Please enter the following details:</p>
        <p>
            Employee username:<asp:TextBox ID="un" runat="server"></asp:TextBox>
        </p>
        <p>
            Enter year:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="year" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="go" runat="server" Text="Go" OnClick="go_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
