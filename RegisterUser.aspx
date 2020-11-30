<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="JTB_Airline_and_Cruise.RegisterUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Registration</h4>
                                    <hr />
                                </center>
                            </div>
                        </div>


                        <div class="row">
                            <div class="col-md-6">
                                <label>First Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="inputs" ID="TxtFN" runat="server" placeholder="First Name"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Last Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="inputs" ID="TxtLN" runat="server" placeholder="Last Name"></asp:TextBox> 
                                </div>
                            </div>
                          </div>

                         <div class="row">
                            <div class="col-md-6">
                                <label>Date of Birth</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="DOB" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                           <div class="col-md-6">
                               <label>Email Address</label>
                             <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="Txtemail" runat="server" placeholder="Email Address" TextMode="Email"></asp:TextBox>
                             </div>
                           </div>
                            
                        </div>
                         <div class="row">
                            <div class="col-md-6">
                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="inputs" ID="TxtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Confirm Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="inputs" ID="TxtPassword2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox> 
                                </div>
                            </div>

                        </div>
                            
                        </div>

                        <div class="row">
                            <div class="col">
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click1" />
                                </div>
                            </div>
                        </div>
                    </div>
               
                <a href="Default.aspx"><<--Back Home</a><br><br>
            </div>
        </div>
    </div>

</asp:Content>
