<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewTop3.aspx.cs" Inherits="viewTop3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter the month:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="go" runat="server" Text="Go" OnClick="go_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="done" runat="server" Text="Done" OnClick="done_Click" />
    </form>
</body>
</html>
