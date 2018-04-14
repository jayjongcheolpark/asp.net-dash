using Dash.AdminDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dash
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void _btnLogIn_Click(object sender, EventArgs e)
    {
      AdminDataSet admindataset = new AdminDataSet();

      AdminTableAdapter adminTableAdapter = new AdminTableAdapter();

      adminTableAdapter.Fill(admindataset.Admin);

      string username = admindataset.Admin[0].Username;
      string password = admindataset.Admin[0].Password;

      if (username.Equals(_txtAdminID.Text) && password.Equals(_txtPassword.Text))
      {
        Session["auth"] = username;
        Response.Redirect("Employees.aspx");
      } 
      else
      {
        Session["auth"] = null;
        _lblLoginError.Text = "Username or Password is invalid";
      }
    }
  }
}