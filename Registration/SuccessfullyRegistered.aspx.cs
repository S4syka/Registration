using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration {
  public partial class SuccessfullyRegistered : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void btnGoBack_Click(object sender, EventArgs e) {
      Response.Redirect("MainPage.aspx");
    }
  }
}