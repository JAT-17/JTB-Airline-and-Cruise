# JTB-Airline-and-Cruise

Scenario 3: Online Vacation Reservation 			[Functional Requirements 15%]

JTB 🡪 Airline & Cruise

The Jamaica Tourist Board has decided to provide a central website for vacationers to book their flights and cruise. You are required to develop a web application which allows a user to book available flights and cruises for their vacation.

The Vacation Booking system should:
●	Allow user to logon to their profile							[1%]
●	Allow user to search for listing of vacation booking by entering their departure location (country and city), destination (country and city), start date, end date and number of adults 											[4%]
o	System should return and display a list of available departure flights for the details provided...
o	System should return and display a list of available return flights for the details provided...
o	System should return and display a list of available cruises and room types for that period
●	Allow user to select departure and return flights					[1%]
o	Flight should be booked using Airline System web service 			
●	Allow user to select cruise and room type 						[1%]
o	Cruise should be booked using cruise System web service

The Airline System should:
●	Provide a web service that accepts a country, city and a date then returns a list of available flights (airplane_id, flight_id, departure date & time, price) 				[2%]
●	Provide a web service that accepts a flight_id, name, DOB and creates a booking (flight_id, name, DOB, seat#)								[2%]

The Cruise Admin system should:
●	Allow another System to check for available cruises via a web service that accepts check_in_date and check_out_date  and returns list of available room_types	[2%]
●	Allow another System to book a room via a web service that accepts a room_type and creates a booking for a cruise (room#, name, check_in_date, check_out_date) [2%]
