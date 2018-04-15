<%@ Page Title="" Language="C#" MasterPageFile="~/Dash.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Dash.Department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div id="department-page">
    <asp:Literal ID="_literDepartmentChart" runat="server"></asp:Literal>
    <asp:Literal ID="_literDepartmentChart2" runat="server"></asp:Literal>
  </div>
</asp:Content>
