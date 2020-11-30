using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace JTB_Airline_and_Cruise
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string alpha = "1234567890";
            Random r = new Random();
            char[] myArray = new char[5];
            for (int i = 0; i < 5; i++)
            {
                myArray[i] = alpha[(int)(10 * r.NextDouble())];
            }
            string Userid;
            Userid = new string(myArray);
            Session["user"] = Userid;
            string dbconnection = ConfigurationManager.ConnectionStrings["JTBAirlineandCruiseDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbconnection))
            {
                SqlCommand cmd = new SqlCommand("insert into Users" + "(Users_id,FirstName,LastName,Email,Password,DOB)values(@userid,@Firstname,@Lastname,@Email,@Password,@DOB)", con);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd.Parameters.AddWithValue("@userid", Session["user"]);
                cmd.Parameters.AddWithValue("@Firstname", TxtFN.Text);
                cmd.Parameters.AddWithValue("@Lastname", TxtLN.Text);
                cmd.Parameters.AddWithValue("@Email", Txtemail.Text);
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                cmd.Parameters.AddWithValue("@DOB", DOB.Text);
                cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                Response.Redirect("UserLogin.aspx");
            }
        }
    }
}
    
