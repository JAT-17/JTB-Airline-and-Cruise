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
        public DataSet GetResevationDataFromDB(string Departure, string Location , string StartDate, string Departure_Date)
        {
            DataSet ds = new DataSet();
            string dbconnection = ConfigurationManager.ConnectionStrings["AirlineandCruiseDBConnection"].ConnectionString;
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

                 if (sqlconn.State!= ConnectionState.Open)
                {
                    sqlconn.Open();
                }
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                adp.Fill(ds);
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                
            }

            return ds;
        }

        [WebMethod]
        public int InsertBookings(int UserId, int Bookin_no, string Airline, string Departure, string Destination, string StartDate, string rAirline, string rDeparture, string rDestination, string enddate, Decimal Price)
        {
            int retRecord = 0;
            string dbconnection = ConfigurationManager.ConnectionStrings["AirlineandCruiseDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(dbconnection))
            {
                using (SqlCommand cmd = new SqlCommand("InsertBooking", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("UserId", SqlDbType.Int).Value = UserId;
                    cmd.Parameters.Add("Bookin_no", SqlDbType.Int).Value = Bookin_no;
                    cmd.Parameters.Add("Airline", SqlDbType.VarChar, 100).Value = Airline;
                    cmd.Parameters.Add("Departure", SqlDbType.VarChar, 100).Value = Departure;
                    cmd.Parameters.Add("Destination", SqlDbType.VarChar, 100).Value = Destination;
                    cmd.Parameters.Add("StartDate", SqlDbType.VarChar, 100).Value = StartDate;
                    cmd.Parameters.Add("rAirline", SqlDbType.VarChar, 100).Value = rAirline;
                    cmd.Parameters.Add("rDeparture", SqlDbType.VarChar, 100).Value = rDeparture;
                    cmd.Parameters.Add("rDestination", SqlDbType.VarChar, 100).Value = rDestination;
                    cmd.Parameters.Add("enddate", SqlDbType.VarChar, 100).Value = enddate;
                    cmd.Parameters.Add("Price", SqlDbType.Decimal, 2).Value = Price;


                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    retRecord = cmd.ExecuteNonQuery();
                }
                return retRecord;
            }
           
        }
    }
} 
