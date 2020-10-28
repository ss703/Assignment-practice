using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_cookies_assigment
{
    public partial class Cookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cokie = new HttpCookie("student");
            HttpCookie cokies = new HttpCookie("students");

            cokie.Value = "Ss";
            cokies.Value = "sou";
         
            Response.Cookies.Add(cokie);
            Response.Cookies.Add(cokies);

            var co_val = Response.Cookies["student"].Value;
            Label1.Text = co_val;
            var co_vals = Response.Cookies["students"].Value;
            Label1.Text = co_vals;
        }
    }
}