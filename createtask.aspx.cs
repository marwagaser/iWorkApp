using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class createtask : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        pn.Text = Session["projectname"].ToString();
    }



    protected void deadline_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DateTime dline = Calendar1.SelectedDate;
        Session["dl"] = dline;
        Calendar1.Visible = false;
    }



    protected void ct_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("create_task", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@project", Session["projectname"].ToString());
        cmd.Parameters.AddWithValue("@description", tdes.Text);
        cmd.Parameters.AddWithValue("@deadline", (DateTime)Session["dl"]);
        cmd.Parameters.AddWithValue("@regular", emp.Text);
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();

        cmd.ExecuteNonQuery();
        if (flag.Value.ToString().Equals("1"))
        {
            l.Visible = true;
            l.Text= "Employee not assigned to the project";
        }
        else

        {
            l.Visible = true;
            l.Text= "Done";
        }
        conn.Close();
    }
}