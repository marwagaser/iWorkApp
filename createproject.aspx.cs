using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class createproject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        Calendar1.Visible = false;
        Calendar2.Visible = false;
        DateTime sd = DateTime.Today;
        DateTime ed = DateTime.Today;
    }



    protected void startdate_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
       

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DateTime sd = Calendar1.SelectedDate;
        Session["sd"] = sd;

        Calendar1.Visible = false;
        Response.Write("start date selected");
    }

    protected void enddate_Click(object sender, EventArgs e)
    {
        Calendar2.Visible = true;
    }

    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        DateTime ed = Calendar2.SelectedDate;
        Session["ed"] = ed;
        Calendar2.Visible = false;
        Response.Write("end date selected");
    }

    protected void create_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("create_project", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@project_name", projectname.Text);
        cmd.Parameters.AddWithValue("@start_date", (DateTime)Session["sd"]);
        cmd.Parameters.AddWithValue("@end_date",(DateTime) Session["ed"]);
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();
        cmd.ExecuteNonQuery();
        if (flag.Value.ToString().Equals("1"))
        {
            Response.Write("Project name already exists");
        }
        else
        {
            Response.Write("Done");
        }
        conn.Close();

       
        }
}