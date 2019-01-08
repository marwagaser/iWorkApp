using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class myattendance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
    }
        protected void end_date_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("viewAttendance", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        DateTime startDate = DateTime.Parse(start_date.Text);
        DateTime endDate = DateTime.Parse(end_date.Text);
        cmd.Parameters.Add(new SqlParameter("@from_date", startDate));
        cmd.Parameters.Add(new SqlParameter("@to_date", endDate));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if (flag.Value.ToString().Equals("1"))
        {
            Response.Write("invalid username");
        }
      else  if (flag.Value.ToString().Equals("2"))
        {
            Response.Write("You have never attended");
        }
        else if (flag.Value.ToString().Equals("0"))
            {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffMembers");
    }
}