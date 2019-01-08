using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class projecttasks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);

    }
    protected void aort(object sender, GridViewCommandEventArgs e)

    {
        int row = Convert.ToInt32(e.CommandArgument.ToString());
        int tid =int.Parse( GridView1.Rows[row].Cells[0].Text);
        Session["tid"] = tid;
        if (e.CommandName == "at")
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("accept_rejecttasks", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@task", tid);
            cmd.Parameters.AddWithValue("@resp", "accept");
            cmd.Parameters.AddWithValue("@project", Session["projectname"]);
            cmd.Parameters.AddWithValue("@deadline", null);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        if (e.CommandName == "rt")
        {
            nd.Visible = true;
            ndt.Visible = true;

        }

    }


    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        if (TextBox1.Text != "Fixed")
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("view_tasks_in_project_with_status", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@project", Session["projectname"].ToString());
            cmd.Parameters.AddWithValue("@status", TextBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        else
        {
            if (TextBox1.Text == "Fixed")
            {
                string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("view_tasks_in_project_with_status", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@project", Session["projectname"].ToString());
                cmd.Parameters.AddWithValue("@status", TextBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
        }
    }

    protected void ndt_SelectionChanged(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("accept_rejecttasks", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@task", Session["tid"]);
        cmd.Parameters.AddWithValue("@resp", "reject");
        cmd.Parameters.AddWithValue("@project", Session["projectname"]);
        cmd.Parameters.AddWithValue("@deadline", ndt.SelectedDate);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}