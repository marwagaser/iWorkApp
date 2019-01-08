

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class StaffMembers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("userinfo");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("editinfo");
    }

 

    protected void Button3_Click1(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("checkin", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (flag.Value.ToString().Equals("1"))
            Response.Write("It is your day off;You cannot check in");
        if (flag.Value.ToString().Equals("2"))
            Response.Write("Already checked in for today");
        else if(flag.Value.ToString().Equals("0"))
            Response.Write("checked in just now");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("checkout", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (flag.Value.ToString().Equals("1"))
            Response.Write("No check in record");
        else if (flag.Value.ToString().Equals("0"))
            Response.Write("Checked out just now");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("myattendance");
        
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("therequests");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewReqStatus");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("deleteRequest");
    }

    protected void Button9_Click(object sender, EventArgs e)
    {

    }

    protected void Button9_Click1(object sender, EventArgs e)
    {
        Response.Redirect("sendemails");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewemails");
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Response.Redirect("replyemails");
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Response.Redirect("viewann");
    }



    protected void Button16_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("signinType", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (flag.Value.ToString().Equals("3"))
        {
            Response.Redirect("RegularMembers");
        }

        if (flag.Value.ToString().Equals("2"))
        {
            Response.Redirect("HR_homepage");
        }
        if (flag.Value.ToString().Equals("1"))
        {
            Response.Redirect("managerstart");
        }
    }

}