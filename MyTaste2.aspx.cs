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
    public partial class MyTaste2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["id"].ToString();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=TAYYABJAVAID;Initial Catalog=Testing;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Rid FROM receipe WHERE id = '"+Label1.Text+"'", con);

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                //Session["Monday"] = TextBox1.Text;
                //Session["Tuesday"] = TextBox2.Text;
                //Label3.Text = reader["Wednesday"].ToString();
                //Session["Wednesday"] = Label3.Text;
                int a = ((Int32)(reader["Rid"]));
                Session["Rid"] = a;
                
                reader.Close();
                Label2.Text = Session["Rid"].ToString();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (FileUpload1.HasFile)
            //{
            //    int a = 5;
            //    string str = FileUpload1.FileName;
            //    FileUpload1.PostedFile.SaveAs(Server.MapPath("") + "//uploads//" + str);
            //    string path = "~//uploads//" + str.ToString();
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("Insert into myimage values('" + path + "')", con);
               
            //    cmd.ExecuteNonQuery();

            //    Label1.Text = "Done";
               

            //    con.Close();
                
            //}

            //else
            //{
            //    Label1.Text = "";
            //}
        }
    }
}