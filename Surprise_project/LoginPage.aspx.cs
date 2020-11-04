using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace TICKET_PROJECT
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Flight1 WHERE Name=@Name AND Password=@Password", con);





            cmd.Parameters.AddWithValue("@Name", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox4.Text);

            //SqlDataReader rd = cmd.ExecuteReader();
            //if(rd.HasRows)
            //{
            //    Label2.Text = "login successful";

            //}
            //else
            //{
            //    Label2.Text="invalid username or password";
            //}
            cmd.Connection = con;
            int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
            if (OBJ > 0)
            {
                Session["Name"] = TextBox3.Text;
                Response.Redirect("FlightBooking.aspx");
            }
            else
            {
                Label2.Text = "Invalid username or password";
               // this.Label2.ForeColor = Color.Red;
            }
          //  Response.Redirect("FlightBooking.aspx");

           



            
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightTicketBooking.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ticket.aspx");
        }
    }
}