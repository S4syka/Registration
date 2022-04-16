using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBToWebConnection;

namespace Registration {
  public partial class MainPage : System.Web.UI.Page {
    private DBConnection _connection;

    protected void Page_Load(object sender, EventArgs e) {
      _connection = new DBConnection(@"Server=DESKTOP-VA1J6KR\MSSQLSERVER2;Database=RegistrationInfoDB;Trusted_Connection=True;");
    }

    protected void btnRegister_Click(object sender, EventArgs e) {
      if (!_connection.IsRegistered(txtUserName.Text, txtPassword.Text)) {
        _connection.Register(txtUserName.Text, txtPassword.Text);
        Response.Redirect("SuccessfullyRegistered.aspx");
      }
      else
        Response.Redirect("unsuccessfullyRegistered.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e) {
      if (_connection.IsRegistered(txtUserName.Text, txtPassword.Text))
        Response.Redirect("SuccesfullLoginPage.aspx");
      else
        Response.Redirect("UnsuccessfullLoginPage.aspx");
    }
  }
}