using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class repemptask : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("change_employee_on_task", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["username"].ToString());

        cmd.Parameters.AddWithValue("@regular", reg.Text);
        cmd.Parameters.AddWithValue("@replacement", rep.Text);
        cmd.Parameters.AddWithValue("@project", Session["projectname"].ToString());
        cmd.Parameters.AddWithValue("@task", tn.Text);

        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();
        cmd.ExecuteNonQuery();
        if (flag.Value.ToString().Equals("0"))
        {
            rl.Visible = true;
            rl.Text = "Employee not assigned to project";
        }
        else
        {
            if (flag.Value.ToString().Equals("1"))
            {
               rl.Visible = true;

                rl.Text = "Task does not exist";

            }
            else
            {
                rl.Visible = true;

                rl.Text = "Done";

            }
        }
        conn.Close();
    }
}