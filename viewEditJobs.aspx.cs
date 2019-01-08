using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
public partial class viewEditJobs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        title1.Visible = false;      jt.Visible = false;
        Short.Visible = false;      nsd.Visible = false;
        Detailed.Visible = false;   ndd.Visible = false;
        mini.Visible = false;       minEx.Visible = false;
        sal.Visible = false;        salary.Visible = false;
        dead.Visible = false;       deadline.Visible = false;
        num.Visible = false;        numvac.Visible = false;
        whrs.Visible = false;       wh.Visible = false;
        submit.Visible = false;
    }

    protected void enter_Click(object sender, EventArgs e)
       
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        title1.Visible = true; jt.Visible = true;
        Short.Visible = true; nsd.Visible = true;
        Detailed.Visible = true; ndd.Visible = true;
        mini.Visible = true; minEx.Visible = true;
        sal.Visible = true; salary.Visible = true;
        dead.Visible = true; deadline.Visible = true;
        num.Visible = true; numvac.Visible = true;
        whrs.Visible = true; wh.Visible = true;
        submit.Visible = true;
        SqlCommand cmd = new SqlCommand("viewJobAlone", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["Username"].ToString());
        cmd.Parameters.AddWithValue("@title", oldJobTitle.Text.ToString());
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if (flag.ToString().Equals("1")) { 
        foreach (DataRow dr in dt.Rows)
          {
            
            jt.Text = dr["title"].ToString();
            nsd.Text = dr["short_description"].ToString();
            ndd.Text = dr["detailed_description"].ToString();
            minEx.Text = dr["min_experience"].ToString();
            salary.Text = dr["salary"].ToString();
            deadline.Text = dr["deadline"].ToString();
            numvac.Text = dr["no_of_vacancies"].ToString();
            wh.Text = dr["working_hours"].ToString();
        }
        }


    }

    protected void submit_Click(object sender, EventArgs e)

    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("editjob", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", Session["Username"].ToString());
        cmd.Parameters.AddWithValue("@title", oldJobTitle.Text);
        cmd.Parameters.AddWithValue("@title1", jt.Text );
        cmd.Parameters.AddWithValue("@short_description", nsd.Text);
        cmd.Parameters.AddWithValue("@detailed_description", ndd.Text);
        cmd.Parameters.AddWithValue("@min_experience", minEx.Text);
        cmd.Parameters.AddWithValue("@salary", salary.Text);
        cmd.Parameters.AddWithValue("@deadline", Convert.ToDateTime(deadline.Text));
        cmd.Parameters.AddWithValue("@no_of_vacancies", Convert.ToInt32(numvac.Text));
        cmd.Parameters.AddWithValue("@working_hours", Convert.ToInt32(wh.Text));
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        conn.Open();
        cmd.ExecuteNonQuery();
        string f = Convert.ToString(flag);
        conn.Close();
        if (f.Equals("1"))
        {

            Response.Write("Success");
        }
        Response.Write("Operation Failed. Please check the information and try again");

    }
}