<%@ Page Language="C#" AutoEventWireup="true" CodeFile="depprojects.aspx.cs" Inherits="depprojects" %>

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
        <asp:Label runat="server" Font-Names="Script MT Bold" Font-Size="Larger" Text="Department Projects"></asp:Label>
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" OnRowCommand="Row_Command" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField= "project_name" HeaderText="Project Name" />
                <asp:BoundField DataField="start_date" HeaderText="start date" />
                <asp:BoundField DataField="end_date" HeaderText="end date" />
                <asp:ButtonField ButtonType="Button" Text="view task list" CommandName="tasklist" />
                <asp:ButtonField ButtonType="Button" Text="Manage Employees" CommandName="manageemp" />
                <asp:ButtonField ButtonType="Button" Text="Create Task" CommandName="newtask" />
                <asp:ButtonField ButtonType="Button" CommandName="ret" Text="Replace Employee on task" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
