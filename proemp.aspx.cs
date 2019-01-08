using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class proemp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





    protected void aeb_Click(object sender, EventArgs e)
    {
        ae.Visible = true;
        goa.Visible = true;
      
    }

    protected void reb_Click(object sender, EventArgs e)
    {
        re.Visible = true;
        gor.Visible = true;
    }

    protected void goa_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("assign_project", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@project", Session["projectname"].ToString());
        cmd.Parameters.AddWithValue("@regular", ae.Text);
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();
        cmd.ExecuteNonQuery();
        if (flag.Value.ToString().Equals("1"))
        {
            ael.Visible = true;
            ael.Text = "Employee not in the same department";
        }
        else
        {
            if (flag.Value.ToString().Equals("2"))
            {
                ael.Visible = true;

                ael.Text = "Employee assigned to two projects";

            }
            else
            {
                ael.Visible = true;

                ael.Text = "Done";

            }
        }
        conn.Close();
    }

    protected void gor_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("remove_from_project", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@regular", re.Text);
        cmd.Parameters.AddWithValue("@project", Session["projectname"].ToString());
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();
        cmd.ExecuteNonQuery();
        if (flag.Value.ToString().Equals("1"))
        {
            rel.Visible = true;
            rel.Text = "Employee has tasks in project";
        }
        else
        {
            rel.Visible = true;
            rel.Text = "Done";


        }
        conn.Close();

    }
}