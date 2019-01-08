//cs:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class AddNewJob : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        addQ.Visible = false;
        a.Visible = false; q.Visible = false;
        TextBox11.Visible = false; answer.Visible = false;
        Button1.Visible = false;
    }
    protected void submit_Click(object sender, EventArgs e)
    {
        addQ.Visible = true;
        a.Visible = true; q.Visible = true;
        TextBox11.Visible = true; answer.Visible = true;
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("hrjobinsertion", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["Username"].ToString());
        cmd.Parameters.AddWithValue("@title", TextBox1.Text.ToString());
        cmd.Parameters.AddWithValue("@short_description", TextBox4.Text.ToString());
        cmd.Parameters.AddWithValue("@detailed_description", TextBox5.Text.ToString());
        cmd.Parameters.AddWithValue("@min_experience", TextBox6.Text.ToString());
        cmd.Parameters.AddWithValue("@salary", TextBox7.Text.ToString());
        cmd.Parameters.AddWithValue("@deadline", TextBox8.Text.ToString());
        cmd.Parameters.AddWithValue("@no_of_vacancies", TextBox9.Text.ToString());
        cmd.Parameters.AddWithValue("@working_hours", TextBox10.Text.ToString());
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();
        cmd.ExecuteNonQuery();
        string f = Convert.ToString(flag.Value);
        conn.Close();
        if (f.Equals("1"))
        {
            Response.Write("Success");
        }
        else Response.Write("There is an error with the inserted information, please check again");
    }





    protected void addQ_Click(object sender, EventArgs e)
    {
        Button1.Visible = true;
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("addQuestions", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@hr", Session["Username"].ToString());
        cmd.Parameters.AddWithValue("@job_title", TextBox1.Text.ToString());
        cmd.Parameters.AddWithValue("@q", TextBox11.Text.ToString());
        cmd.Parameters.AddWithValue("@a", answer.Text.ToString());

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }
    //protected void addQ_Click(object sender, EventArgs e) { }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("HR_homepage.aspx");
    }


}
