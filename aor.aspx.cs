using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class aor : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        if (Request.QueryString["request_id"] != null)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Requests r where r.request_id= " + Request.QueryString["request_id"] + "", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        Label1.Visible = false;
        reason.Visible = false;
    }

    protected void ab_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("reject_approve_requests", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@appid", Request.QueryString["request_id"]);
        cmd.Parameters.AddWithValue("@rejorapp", "accept");
        cmd.Parameters.AddWithValue("@reason", "none");

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        done.Visible = true;
        ab.Visible = false;
        rb.Visible = false;
    }



    protected void rb_Click(object sender, EventArgs e)
    {
        Label1.Visible = true;
        reason.Visible = true;
       

    }

    protected void reason_TextChanged(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("reject_approve_requests", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["username"].ToString());
        cmd.Parameters.AddWithValue("@appid", Request.QueryString["request_id"]);
        cmd.Parameters.AddWithValue("@rejorapp", "reject");
        cmd.Parameters.AddWithValue("@reason", reason.Text);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        ab.Visible = false;
        Label1.Visible = false;
        reason.Visible = false;
        rb.Visible = false;
        done.Visible = true;
    }
}