using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace JTB_Airline_and_Cruise
{
    /// <summary>
    /// Summary description for Airline_WebService
    /// </summary>
    [WebService(Namespace = "http://JTBAirLineandCruise.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Airline_WebService : System.Web.Services.WebService
    {


        [WebMethod]
        public ReservationInfo GetResevationDataFromDB(string Departure, string Location , string StartDate, string Departure_Date)
        {
            ReservationInfo getflightOBJ = new ReservationInfo();
            string dbconnection = ConfigurationManager.ConnectionStrings["JTBAirlineandCruiseDBConnection"].ConnectionString;
            using (SqlConnection sqlconn = new SqlConnection(dbconnection))
            {
                
                SqlCommand cmd = new SqlCommand("getflight", sqlconn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@Departure_Location";
                parameter.Value = Departure;

               

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@Destination_Location";
                parameter1.Value = Location;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@StartDate";
                parameter2.Value = StartDate;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@Departure_Date";
                parameter3.Value = Departure_Date;


                cmd.Parameters.Add(parameter);
                cmd.Parameters.Add(parameter1);
                cmd.Parameters.Add(parameter2);
                cmd.Parameters.Add(parameter3);

                sqlconn.Open();
                SqlDataReader rdata = cmd.ExecuteReader();


                while (rdata.Read())
                {
                    getflightOBJ.AirLine = rdata["AirLine"].ToString();
                    getflightOBJ.Departure_Location = rdata["Departure_Location"].ToString();
                    getflightOBJ.Destination_Location = rdata["Destination_Location"].ToString();
                    getflightOBJ.StartDate = rdata["StartDate"].ToString();
                    getflightOBJ.Return_AirLine = rdata["AirLine"].ToString();
                    getflightOBJ.Return_Destination_Location = rdata["Departure_Location"].ToString();
                    getflightOBJ.Return_Departure_Location = rdata["Destination_Location"].ToString();                  
                    getflightOBJ.Return_Departure_Date = rdata["Departure_Date"].ToString();
                    getflightOBJ.Price = Convert.ToDecimal(rdata["Price"]);
                    
                }

                sqlconn.Close();

            }

            return  getflightOBJ;

        }














        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public int Add(int a , int b)
        {                   
            return a+b;
        }
    }
}
