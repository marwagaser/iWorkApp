using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class ViewApplications : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //GridView1.Visible = false;
    }
    protected void GridView1_RowCommand(Object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName.Equals("Accept"))
        {
            int row = Convert.ToInt32(e.CommandArgument.ToString());
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("acceptorreject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", Session["Username"].ToString());
            cmd.Parameters.AddWithValue("@job", TextBox1.Text);
            cmd.Parameters.AddWithValue("@appno", int.Parse((GridView1.Rows[row].Cells[2]).Text));
            cmd.Parameters.AddWithValue("@setstatus", "Accept");
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("Success");

        }
        if(e.CommandName.Equals("Reject"))
        {
            int row = Convert.ToInt32(e.CommandArgument.ToString());
            int col = int.Parse((GridView1.Rows[row].Cells[2].Text));
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("acceptorreject", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", Session["Username"].ToString());
            cmd.Parameters.AddWithValue("@job", TextBox1.Text);
            cmd.Parameters.AddWithValue("@appno", col);
            cmd.Parameters.AddWithValue("@setstatus", "Reject");
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("Success");

        }
            }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //GridView1.Visible = true;
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("viewapp", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["Username"].ToString());
        cmd.Parameters.AddWithValue("@title", TextBox1.Text);
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if (flag.Value.ToString() == "1")
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
            Response.Write("There are no applications for this job");
    }
}