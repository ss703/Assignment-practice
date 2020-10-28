using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_dropdown_web_app
{
    public partial class dropdown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList.SelectedValue=="")
            {
                Label1.Text = "please select a city";
            }
            else
            {
                Label1.Text = "your choice is" + DropDownList.SelectedValue;
            }
        }
    }
}