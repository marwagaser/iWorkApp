<%@ Page Language="C#" AutoEventWireup="true" CodeFile="postAnnouncements.aspx.cs" Inherits="postAnnouncements" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please fill in the following details of the announcement:</div>
        <p>
            Title:
            <asp:TextBox ID="title" runat="server"></asp:TextBox>
        </p>
        <p>
            Description:
            <asp:TextBox ID="des" runat="server"></asp:TextBox>
        </p>
        <p>
            Type:
            <asp:TextBox ID="type" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="post" runat="server" Text="Post" OnClick="post_Click" />
        </p>
    </form>
</body>
</html>
