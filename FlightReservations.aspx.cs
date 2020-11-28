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

        DataSet ObjectToStoreWebServiceDataFromDB = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SearchForFlightbtn_Click(object sender, EventArgs e)
        {
            
            AirLine_Service_Reference.Airline_WebServiceSoapClient client = new AirLine_Service_Reference.Airline_WebServiceSoapClient();
            ObjectToStoreWebServiceDataFromDB = client.GetResevationDataFromDB( CountryDropDownList.ToString(), CityDropDownList.ToString(), TxtDepartDate.ToString(), TxtReturnDate.ToString());

            Session["ReservationDetails"] = ObjectToStoreWebServiceDataFromDB.ToString();
            Response.Redirect("ReservationCart.aspx");

        }

       
    }
}