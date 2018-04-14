<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Dash.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      .container {
        margin-top: 20%;
        width: 100%;
        display: flex;
        justify-content: center;
      }

      .lbl {
        display: inline-block;
        width: 90px;
      }

      .row {
        margin: 1em;
      }

      .l-center {
        margin-left: 1em;
      }
      .auto-style1 {
        margin-top: 20%;
        width: 100%;
        display: flex;
        justify-content: center;
        height: 340px;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
          <div>
            <div class="row">
              <span class="lbl">
                <asp:Label ID="Label1" runat="server" Text="Admin ID"></asp:Label>
              </span>
              <asp:TextBox ID="_txtAdminID" runat="server"></asp:TextBox>
            </div>
            <div class="row">
              <span class="lbl">Password</span>
              <asp:TextBox ID="_txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <br />
            <br />
            <span class="l-center">
              <asp:Button ID="_btnLogIn" runat="server" Height="37px" Text="Log In" Width="272px" OnClick="_btnLogIn_Click" />
            <br />
            <br />
            <asp:Label ID="_lblLoginError" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="_txtAdminID" ErrorMessage="Admin ID must be required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="_txtPassword" ErrorMessage="Password must be required" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </span>
          </div>
        </div>
    </form>
</body>
</html>
