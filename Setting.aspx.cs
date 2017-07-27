using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace KitchenIn
{
    public partial class Setting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string a = Session["id"].ToString();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from walkinn Where id='" + a + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);



            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            string b = reader["username"].ToString();
            TextBox1.Text = b.ToString();
            string c = reader["status"].ToString();
            TextBox2.Text = c.ToString();

            reader.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = ((Int32)(Session["id"]));
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update walkinn Set username=@user Where id= '" + a + "'";
            cmd.Parameters.AddWithValue("@user", TextBox1.Text);
            cmd.ExecuteNonQuery();
            Label4.Text = "To Update your account , You must logout and then login";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = ((Int32)(Session["id"]));

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update walkinn Set status=@s Where id= '" + a + "'";
            cmd.Parameters.AddWithValue("@s", TextBox2.Text);
            cmd.ExecuteNonQuery();
            Label4.Text = "To Update your account , You must logout and then login";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = ((Int32)(Session["id"]));
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete  from  walkinn Where id= '" + a + "'";
            
            
            cmd.ExecuteNonQuery();
            Response.Redirect("SignIn.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            
            Session.RemoveAll();
            Response.Redirect("SignIn.aspx");
        }
    }
}