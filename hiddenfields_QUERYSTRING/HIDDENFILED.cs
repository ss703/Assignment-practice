using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hiddenfileds
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenField1.Value = DateTime.Now.ToString();
            lblcurrentdatetime.Text = Convert.ToString(HiddenField1.Value);
        }
    }
}