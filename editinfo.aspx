<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editinfo.aspx.cs" Inherits="editinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label2" runat="server" Text="New password: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="txt_newpass" runat="server" Height="20px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="New E-mail: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="txt_newemail" runat="server" Height="16px" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Years of experience: "></asp:Label>
    &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_newexp" runat="server" Height="20px" Width="234px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="D.O.B: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_dob" runat="server" Height="16px" Width="238px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="First Name: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txt_fn" runat="server" Height="19px" Width="239px"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Middle Name: "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_mn" runat="server" Height="16px" Width="241px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Last Name: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_ln" runat="server" Height="24px" Width="248px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="BACK" />
    </form>
</body>
</html>
