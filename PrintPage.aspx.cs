using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student
{
    public partial class PrintPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> mySession = (List<string>)Session["SelectedRow"];

            idLabel.Text = mySession[0];
            codeLabel.Text = mySession[1];
            nameLabel.Text = mySession[2];
            addressLabel.Text = mySession[3];
            emailLabel.Text = mySession[4];
            mobileLabel.Text = mySession[5];
            joinLabel.Text = mySession[6];

        }
    }
}