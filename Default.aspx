<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JTB_Airline_and_Cruise._Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="carouselExampleCaptions" class="carousel slide carousel-fade" data-ride="carousel">
       <ol class="carousel-indicators">
        <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
        <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
        <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
        </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
        <img src="Online%20Flight%20and%20Cruise/Loginbackground.jpg" class="d-block w-100" alt="Airplane">
     <div class="carousel-caption d-none d-md-block">

      </div>
    </div>
    <div class="carousel-item">
        <img src="Online%20Flight%20and%20Cruise/Cruiseship.jpg" class="d-block w-100" alt="Cruise Ship">
     <div class="carousel-caption d-none d-md-block">
        
     </div>
    </div>
    <div class="carousel-item">
        <img src="Online%20Flight%20and%20Cruise/grouptouristpic.jpg" class="d-block w-100" alt="Tourist">
    <div class="carousel-caption d-none d-md-block">
       
    </div>
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

     <div class="row product-container">


        <div class="col-md-6 col-sm-6" style="margin-bottom:8px">
            <div class="img-thumbnail product-item" style="height:250px">
                <a href="FlightReservations"><img class="img-responsive" title="Click to Book a Flight" 
                    style="cursor:pointer;height:100px;width:200px"
                    src="Online%20Flight%20and%20Cruise/airplaneicon.jpg" /></a>
                <hr />
                <div class="caption">
                    <h5>Book Flights</h5>
                    <p class="text-justify">Choose from a wide selection of vacation bookings suitable for your needs.</p>
                </div>
            </div>
        </div>

        <div class="col-md-6 col-sm-6" style="margin-bottom:8px">
            <div class="img-thumbnail product-item" style="height:250px">
                <a href="CruiseReservations.aspx"><img class="img-responsive" title="Click to Book A Cruise" 
                    style="cursor:pointer;height:100px;width:200px"
                    src="Online%20Flight%20and%20Cruise/cruiseshipicon.jpg" /></a>
                <hr />
                <div class="caption">
                    <h5>Book Cruise</h5>
                    <p class="text-justify">Select the type of Cruise ideal for your entertainment, food and other ammenitiess designed to make your trip memorable.</p>
                </div>
            </div>
        </div>
    </div>

</asp:Content>


