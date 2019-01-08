using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class editinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("updateinfo", conn);
        cmd.CommandType = CommandType.StoredProcedure;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("updateinfo", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username1", Session["Username"].ToString()));
       
        string newpass = txt_newpass.Text;
        cmd.Parameters.Add(new SqlParameter("@password", string.IsNullOrEmpty(txt_newpass.Text) ? (object)DBNull.Value: txt_newpass.Text));
        string newemail = txt_newemail.Text;
        cmd.Parameters.Add(new SqlParameter("@personal_email", string.IsNullOrEmpty(newemail) ? (object)DBNull.Value :newemail));

        if (!(string.IsNullOrEmpty(txt_newexp.Text)))
        {
            int i = int.Parse(txt_newexp.Text);
            cmd.Parameters.Add(new SqlParameter("@experience", i));
        }
        else if ((string.IsNullOrEmpty(txt_newexp.Text)))
        {
            cmd.Parameters.Add(new SqlParameter("@experience", DBNull.Value));
        }
        if (string.IsNullOrEmpty(txt_dob.Text))
        {
            cmd.Parameters.Add("@date_of_birth", SqlDbType.DateTime).Value = DBNull.Value;
        }
        else if (!(string.IsNullOrEmpty(txt_dob.Text)))
        {
            string thedob = txt_dob.Text;
            DateTime dob = DateTime.Parse(txt_dob.Text);
            cmd.Parameters.Add(new SqlParameter("@date_of_birth",dob));
        }

     


        string newfn = txt_fn.Text;
        cmd.Parameters.Add(new SqlParameter("@first_name", string.IsNullOrEmpty(newfn) ? (object)DBNull.Value : newfn));
        string newmn = txt_mn.Text;
        cmd.Parameters.Add(new SqlParameter("@middle_name", string.IsNullOrEmpty(newmn) ? (object)DBNull.Value : newmn));
        string newln = txt_ln.Text;
        cmd.Parameters.Add(new SqlParameter("@last_name", string.IsNullOrEmpty(newln) ? (object)DBNull.Value : newln));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        if (flag.Value.ToString().Equals("1"))
            Response.Write("Username already taken");
        else if (flag.Value.ToString().Equals("0"))
            Response.Write("Updated");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffMembers");
    }
}