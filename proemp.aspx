<%@ Page Language="C#" AutoEventWireup="true" CodeFile="proemp.aspx.cs" Inherits="proemp" %>

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
            <asp:Label ID="Label1" runat="server" Font-Names="Script MT Bold" Font-Size="XX-Large" Text="Project:  "></asp:Label>
            <asp:Label ID="pn" runat="server" Font-Italic="True" Font-Names="Script MT Bold" Font-Size="XX-Large" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="aeb" runat="server" BackColor="#4B7585" BorderStyle="None" Font-Names="Script MT Bold" Font-Size="Large" ForeColor="White" OnClick="aeb_Click" Text="Assign Employee" />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ae" runat="server" Visible="False" Width="122px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="goa" runat="server" BackColor="#8ACED7" BorderStyle="None" Font-Names="Script MT Bold" Font-Size="Medium" OnClick="goa_Click" Text="go" Visible="False" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ael" runat="server" Font-Names="Script MT Bold" Font-Size="Medium" Text="Label" Visible="False"></asp:Label>
        <p>
            <asp:Button ID="reb" runat="server" BackColor="#4B7585" BorderStyle="None" Font-Names="Script MT Bold" Font-Size="Large" ForeColor="White" OnClick="reb_Click" Text="Remove Employee" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="re" runat="server" Visible="False" Width="128px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="gor" runat="server" BackColor="#8ACED7" BorderStyle="None" Font-Names="Script MT Bold" Font-Size="Medium" OnClick="gor_Click" Text="go" Visible="False" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="rel" runat="server" Font-Names="Script MT Bold" Font-Size="Medium" Text="Label" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
