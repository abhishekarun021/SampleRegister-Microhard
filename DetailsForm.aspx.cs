using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Student
{
    public partial class DetailsForm : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid_Bind();
            }
        }

        public void Grid_Bind()
        {
            string sel = "select * from Student_tbl";
            DataSet ds = obj.Fn_DataSet(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int usrid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Student_tbl where Student_id=" + usrid + "";
            int a = obj.Fn_NonQuery(del);

            Grid_Bind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Grid_Bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Grid_Bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int usrid = Convert.ToInt32(GridView1.DataKeys[i].Value);

            TextBox txtcode = (TextBox)GridView1.Rows[i].Cells[1].Controls[0];
            TextBox txtname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
            TextBox txtaddr = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
            TextBox txtmail = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            TextBox txtphone = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];

            string upd = "update Student_tbl set Student_code='"+txtcode.Text+"' ,Student_Name='" + txtname.Text + "',Student_Address='" + txtaddr.Text + "',Email='"+txtmail.Text+"',Mobile_Number="+txtphone.Text+" where Student_id=" + usrid + "";
            int b = obj.Fn_NonQuery(upd);

            GridView1.EditIndex = -1;
            Grid_Bind();
        }
    }
}