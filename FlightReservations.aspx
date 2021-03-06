﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FlightReservations.aspx.cs" Inherits="JTB_Airline_and_Cruise.FlightReservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
     
    <table style=" width: 1270px; height:30px;">
        <tr style="background-color: #00ffff">
            <td colspan="2" style=" text-align:center">
               <asp:Label ID="Label" runat="server" Font-Bold="True" ForeColor="White" Text="AIRLINE FLIGHT SYSTEM" Font-Italic="True" Font-Names="Bahnschrift SemiBold"></asp:Label>
            </td>
        </tr>
       
    </table>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Flight Reservation</h3>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Country</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-group" ID="CountryDropDownList"  runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="Sangster International Airport - Montego Bay, Jamaica" Value="Sangster International Airport - Montego Bay, Jamaica" />
                                        <asp:ListItem Text="Norman Manley International Airport - Kingston, Jamaica" Value="Norman Manley International Airport - Kingston, Jamaica" />
                                        <asp:ListItem Text="Fleming International Airport - Ocho Rios, Jamaica" Value="Fleming International Airport - Ocho Rios, Jamaica" />
                                        <asp:ListItem Text="LAX - Los Angeles, California, United States" Value="LAX - Los Angeles, California, United States" />
                                        <asp:ListItem Text="John F. Kennedy International Airport - New York City, United States" Value="John F. Kennedy International Airport - New York City, United States" />
                                        <asp:ListItem Text="Miami International Airport - Miami, Florida, United States" Value="Miami International Airport - Miami, Florida, United States" />
                                        <asp:ListItem Text="Toronto Pearson International Airport - Toronto, Canada" Value="Toronto Pearson International Airport - Toronto, Canada" />
                                        <asp:ListItem Text="Vancouver International Airport - Vancouver, Canada" Value="Vancouver International Airport - Vancouver, Canada" />
                                        <asp:ListItem Text="Calgary International Airport - Calgary, Canada" Value="Calgary International Airport - Calgary, Canada" />
                                        <asp:ListItem Text="Heathrow Airport - United Kingdom" Value="Heathrow Airport - United Kingdom" />
                                  
                                    </asp:DropDownList>
                                </div>

                                <label>City</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-group" ID="CityDropDownList"  runat="server">
                                        <asp:ListItem Text="Select" Value="select" />
                                        <asp:ListItem Text="Sangster International Airport - Montego Bay, Jamaica" Value="Sangster International Airport - Montego Bay, Jamaica" />
                                        <asp:ListItem Text="Norman Manley International Airport - Kingston, Jamaica" Value="Norman Manley International Airport - Kingston, Jamaica"/>
                                        <asp:ListItem Text="Fleming International Airport - Ocho Rios, Jamaica" Value="Fleming International Airport - Ocho Rios, Jamaica" />
                                        <asp:ListItem Text="LAX - Los Angeles, California, United States" Value="LAX - Los Angeles, California, United States" />
                                        <asp:ListItem Text="John F. Kennedy International Airport - New York City, United States" Value="John F. Kennedy International Airport - New York City, United States" />
                                        <asp:ListItem Text="Miami International Airport - Miami, Florida, United States" Value="Miami International Airport - Miami, Florida, United States" />
                                        <asp:ListItem Text="Toronto Pearson International Airport - Toronto, Canada" Value="Toronto Pearson International Airport - Toronto, Canada" />
                                        <asp:ListItem Text="Vancouver International Airport - Vancouver, Canada" Value="Vancouver International Airport - Vancouver, Canada" />
                                        <asp:ListItem Text="Calgary International Airport - Calgary, Canada" Value="Calgary International Airport - Calgary, Canada" />
                                        <asp:ListItem Text="Heathrow Airport - United Kingdom" Value="Heathrow Airport - United Kingdom" />
                                    </asp:DropDownList>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                    <label>Departure Date</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="TxtDepartDate" runat="server" TextMode="Date"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="col-md-6">
                                    <label>Return Date</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="TxtReturnDate" runat="server" TextMode="Date"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                 

                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="SearchForFlightbtn" runat="server" Text="View Available Flights" OnClick="SearchForFlightbtn_Click" />
                                </div>


                                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </div>
    </div>

    <br />
    <br />

    <div>
         <asp:GridView ID="Gridview1" runat="server" Visible="true"></asp:GridView>
    </div>
</asp:Content>
