using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class viewRequests : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("viewRequests1", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@hr_username", Session["Username"].ToString());
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void GridView1_RowCommand(Object sender, GridViewCommandEventArgs e)
    {

        if (e.CommandName.Equals("Accept"))
        {
            int row = Convert.ToInt32(e.CommandArgument.ToString());
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("viewRequests1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hr_username", Session["Username"].ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("Success");

        }
        if (e.CommandName.Equals("Reject"))
        {
            int row = Convert.ToInt32(e.CommandArgument.ToString());
            int col = int.Parse((GridView1.Rows[row].Cells[2].Text));
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("viewRequests1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hr_username", Session["Username"].ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("Success");

        }

    }
}