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
    public partial class MainAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOfUsers.aspx");
        }

        
        

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightDetails.aspx");
        }
    }
}