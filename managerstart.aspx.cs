using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class managerstart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);


    }

    protected void viewreq_Click(object sender, EventArgs e)
    {
        Response.Redirect("newreq.aspx");
    }

    protected void createProject_Click(object sender, EventArgs e)
    {
        Response.Redirect("createproject.aspx");
    }

    protected void jobapplication_Click(object sender, EventArgs e)
    {
        Response.Redirect("jobapplications.aspx");
    }



    protected void projects_Click(object sender, EventArgs e)
    {
        Response.Redirect("depprojects.aspx");
    }
}