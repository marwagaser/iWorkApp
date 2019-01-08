using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class depprojects : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("projectsindep", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@user", Session["username"].ToString());
        SqlParameter flag = new SqlParameter();
        flag.ParameterName = "flag";
        flag.SqlDbType = System.Data.SqlDbType.Int;
        flag.Direction = System.Data.ParameterDirection.Output;
        cmd.Parameters.Add(flag);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        if (flag.Value.ToString().Equals("1"))
        {

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        else
        {
            Response.Write("No projects found");
        }
    }




    protected void Row_Command(object sender, GridViewCommandEventArgs e)
    {
        int row = Convert.ToInt32(e.CommandArgument.ToString());
        String rid = GridView1.Rows[row].Cells[0].Text;
        Session["projectname"] = rid;
        if (e.CommandName== "tasklist")
        {
          Response.Redirect("projecttasks.aspx"); //missing proedure
        }
        if (e.CommandName == "manageemp")
        {
           Response.Redirect("proemp.aspx");
        }
        if (e.CommandName == "newtask")
        {
            Response.Redirect("createtask.aspx");
        }
        if (e.CommandName == "ret")
        {
            Response.Redirect("repemptask.aspx");
        }
    }
}