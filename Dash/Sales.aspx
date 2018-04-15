<%@ Page Title="" Language="C#" MasterPageFile="~/Dash.Master" AutoEventWireup="true" CodeBehind="Sales.aspx.cs" Inherits="Dash.Sales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div id="sales-page">
    <asp:Literal ID="_literSalesChart" runat="server"></asp:Literal>
  </div>
</asp:Content>
