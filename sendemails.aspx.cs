using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class sendemails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("sendemails", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@sender", Session["Username"].ToString()));
        string rec = txt_to.Text;
        cmd.Parameters.Add(new SqlParameter("@rec", rec));
        string sub = txt_sub.Text;
        cmd.Parameters.Add(new SqlParameter("@subject", sub));
        string body = txt_body.Text;
        cmd.Parameters.Add(new SqlParameter("@body", body));

        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (flag.Value.ToString().Equals("1"))
            Response.Write("Receiver not a staff member");
        else
        {
            if (flag.Value.ToString().Equals("2"))
            {
                Response.Write("You are not in the same company");
            }
            else
            {
                Response.Write("Sent");
            }
        }


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffMembers");

    }
}