using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=localhost;user id=root;database=programmingdb;persistsecurityinfo=True");
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into studentinfo_Tab values('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+DropDownList1.SelectedValue+"','"+float.Parse(TextBox3.Text)+"','"+TextBox4.Text+"')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully Inserted');", true);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}