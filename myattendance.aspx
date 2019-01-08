<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myattendance.aspx.cs" Inherits="myattendance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="from:"></asp:Label>
        <asp:TextBox ID="start_date" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="to:"></asp:Label>
        <asp:TextBox ID="end_date" runat="server" OnTextChanged="end_date_TextChanged"></asp:TextBox>
        &nbsp;
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="go" />
             <br />
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
             <br />
             <br />
             <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                 <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                 <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                 <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F7F7F7" />
                 <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                 <SortedDescendingCellStyle BackColor="#E5E5E5" />
                 <SortedDescendingHeaderStyle BackColor="#242121" />
             </asp:GridView>
             <br />
        </div>
       
    </form>
</body>
</html>
