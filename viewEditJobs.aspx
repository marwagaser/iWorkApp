<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewEditJobs.aspx.cs" Inherits="viewEditJobs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please choose job you want changed:<br />
            <br />
            Job Title:
            <asp:TextBox ID="oldJobTitle" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="enter" runat="server" OnClick="enter_Click" Text="Enter" />
        </div>
        <p>
            &nbsp;<asp:Label ID="title1" runat="server" Text="Job Title: "></asp:Label>
            <asp:TextBox ID="jt" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Short" runat="server" Text="Short Description: "></asp:Label>
            <asp:TextBox ID="nsd" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Detailed" runat="server" Text="Detailed Description: "></asp:Label>
            <asp:TextBox ID="ndd" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="mini" runat="server" Text="Minimum Experience: "></asp:Label>
            <asp:TextBox ID="minEx" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="sal" runat="server" Text="Salary: "></asp:Label>
            <asp:TextBox ID="salary" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="dead" runat="server" Text="Deadline: "></asp:Label>
            <asp:TextBox ID="deadline" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="num" runat="server" Text="Number of Vacancies: "></asp:Label>
            <asp:TextBox ID="numvac" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="whrs" runat="server" Text="Working Hours: "></asp:Label>
            <asp:TextBox ID="wh" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="submit" runat="server" Text="Submit" OnClick="submit_Click" />
    </form>
</body>
</html>
