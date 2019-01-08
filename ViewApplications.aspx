<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewApplications.aspx.cs" Inherits="ViewApplications" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Job Title:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Go" OnClick="Button1_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server"   OnRowCommand ="GridView1_RowCommand">
            <Columns>
                <asp:ButtonField CommandName="Accept" HeaderText="Status" ShowHeader="True" Text="Accept" 
                   />
            </Columns>
            <Columns>
                <asp:ButtonField CommandName="Reject" HeaderText="Status" ShowHeader="True" Text="Reject" 
                   />
            </Columns>
        </asp:GridView>
        <br />
    </form>
</body>
</html>
