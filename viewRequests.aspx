<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewRequests.aspx.cs" Inherits="viewRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
    </form>
</body>
</html>
