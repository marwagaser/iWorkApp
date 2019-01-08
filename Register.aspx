<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please fill in the following details:</div>
        <p>
            Username:
            <asp:TextBox ID="username" runat="server" ></asp:TextBox>
        </p>
        <p>
            Password:
           <asp:TextBox ID="pass" Type ="password" runat="server" style="direction: ltr"></asp:TextBox>

        </p>
        <p>
            Personal Email:
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
        </p>
        <p>
            Years of Experience:
            <asp:TextBox ID="yoe" runat="server"></asp:TextBox>
        </p>
        <p>
            Date of Birth: <asp:TextBox ID="date" runat="server" Type ="datetime"></asp:TextBox>
  &nbsp; Please enter your birthday in the following manner: YYYY-MM-DD</p>
    <p>
        First Name:
        <asp:TextBox ID="fn" runat="server"></asp:TextBox>
        </p>
    <p>
        Middle Name:<asp:TextBox ID="mn" runat="server"></asp:TextBox>
        </p>
    <p>
        Last Name:<asp:TextBox ID="ln" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
    </form>
    </body>
</html>