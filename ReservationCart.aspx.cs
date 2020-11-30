using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace JTB_Airline_and_Cruise
{
    public partial class ReservationCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            data = (DataSet)Session["Result"];
            GridView2.DataSource = data;
            GridView2.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Session["Uid"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            else
            {
                L1.Text = GridView2.SelectedRow.Cells[1].Text;
                L2.Text = GridView2.SelectedRow.Cells[2].Text;
                L3.Text = GridView2.SelectedRow.Cells[3].Text;
                L4.Text = GridView2.SelectedRow.Cells[4].Text;
                L5.Text = GridView2.SelectedRow.Cells[5].Text;
                L6.Text = GridView2.SelectedRow.Cells[6].Text;
                L7.Text = GridView2.SelectedRow.Cells[7].Text;
                L8.Text = GridView2.SelectedRow.Cells[8].Text;
                L9.Text = GridView2.SelectedRow.Cells[9].Text;
                string alpha = "1234567890";
                Random r = new Random();
                char[] myArray = new char[5];
                for (int i = 0; i < 5; i++)
                {
                    myArray[i] = alpha[(int)(10 * r.NextDouble())];
                }
                string booking;
                booking = new string(myArray);
                Session["booking"] = booking;
                AirLine_Service_Reference.Airline_WebServiceSoapClient client = new AirLine_Service_Reference.Airline_WebServiceSoapClient();
                int Insert = client.InsertBookings(Convert.ToInt32(Session["Uid"]), Convert.ToInt32(Session["booking"]), Convert.ToString(L1.Text), Convert.ToString(L2.Text), Convert.ToString(L3.Text),
                    Convert.ToString(L4.Text), Convert.ToString(L5.Text), Convert.ToString(L6.Text), Convert.ToString(L7.Text), Convert.ToString(L8.Text), Convert.ToDecimal(L9.Text));
                Response.Write("<script>alert('Booking Successful');</script>");
            }
        }
    }
}