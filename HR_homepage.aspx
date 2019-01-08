<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HR_homepage.aspx.cs" Inherits="HR_homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome!</div>
        <p>
            Please choose one of the following actions:</p>
        <asp:Button ID="newJob" runat="server" OnClick="newJob_Click" Text="Add A New Job" Width="236px" />
        <p>
            <asp:Button ID="viewJob" runat="server" OnClick="viewJob_Click" Text="View and Edit Jobs" Width="238px" />
        </p>
        <p>
            <asp:Button ID="viewApp" runat="server" OnClick="viewApp_Click" Text="View Applications" Width="239px" />
        </p>
        <p>
            <asp:Button ID="postAnn" runat="server" OnClick="postAnn_Click" Text="Post Announcements" Width="240px" />
        </p>
        <p>
            <asp:Button ID="viewReq" runat="server" OnClick="viewReq_Click" Text="View Requests" Width="241px" />
        </p>
        <p>
            <asp:Button ID="viewAtt" runat="server" OnClick="viewAtt_Click" Text ="View Attendance" Width="242px" />
        </p>
        <asp:Button ID="viewHours" runat="server" OnClick="viewHours_Click"  Text="View Hours of Staff Member" Width="241px" />
        <p>
            <asp:Button ID="viewTop" runat="server" OnClick="viewTop_Click" Text="View Top 3 Members" Width="242px" />
        </p>
    </form>
</body>
</html>

