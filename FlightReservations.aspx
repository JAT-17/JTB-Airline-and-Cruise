<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FlightReservations.aspx.cs" Inherits="JTB_Airline_and_Cruise.FlightReservations" %>
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
                                    <asp:TextBox CssClass="form-control" ID="TxtCountry" runat="server"></asp:TextBox>
                                </div>

                                <label>City</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TxtCity" runat="server"></asp:TextBox>
                                </div>

                                 <label>Date of Flight</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TxtDate" runat="server" TextMode="Date"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="View Available Flights" />
                                </div>

                                
                            </div>
                        </div>

                    </div>
                </div>

            </div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
