using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;

namespace _4tavjezba
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.User.Identity.IsAuthenticated == false)
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void SqlDataSourceStudenti_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridViewStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridViewStudenti_RowDataBound(object sender, GridViewRowEventArgs e)
        {


        }

        protected void Delete(object sender, EventArgs e)
        {
            OleDbConnection konekcija = new OleDbConnection(ConfigurationManager.ConnectionStrings["KonekcijaNaBazu"].ConnectionString);

            OleDbCommand naredba = new OleDbCommand("DELETE FROM studenti", konekcija);

            konekcija.Open();

            naredba.ExecuteNonQuery();

            konekcija.Close();
            this.GridView1.DataBind();
        }


    }
}