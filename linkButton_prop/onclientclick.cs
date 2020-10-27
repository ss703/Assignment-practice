using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_linkbutton_web_app_assignment1
{
    public partial class Linkbutton1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButtton1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Welcome to the facebook";
        }
    }
}