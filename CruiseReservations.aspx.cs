using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace JTB_Airline_and_Cruise
{
    public partial class CruiseReservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {








        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();



            Cruise_Service_Reference.Cruise_WebServiceSoapClient client = new Cruise_Service_Reference.Cruise_WebServiceSoapClient();



            ds = client.GetCruiseDataFromDB(Convert.ToString(TxtCheckIn.Text), Convert.ToString(TxtCheckOut.Text));


            if (ds == null)
            {
                Label1.Text = "No Dates are selected";
            }
            else
            {

                Label1.Text = TxtCheckIn.Text + TxtCheckOut.Text;
            }
            Cruise_GridView.DataSource = ds;
            Cruise_GridView.DataBind();






        }
    }
}