using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class viewTop3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        done.Visible = false;
    }

    protected void go_Click(object sender, EventArgs e)
    {
        string s = Session["Username"].ToString();
        done.Visible = true;
        Response.Write("Success");
        GridView1.Visible = true;
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("view_three_achievers", conn);
        cmd.Parameters.AddWithValue("@username", s);
        cmd.Parameters.AddWithValue("@month", TextBox1.Text);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        Response.Write("Success");


    }

    protected void done_Click(object sender, EventArgs e)
    {
        Response.Redirect("HR-homepage");
    }
}