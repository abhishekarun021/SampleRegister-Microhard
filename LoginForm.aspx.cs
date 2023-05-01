using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student
{
    public partial class LoginForm : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string cid = obj.Fn_Scalar("select count(Id) from usertab where Username='" + unaTextBox.Text + "' and Password='" + pwdTextBox.Text + "'");

            if (cid == "1")
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                msgLabel.Text = "Invalid Credentials";
            }
        }
    }
}