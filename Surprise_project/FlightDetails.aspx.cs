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
    public partial class FlightDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            con.Open();
            var insertQuery = "insert into FlightDe(FlightID,FlightNumber,FlightName,Source,Destination)values(@FlightID,@FlightNumber,@FlightName,@Source,@Destination)";
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            
            

            cmd.Parameters.AddWithValue("@FlightID", TextBox1.Text);
            cmd.Parameters.AddWithValue("@FlightNumber", TextBox2.Text);
            cmd.Parameters.AddWithValue("@FlightName", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Source", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Destination", TextBox5.Text);

            
            cmd.ExecuteNonQuery();
            Response.Write("Flight Details Added");
            con.Close();
        }
    }
}