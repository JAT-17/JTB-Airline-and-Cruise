<%@ Page Title="Results" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FlightResults.aspx.cs" Inherits="JTB_Airline_and_Cruise.FlightResults" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField=" <%--flight ID--%> " Height="293px" Width="310px" RepeatColumns="3" RepeatDirection="Vertical" OnItemCommand="DataList1_ItemCommand">
     <ItemTemplate>
   <table ID="tID" runat="server">
       <tr>
           <td>
             <%--  <asp:Label ID="Label1" runat="server" Text='<%# Eval("Airline") %>' Font-Bold="True" 
                   Font-Names="Arial" ForeColor="White" Style="text-align:center"></asp:Label>--%>
           </td>
       </tr>
       
       <tr>
           <td>
               
            <%--   BOOK BUTTON GO HERE--%> 
              
           </td>
       </tr>
   </table>

     </ItemTemplate>
    </asp:DataList>
</asp:Content>

