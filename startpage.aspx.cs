
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class startpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
    }


    protected void gocomp_Click(object sender, EventArgs e)
    {
        string mysearch = searchtextbox.Text;
        Session["searchname"] = mysearch;
        Response.Redirect("Searchcompanies.aspx", true);

    }
    protected void gocomp1_Click(object sender, EventArgs e)
    {
        string mysearch = searchtextbox0.Text;
        Session["searchname"] = mysearch;
        Response.Redirect("SearchJob");


    }
    protected void Register_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx", true);
    }



    protected void  searchAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("searchAllCompanies", true);

    }

    protected void login_Click(object sender, EventArgs e)
    {
        Response.Redirect("login", true);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
       
            Response.Redirect("viewavgsalary");
        
    }
    protected void dinfo_Click(object sender, EventArgs e)
    {
        ln.Visible = true;
        cn.Visible = true;
        lno.Visible = true;
        dn.Visible = true;
        gs.Visible = true;

    }

    protected void gs_Click(object sender, EventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("depinfo", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@companyname", cn.Text);
        cmd.Parameters.AddWithValue("@depname", dn.Text);

        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }



}

