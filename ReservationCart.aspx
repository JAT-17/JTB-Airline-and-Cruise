<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservationCart.aspx.cs" Inherits="JTB_Airline_and_Cruise.ReservationCart" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

<div>
    <asp:GridView class="table table-striped table-bordered" ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        <Columns>
            <asp:CommandField SelectText="Select Flight" ShowSelectButton="True">
            <ItemStyle ForeColor="#99FF33" />
            </asp:CommandField>
        </Columns>
       
    </asp:GridView>
   
</div>

    <br />

    <table style="width:100%">
  <tr>
      <td>
                <asp:Label ID="L1" runat="server" Text=""></asp:Label>
                  &emsp;
                <asp:Label ID="L2" runat="server" Text=""></asp:Label>
                 &emsp;
                <asp:Label ID="L3" runat="server" Text=""></asp:Label>
                 &emsp;
                <asp:Label ID="L4" runat="server" Text=""></asp:Label>
                 &emsp;
                <asp:Label ID="L5" runat="server" Text=""></asp:Label>
                 &emsp;
                <asp:Label ID="L6" runat="server" Text=""></asp:Label>
                 &emsp;
                <asp:Label ID="L7" runat="server" Text=""></asp:Label>
                 &emsp;
                <asp:Label ID="L8" runat="server" Text=""></asp:Label>
                 &emsp;
                <asp:Label ID="L9" runat="server" Text=""></asp:Label>
          </td>
        </tr>
    </table>
    <br />
    <br />


</asp:Content>
