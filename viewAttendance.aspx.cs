using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class viewAttendance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.Visible = false;
    }

    protected void Go_Click(object sender, EventArgs e)
    {
      
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("viewAttendance", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        GridView1.Visible = true;
        string startConcat = System.String.Concat(TextBox2.Text, " 12:00:00 AM");
        DateTime startFinal = Convert.ToDateTime(startConcat);
        string endConcat = System.String.Concat(TextBox3.Text, " 12:00:00 AM");
        DateTime endFinal = Convert.ToDateTime(endConcat);
        cmd.Parameters.AddWithValue("@username",TextBox1.Text);
        cmd.Parameters.AddWithValue("@from_date", startFinal);
        cmd.Parameters.AddWithValue("@to_date", endFinal);
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        string f = flag.Value.ToString();
        if (f.Equals("0"))
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();

            if (GridView1.VirtualItemCount == 0) Response.Write("This employee has no attendance yet");
        }
        else
            if (f.Equals("1"))
            Response.Write("Invalid Username");
        else
            if (f.Equals("2"))
            Response.Write("There are no attendances for this employee yet");
        else
            Response.Write("The start date is greater than the end date. Please check the data and try again");



    }
}