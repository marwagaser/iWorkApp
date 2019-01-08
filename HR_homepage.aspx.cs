using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class HR_homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
    }

    protected void newJob_Click(object sender, EventArgs e)

    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("AddNewJob.aspx", true);
    }
    protected void viewJob_Click(object sender, EventArgs e)
    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("viewEditJobs.aspx", true);
    }
    protected void viewApp_Click(object sender, EventArgs e)
    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("ViewApplications.aspx", true);
    }
    protected void postAnn_Click(object sender, EventArgs e)
    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("postAnnouncements.aspx", true);
    }
    protected void viewReq_Click(object sender, EventArgs e)
    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("viewRequests.aspx", true);
    }
    protected void viewAtt_Click(object sender, EventArgs e)
    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("viewAttendance.aspx", true);
    }
    protected void viewHours_Click(object sender, EventArgs e)
    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("viewHours.aspx", true);
    }
    protected void viewTop_Click(object sender, EventArgs e)
    {
        string hr = Session["username"].ToString();
        Session["Username"] = hr;
        Response.Redirect("viewTop3.aspx", true);
    }
}
