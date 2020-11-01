<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="JTB_Airline_and_Cruise.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br><br>
    <div class="container">
        <h2>Contact Us</h2>
        <h2 style="text-align: center;">We'd Love to Assist You</h2>
        <p style="text-align: center;">We would love to recieve your feedbacks</p>
        <hr />
    </div>

    <div class="row">
    <div class="col-md-6">
        <form>
            <input type="Text" name="text" required="" placeholder="Your Name" class="form-control" />
            <br>
            <input type="Email" name="text" required="" placeholder="Your Email" class="form-control" />
            <br>
            <br>

            <textarea rows="6" placeholder="Comment" required="" class="form-control"></textarea>
            <br>
            <center>
            <button class="btn btn-info">Submit</button>
            </center>
            <br><br><br><br>

        </form>
    </div>
        <div class="col-md-1"></div>

    <div class="col-md-5">
        <p class="icn"><i class="fa fa-map-marker"></i>&nbsp;&nbsp; 64 Knutsford Blvd, Kingston</p>
        <p class="inc"><i class="fa fa-phone"></i>&nbsp;&nbsp; (876) 929-9200</p>
        <p class="inc"><i class="fa fa-envelope"></i>&nbsp;&nbsp;  info@visitjamaica.com</p>

        <hr>

        <div class="social-media">
            <ul class="list-unstyled">
                <li><a href="#"><i class="fab fa-facebook-f"></i></a></li>
                <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                <li><a href="#"><i class="fab fa-instagram"></i></a></li>
                <li><a href="#"><i class="fab fa-google-plus-g"></i></a></li>
                <li><a href="#"><i class="fab fa-youtube"></i></a></li>
            </ul> 
        </div>
        <br>
        <br>
        <p style="margin-left: 23px; font-style: italic;">Follow Our Pages For Updates</p>
    </div>

    </div>
</asp:Content>
