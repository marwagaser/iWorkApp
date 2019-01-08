using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class replyemails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("replyEmail", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        int i = int.Parse(txt_email.Text);
        cmd.Parameters.Add(new SqlParameter("@old_serial",i));
        string body = txt_body.Text;
        cmd.Parameters.Add(new SqlParameter("@body", body));
        string sub = txt_subject.Text;
        cmd.Parameters.Add(new SqlParameter("@subject", sub));

        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (flag.Value.ToString().Equals("1"))
            Response.Write("You have not received and E-mail with the serial number you have entered");
        else if (flag.Value.ToString().Equals("0"))
            Response.Write("Sent");


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffMembers");
    }
}