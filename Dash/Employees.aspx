<%@ Page Title="" Language="C#" MasterPageFile="~/Dash.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Dash.Employees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div id="employees-page">
  <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" DataSourceID="DashDBDataSource" InsertItemPosition="LastItem">
  <AlternatingItemTemplate>
    <tr style="">
      <td>
        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
      </td>
      <td>
        <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
      </td>
      <td>
        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
      </td>
      <td>
        <asp:Label ID="PositionLabel" runat="server" Text='<%# Eval("Position") %>' />
      </td>
      <td>
        <asp:Label ID="HiredDateLabel" runat="server" Text='<%# Eval("HiredDate") %>' />
      </td>
      <td>
        <asp:Label ID="SalaryLabel" runat="server" Text='<%# Eval("Salary") %>' />
      </td>
      <td>
        <asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
      </td>
      <td>
        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
      </td>
    </tr>
  </AlternatingItemTemplate>
  <EditItemTemplate>
    <tr style="">
      <td>
        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
      </td>
      <td>
        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
      </td>
      <td>
        <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
      </td>
      <td>
        <asp:TextBox ID="PositionTextBox" runat="server" Text='<%# Bind("Position") %>' />
      </td>
      <td>
        <asp:TextBox ID="HiredDateTextBox" runat="server" Text='<%# Bind("HiredDate") %>' />
      </td>
      <td>
        <asp:TextBox ID="SalaryTextBox" runat="server" Text='<%# Bind("Salary") %>' />
      </td>
      <td>
        <asp:TextBox ID="DepartmentTextBox" runat="server" Text='<%# Bind("Department") %>' />
      </td>
      <td>
        <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
      </td>
    </tr>
  </EditItemTemplate>
  <EmptyDataTemplate>
    <table runat="server" style="">
      <tr>
        <td>No data was returned.</td>
      </tr>
    </table>
  </EmptyDataTemplate>
  <InsertItemTemplate>
    <tr style="">
      <td>
        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
      </td>
      <td>
        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
      </td>
      <td>
        <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
      </td>
      <td>
        <asp:TextBox ID="PositionTextBox" runat="server" Text='<%# Bind("Position") %>' />
      </td>
      <td>
        <asp:TextBox ID="HiredDateTextBox" runat="server" Text='<%# Bind("HiredDate") %>' />
      </td>
      <td>
        <asp:TextBox ID="SalaryTextBox" runat="server" Text='<%# Bind("Salary") %>' />
      </td>
      <td>
        <asp:TextBox ID="DepartmentTextBox" runat="server" Text='<%# Bind("Department") %>' />
      </td>
      <td>&nbsp;</td>
    </tr>
  </InsertItemTemplate>
  <ItemTemplate>
    <tr style="">
      <td>
        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
      </td>
      <td>
        <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
      </td>
      <td>
        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
      </td>
      <td>
        <asp:Label ID="PositionLabel" runat="server" Text='<%# Eval("Position") %>' />
      </td>
      <td>
        <asp:Label ID="HiredDateLabel" runat="server" Text='<%# Eval("HiredDate") %>' />
      </td>
      <td>
        <asp:Label ID="SalaryLabel" runat="server" Text='<%# Eval("Salary") %>' />
      </td>
      <td>
        <asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
      </td>
      <td>
        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
      </td>
    </tr>
  </ItemTemplate>
  <LayoutTemplate>
    <table runat="server">
      <tr runat="server">
        <td runat="server">
          <table id="itemPlaceholderContainer" runat="server" border="0" style="">
            <tr runat="server" style="">
              <th runat="server"></th>
              <th runat="server">FirstName</th>
              <th runat="server">LastName</th>
              <th runat="server">Position</th>
              <th runat="server">HiredDate</th>
              <th runat="server">Salary</th>
              <th runat="server">Department</th>
              <th runat="server">Id</th>
            </tr>
            <tr id="itemPlaceholder" runat="server">
            </tr>
          </table>
        </td>
      </tr>
      <tr runat="server">
        <td runat="server" style="">
          <asp:DataPager ID="DataPager1" runat="server">
            <Fields>
              <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
            </Fields>
          </asp:DataPager>
        </td>
      </tr>
    </table>
  </LayoutTemplate>
  <SelectedItemTemplate>
    <tr style="">
      <td>
        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
      </td>
      <td>
        <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
      </td>
      <td>
        <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
      </td>
      <td>
        <asp:Label ID="PositionLabel" runat="server" Text='<%# Eval("Position") %>' />
      </td>
      <td>
        <asp:Label ID="HiredDateLabel" runat="server" Text='<%# Eval("HiredDate") %>' />
      </td>
      <td>
        <asp:Label ID="SalaryLabel" runat="server" Text='<%# Eval("Salary") %>' />
      </td>
      <td>
        <asp:Label ID="DepartmentLabel" runat="server" Text='<%# Eval("Department") %>' />
      </td>
      <td>
        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
      </td>
    </tr>
  </SelectedItemTemplate>
