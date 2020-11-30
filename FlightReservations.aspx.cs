using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace JTB_Airline_and_Cruise
{
    public partial class FlightReservations : System.Web.UI.Page
    {

       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchForFlightbtn_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();



            AirLine_Service_Reference.Airline_WebServiceSoapClient client = new AirLine_Service_Reference.Airline_WebServiceSoapClient();
            ds = client.GetResevationDataFromDB(Convert.ToString(CountryDropDownList.Text), Convert.ToString(CityDropDownList.Text), Convert.ToString(TxtDepartDate.Text), Convert.ToString(TxtReturnDate.Text));


            if (ds==null)
            {
                Label1.Text = "No Flights Found";
            }
            else
            {
                Session["Result"] = ds;
                Response.Redirect("ReservationCart.aspx?Result=" + Session["Result"]);
            }

        }

     
    }
}