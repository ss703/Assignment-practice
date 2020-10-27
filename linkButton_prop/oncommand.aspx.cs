using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_Linkbutton_web_app_assignment2
{
    public partial class Linkbutton2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

       
        protected void link1_Click(object sender, EventArgs e)
        {
            label1.Text = "You chose" + e.CommandName + "Item" + e.CommandArgument;
        }
    }
}