</asp:ListView>
<asp:SqlDataSource ID="DashDBDataSource" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:DashDBConnectionString %>" DeleteCommand="DELETE FROM [Employee] WHERE [Id] = @original_Id AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [Position] = @original_Position AND [HiredDate] = @original_HiredDate AND [Salary] = @original_Salary AND [Department] = @original_Department" InsertCommand="INSERT INTO [Employee] ([FirstName], [LastName], [Position], [HiredDate], [Salary], [Department]) VALUES (@FirstName, @LastName, @Position, @HiredDate, @Salary, @Department)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [FirstName], [LastName], [Position], [HiredDate], [Salary], [Department], [Id] FROM [Employee]" UpdateCommand="UPDATE [Employee] SET [FirstName] = @FirstName, [LastName] = @LastName, [Position] = @Position, [HiredDate] = @HiredDate, [Salary] = @Salary, [Department] = @Department WHERE [Id] = @original_Id AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [Position] = @original_Position AND [HiredDate] = @original_HiredDate AND [Salary] = @original_Salary AND [Department] = @original_Department">
  <DeleteParameters>
    <asp:Parameter Name="original_Id" Type="Int32" />
    <asp:Parameter Name="original_FirstName" Type="String" />
    <asp:Parameter Name="original_LastName" Type="String" />
    <asp:Parameter Name="original_Position" Type="String" />
    <asp:Parameter DbType="Date" Name="original_HiredDate" />
    <asp:Parameter Name="original_Salary" Type="Int32" />
    <asp:Parameter Name="original_Department" Type="String" />
  </DeleteParameters>
  <InsertParameters>
    <asp:Parameter Name="FirstName" Type="String" />
    <asp:Parameter Name="LastName" Type="String" />
    <asp:Parameter Name="Position" Type="String" />
    <asp:Parameter DbType="Date" Name="HiredDate" />
    <asp:Parameter Name="Salary" Type="Int32" />
    <asp:Parameter Name="Department" Type="String" />
  </InsertParameters>
  <UpdateParameters>
    <asp:Parameter Name="FirstName" Type="String" />
    <asp:Parameter Name="LastName" Type="String" />
    <asp:Parameter Name="Position" Type="String" />
    <asp:Parameter DbType="Date" Name="HiredDate" />
    <asp:Parameter Name="Salary" Type="Int32" />
    <asp:Parameter Name="Department" Type="String" />
    <asp:Parameter Name="original_Id" Type="Int32" />
    <asp:Parameter Name="original_FirstName" Type="String" />
    <asp:Parameter Name="original_LastName" Type="String" />
    <asp:Parameter Name="original_Position" Type="String" />
    <asp:Parameter DbType="Date" Name="original_HiredDate" />
    <asp:Parameter Name="original_Salary" Type="Int32" />
    <asp:Parameter Name="original_Department" Type="String" />
  </UpdateParameters>
</asp:SqlDataSource>
&nbsp;
</div>
</asp:Content>
