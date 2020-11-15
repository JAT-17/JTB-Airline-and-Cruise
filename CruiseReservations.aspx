<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CruiseReservations.aspx.cs" Inherits="JTB_Airline_and_Cruise.CruiseReservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style=" width: 1270px; height:30px;">
        <tr style="background-color: #00ffff">
            <td colspan="2" style=" text-align:center">
               <asp:Label ID="Label" runat="server" Font-Bold="True" ForeColor="White" Text="CRUISE SHIP SYSTEM" Font-Italic="True" Font-Names="Bahnschrift SemiBold"></asp:Label>
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
                                    <h3>Cruise Ship Reservation</h3>
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
                                <label>Check In Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TxtCheckIn" runat="server" TextMode="Date"></asp:TextBox>
                                </div>

                                 <label>Check Out Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TxtCheckOut" runat="server" TextMode="Date"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="View Cruises" />
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
