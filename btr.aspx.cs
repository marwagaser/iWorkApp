using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class btr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("apply_Business_Trip_requests", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        DateTime sd = DateTime.Parse(txt_sdd.Text);
        DateTime ed = DateTime.Parse(txt_edd.Text);
        cmd.Parameters.Add(new SqlParameter("@startdate", sd));
        cmd.Parameters.Add(new SqlParameter("@enddate", ed));
        string rb = txt_rbb.Text;
        cmd.Parameters.Add(new SqlParameter("@replacement", rb));
        string purpose = txt_purpose.Text;
        cmd.Parameters.Add(new SqlParameter("@purpose", purpose));
        string des = txt_des.Text;
        cmd.Parameters.Add(new SqlParameter("@destination", des));

        SqlParameter flag = cmd.Parameters.Add("@flagbus", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        if (flag.Value.ToString().Equals("1"))
        {
            Response.Write(" Request overlaps with previous requests");
        }
        if (flag.Value.ToString().Equals("2"))
        {
            Response.Write("You and the employee that should replace you are not from the same staff category");
        }
        else
        {
            if (flag.Value.ToString().Equals("0"))

            { Response.Write("Done");
            }
            if (flag.Value.ToString().Equals("10"))
            {
                Response.Write("Your leave exceeds your allowed annual leaves");
            }
        }
    }
}