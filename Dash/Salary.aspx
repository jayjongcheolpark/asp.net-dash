<%@ Page Title="" Language="C#" MasterPageFile="~/Dash.Master" AutoEventWireup="true" CodeBehind="Salary.aspx.cs" Inherits="Dash.Salary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div id="salary-page">
    <asp:Literal ID="_literSalaryChart" runat="server"></asp:Literal>
    <asp:Literal ID="_literSalaryChart2" runat="server"></asp:Literal>
  </div>
</asp:Content>
