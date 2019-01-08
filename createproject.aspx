<%@ Page Language="C#" AutoEventWireup="true" CodeFile="createproject.aspx.cs" Inherits="createproject" %>

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
        <asp:Label ID="Label1" runat="server" Text="Project name: "></asp:Label>
        <asp:TextBox ID="projectname" runat="server"></asp:TextBox>

        <br />
        <br />
        <asp:Button ID="startdate" runat="server" Text="Start Date" OnClick="startdate_Click" />

        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" ></asp:Calendar>

        <br />

        <asp:Button ID="enddate" runat="server" Text="End Date" OnClick="enddate_Click" />
        <br />
        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>

        <br />
        <asp:Button ID="create" runat="server" Text="Create Project" OnClick="create_Click" />
        <br />

    </form>
</body>
</html>
