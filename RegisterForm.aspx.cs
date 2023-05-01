using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            int i = obj.Fn_NonQuery("insert into Student_tbl values('" + codeTextBox.Text + "','" + nameTextBox.Text + "','" + addressTextBox.Text + "','" + emailTextBox.Text + "'," + mobileTextBox.Text + ",'" + joinTextBox.Text + "')");

            if (i != 0)
            {
                msgLabel.Text = "Inserted Successfully";
            }
        }
    }
}