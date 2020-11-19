using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUERYSTRInG_aSSiGnmeNT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string frstname = Request.QueryString["frstname"];
            string lastname = Request.QueryString["lastname"];
            Label1.Text = "WELCOME" + frstname + "" + lastname;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HOMEPAGE.aspx?frstname=" + TextBox1.Text + "&lastname=" + TextBox2.Text);
        }
    }
}