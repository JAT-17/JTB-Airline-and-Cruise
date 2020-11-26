using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTB_Airline_and_Cruise
{




    public class ReservationInfo
    {
        public string AirLine { get; set; }

        public string Departure_Location { get; set; }

        public string Destination_Location { get; set; }

        public string StartDate { get; set; }

        public string Return_AirLine { get; set; }

        public string Return_Departure_Location { get; set; }

        public string Return_Destination_Location { get; set; }

        public string Return_Departure_Date { get; set; }

        public decimal Price { get; set; }


    }
}