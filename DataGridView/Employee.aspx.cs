using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace asp_datagridview_web_app
{
    public partial class DataGridView1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("server=IN-PG00N522\\SQLEXPRESS; Database=dxc; integrated security=SSPI"))
            {
                SqlDataAdapter ada = new SqlDataAdapter("select * from employ",con);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();



            }
            
          

        }
    }
}