
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class viewReqStatus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet dSet = new DataSet();


        string connStr = ConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand cmd = new SqlCommand("statusofmyreq", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add(new SqlParameter("@username", Session["Username"].ToString()));
        SqlParameter flag = cmd.Parameters.Add("@flag", SqlDbType.Int);
        flag.Direction = ParameterDirection.Output;
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
       
        sda.Fill(dSet);
      
        if (flag.Value.ToString().Equals("1"))
            Response.Write("You have not placed any requests yet");
        else
        {

            GridView1.DataSource = dSet.Tables[0];
            GridView1.DataBind();
            GridView2.DataSource = dSet.Tables[1];
            GridView2.DataBind();
            GridView3.DataSource =dSet.Tables[2];
            GridView3.DataBind();

        }


            
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffMembers");
    }
}

