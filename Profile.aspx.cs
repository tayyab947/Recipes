using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace KitchenIn
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["id"].ToString();
            Label2.Text = Session["username"].ToString();
            Label3.Text = Session["status"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Schedule.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Suggestions.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Setting.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UploadReceipe.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True");
            Label1.Text = Session["id"].ToString();
            
            con.ConnectionString = "Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True";
            string str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath("") + "//uploads//" + str);
            string path = "~//uploads//" + str.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update myimage1 Set image=@mondy  Where id= '" + Label1.Text + "'";
            cmd.Parameters.AddWithValue("@mondy", path);

            cmd.ExecuteNonQuery();

            Label1.Text = "Updated";
            Response.Redirect("Profile.aspx");

        }
    }
}