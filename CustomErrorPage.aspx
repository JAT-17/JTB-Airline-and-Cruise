<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomErrorPage.aspx.cs" Inherits="JTB_Airline_and_Cruise.CustomErrorPage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h1>   An error has occured!!</h1>

    
        <h2>

            An unexpected error has occured. The administrator as been notified.
        </h2>
    <p>
        <asp:HyperLink   id="inkhome" runat="server"  NavigateURL="~/Default.aspx" >Return to home page</asp:HyperLink>

    </p>
</asp:Content>
