using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace JTB_Airline_and_Cruise
{
    public partial class CruiseResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = (DataSet)Session["CruiseResult"];
            GridView3.DataSource = ds;
            GridView3.DataBind();
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["Uid"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            else
            {
                L1.Text = GridView3.SelectedRow.Cells[1].Text;
                L2.Text = GridView3.SelectedRow.Cells[2].Text;
                L3.Text = GridView3.SelectedRow.Cells[3].Text;
                L4.Text = GridView3.SelectedRow.Cells[4].Text;
                L5.Text = GridView3.SelectedRow.Cells[5].Text;
                L6.Text = GridView3.SelectedRow.Cells[6].Text;
                string alpha = "1234567890";
                Random r = new Random();
                char[] myArray = new char[5];
                for (int i = 0; i < 5; i++)
                {
                    myArray[i] = alpha[(int)(10 * r.NextDouble())];
                }
                string book;
                book = new string(myArray);
                Session["book"] = book;

                Cruise_Service_Reference.Cruise_WebServiceSoapClient client = new Cruise_Service_Reference.Cruise_WebServiceSoapClient();
                int Insert = client.InsertBookings(Convert.ToInt32(Session["Uid"]), Convert.ToInt32(Session["book"]), Convert.ToInt32(L1.Text), Convert.ToString(L2.Text), Convert.ToString(L3.Text),
                    Convert.ToString(L4.Text), Convert.ToString(L5.Text), Convert.ToDecimal(L6.Text));
                Response.Write("<script>alert('Booking Successful');</script>");
            }
          
        }
    }
}