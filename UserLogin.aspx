<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="JTB_Airline_and_Cruise.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Login Page</h3>
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
                               <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox runat="server" CssClass="form-control" ID="Txtemail" placeholder="Email" ></asp:TextBox>
                                </div>

                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TxtPassword" CssClass="form-control" runat="server" placeholder="Password" TextMode="Password"  ></asp:TextBox>
                                </div>

                                 <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login"  />
                                </div>
                                
                                <br />
                                 <div class="form-group">
                                     <a href="RegisterUser.aspx"><input class="btn btn-info btn-block btn-lg" id="Button2" type="button" value="Register" /></a>
                                </div>
                                
                            </div>
                        </div>

                    </div>
                </div>

                <a href="Default.aspx"><<--Back Home</a><br><br>
            </div>
        </div>
    </div>

</asp:Content>
