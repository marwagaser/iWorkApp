<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewAttendance.aspx.cs" Inherits="viewAttendance" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please fill in the following details to get the attendance:</div>
        <p>
            Staff Member Username:
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            Start Date:
            <asp:TextBox ID="TextBox2" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            End Date:
            <asp:TextBox ID="TextBox3" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Go" runat="server" Text="Go" OnClick="Go_Click" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
