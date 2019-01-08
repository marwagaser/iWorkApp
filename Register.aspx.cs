using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("registerusers", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", username.Text);
        cmd.Parameters.AddWithValue("@password", pass.Text);
        cmd.Parameters.AddWithValue("@personal_email", email.Text);
        cmd.Parameters.AddWithValue("@years_of_expereince", yoe.Text);
        string date1 = System.String.Concat(date.Text, " 12:00:00 AM");
        DateTime dob = Convert.ToDateTime(date1);
        cmd.Parameters.AddWithValue("@birth_date", date1);
        cmd.Parameters.AddWithValue("@first_name", fn.Text);
        cmd.Parameters.AddWithValue("@middle_name", mn.Text);
        cmd.Parameters.AddWithValue("@last_name", ln.Text);
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();
        cmd.ExecuteNonQuery();
        string f = Convert.ToString(flag);
        conn.Close();
        if (f.Equals("0"))
        {

            Response.Write("Username Taken");

        }
        else
        {
            Response.Redirect("JobSeekers");
        }
    }
}



//}