<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jobapplications.aspx.cs" Inherits="jobapplications" %>

<!DOCTYPE html>
<style>body {
  background: url("b3.jpg");
}</style>
<header class="main-header" role="banner">
  <img src="an1.jpg" alt="Banner Image"/>
</header>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server" Text="Enter Job Title: " Font-Names="Script MT Bold" Font-Size="Larger"></asp:Label>
            <asp:TextBox ID="jobtitle" runat="server" OnTextChanged="jobtitle_TextChanged" Height="16px" Width="142px"></asp:TextBox>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                   <Columns>

        <asp:HyperLinkField DataTextField="application_no" DataNavigateUrlFields="application_no" DataNavigateUrlFormatString='appaor.aspx?application_no={0}'
            HeaderText="application_no" ItemStyle-Width = "150" />
 

            </Columns>
               
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
