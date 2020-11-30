using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JTB_Airline_and_Cruise
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string dbconnection = ConfigurationManager.ConnectionStrings["AirlineandCruiseDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbconnection))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("Select * from Users where Email='" + Txtemail.Text + "' and Password='" + TxtPassword.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('Successful Login');</script>");
                        Session["Email"] = dr.GetValue(2).ToString();
                        Session["Password"] = dr.GetValue(3).ToString();
                        Session["Uid"] = dr.GetValue(0).ToString();
                        Session["role"] = "User";
                        Response.Redirect("ReservationCart.aspx?=" + Session["Uid"]);
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }

            }
            }

    }
}