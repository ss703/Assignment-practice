using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TICKET_PROJECT
{
    public partial class Ticket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            con.Open();
            var insertQuery = "insert into Flight1(ID,Name,Password,Age,Gender)values(@ID,@Name,@Password,@Age,@Gender)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            string gender = string.Empty;
            if (RadioButton1.Checked)
            {
                gender = "male";
            }
            else if (RadioButton2.Checked)
            {
                gender = "female";
            }

            cmd.Parameters.AddWithValue("@ID", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Age", TextBox4.Text);

            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.ExecuteNonQuery();
            Response.Write("Registered Succesfully!!");
            con.Close();
        }
    }
}