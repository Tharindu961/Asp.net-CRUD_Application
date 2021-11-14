using System;
using System.Collections.Generic;
using System.Data;
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
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        SqlConnection con = new SqlConnection("server=localhost;user id=root;database=programmingdb;persistsecurityinfo=True");
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into Sudentinfo_Tab values('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+DropDownList1.SelectedValue+"','"+double.Parse(TextBox3.Text)+"','"+TextBox4.Text+"')", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully Inserted');", true);
            LoadRecord();

        }

        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("Select * from Sudentinfo_Tab", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand comm = new SqlCommand("Update Sudentinfo_Tab set StudentName = '"+ TextBox2.Text +"', Address = '"+ DropDownList1.SelectedValue +"', Age = '"+ double.Parse(TextBox3.Text) + "', Contact = '" + TextBox4.Text + "' Where StudentID = '"+ int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully Updated');", true);
            LoadRecord();

        }
        protected void Button3_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand comm = new SqlCommand("Delete Sudentinfo_Tab Where StudentID = '" + int.Parse(TextBox1.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Sucessfully Deleted');", true);
            LoadRecord();

        }
        protected void Button4_Click(object sender, EventArgs e)
        {

            SqlCommand comm = new SqlCommand("Select * from Sudentinfo_Tab Where StudentID = '" + int.Parse(TextBox1.Text) + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}