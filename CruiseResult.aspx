<%@ Page Title="Result" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CruiseResult.aspx.cs" Inherits="JTB_Airline_and_Cruise.CruiseResult" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

<div>
    <asp:GridView class="table table-striped table-bordered" ID="GridView3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
        <Columns>
            <asp:CommandField SelectText="BOOK CRUISE" ShowSelectButton="True">
            <ItemStyle ForeColor="#0B610B" />
            </asp:CommandField>
        </Columns>

    </asp:GridView>
    </div>
    <br /><br /><br /><br />
    <div> 
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
          </td>
        </tr>
    </table>
    </div>
     
    <br />

</asp:Content>

