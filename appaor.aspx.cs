using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class appaor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        if (Request.QueryString["application_no"] != null)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Applications a where a.application_no= " + Request.QueryString["application_no"] + " and a.job_title= '" + Session["jobtitle"]+"'  and a.department_no= dbo.getdep( '"+Session["username"] +"' ) and a.company_name= dbo.getcomp( '" + Session["username"].ToString() + "' )", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }

    protected void appa_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("accept_reject_apps", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@manuser", Session["username"].ToString());
          cmd.Parameters.AddWithValue("@accrej", "accept");
      cmd.Parameters.AddWithValue("@appno", Request.QueryString["application_no"]);
        cmd.Parameters.AddWithValue("@response", "accept");

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        done.Visible = true;
        appa.Visible = false;
        appr.Visible = false;
    }

    protected void appr_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("accept_reject_apps", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@manuser", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@accrej", "reject");
        cmd.Parameters.AddWithValue("@appno", Request.QueryString["application_no"]);
        cmd.Parameters.AddWithValue("@response", "reject");

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        done.Visible = true;
        appa.Visible = false;
        appr.Visible = false;

    }
}