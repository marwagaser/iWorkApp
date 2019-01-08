using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class leaverequest : System.Web.UI.Page
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
        SqlCommand cmd = new SqlCommand("apply_leave_requests", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        DateTime sd = DateTime.Parse(txt_sd.Text);
        DateTime ed = DateTime.Parse(txt_end.Text);
        cmd.Parameters.Add(new SqlParameter("@startdate", sd));
        cmd.Parameters.Add(new SqlParameter("@enddate", ed));
        string rb = txt_rb.Text;
        cmd.Parameters.Add(new SqlParameter("@replacement", rb));
        string type = txt_type.Text;
        cmd.Parameters.Add(new SqlParameter("@type", type));
        SqlParameter flag = cmd.Parameters.Add("@flagleave", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();


          if (flag.Value.ToString().Equals("0"))
        {
            Response.Write("Done");
        }
        else if (flag.Value.ToString().Equals("1"))
        {
            Response.Write(" Request overlaps with previous requests");
        }

        else if (flag.Value.ToString().Equals("2"))
        {
            Response.Write("You and the employee that should replace you are not from the same staff category");
        }
       
           else 
            {
            if (flag.Value.ToString().Equals("3")) {
                Response.Write("You are not in the same department/company");
            }
            if (flag.Value.ToString().Equals("10"))
            {
                Response.Write("Your leave exceeds your allowed annual leaves");
            }
        }

      


    }
}