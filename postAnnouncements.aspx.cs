
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class postAnnouncements : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void post_Click(object sender, EventArgs e)
    {
        string hr = Session["Username"].ToString();
        string t = title.Text.ToString();
        string desc = des.Text.ToString();
        string ty = type.Text.ToString();
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("postAnnouncements", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@title", t);
        cmd.Parameters.AddWithValue("@description", desc);
        cmd.Parameters.AddWithValue("@type", ty);
        cmd.Parameters.AddWithValue("@hr_username", hr);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("HR_homepage.aspx");
        Response.Write("Success");


    }
}
