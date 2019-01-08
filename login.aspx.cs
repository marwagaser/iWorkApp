using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
          
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void logmein_Click(object sender, EventArgs e)


    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("user_login", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        string username = txt_username.Text;
        string password = txt_password.Text;
        cmd.Parameters.Add(new SqlParameter("@username", username));
        cmd.Parameters.Add(new SqlParameter("@password", password));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        SqlParameter type = cmd.Parameters.Add("@type", SqlDbType.VarChar,20);
        type.Direction = ParameterDirection.Output;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if (flag.Value.ToString().Equals("1"))
        {
            Response.Write("Incorrect Username");
        }
      else  if (flag.Value.ToString().Equals("2"))
        {
            Response.Write("Incorrect Password");
        }
        else {
            if (type.Value.Equals("staff"))
            {
                string theusername = txt_username.Text;
                Session["Username"] = theusername;
                Response.Redirect("StaffMembers");
            }
            if (type.Value.Equals("other"))
            {
                string theusername = txt_username.Text;
                Session["Username"] = theusername;
                Response.Redirect("JobSeekers");
            }

        }
           

    }

 
}