
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewJob.aspx.cs" Inherits="AddNewJob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Select1 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add A New Job:</div>
        <p>
            Please fill in the following details:</p>
        Job Title:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;<p>
        Short Description:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
    <p>
        Detailed Description:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
    <p>
        Minimum Experience:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
    <p>
        Salary:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
    <p>
        Deadline:
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
    <p>
        Number Of Vacancies:
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        </p>
    <p>
        Working Hours:
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
        </p>
        <p>
            &nbsp;</p>
    <p>
        <asp:Label ID="q" runat="server" Text="Add Question"></asp:Label>
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="a" runat="server" Text="Add Answer"></asp:Label>
&nbsp;<asp:TextBox ID="answer" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="addQ" runat="server" Text="Add Question" OnClick="addQ_Click" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Done" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>

    <p>
        &nbsp;</p>
</body>
</html>

