using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace RepeaterEmployeee
{
    public partial class Employe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["empConnectionString"].ConnectionString);
        con.Open();
            
            //    if (!IsPostBack)
            //    {
            //        Bind();
            //    }
            //}


            //public void Bind()
            //{
                SqlCommand cmd = new SqlCommand("select * from employ where EmpId = 1200", con);
            SqlDataReader rd = cmd.ExecuteReader();

            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //  DataSet ds = new DataSet();
            //   da.Fill(ds, "Employee");
            rp1.DataSource = rd;

                rp1.DataBind();
            con.Close();

            }
        }
    }
