using System;
using System.Collections.Generic;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class deleteRequest : System.Web.UI.Page
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

        
        SqlCommand cmd = new SqlCommand("dltreq", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        int getid = int.Parse(txt_req.Text);
        cmd.Parameters.Add(new SqlParameter("@rid", getid));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (flag.Value.ToString().Equals("1"))
        {
            Response.Write("You dont have a request with such number or it is already deleted");
        }
        else if (flag.Value.ToString().Equals("2"))
        {
            Response.Write("Your request was already reviewed");
        }
        else if (flag.Value.ToString().Equals("3"))
        {
            Response.Write("This is not your request id");
        }
        else {
            if (flag.Value.ToString().Equals("0"))
                Response.Write("Deleted");
        }
            
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffMembers");
    }
}