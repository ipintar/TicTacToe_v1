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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginuser_Authenticate(object sender, AuthenticateEventArgs e)
        {
            OleDbConnection konekcija = new OleDbConnection(ConfigurationManager.ConnectionStrings["KonekcijaNaBazu"].ConnectionString);
            try
            {
                konekcija.Open();
                OleDbCommand naredba = new OleDbCommand("SELECT username FROM users WHERE username= @ime AND password= @lozinka", konekcija); 
                naredba.Parameters.AddWithValue("@ime", this.loginuser.UserName);
                naredba.Parameters.AddWithValue("@lozinka", this.loginuser.Password);
                OleDbDataReader podaci = naredba.ExecuteReader();
                podaci.Read(); 
                if (podaci.HasRows == true)
                {
                    e.Authenticated = true;
                }
                else
                {
                    e.Authenticated = false;
                }
            }
            catch (Exception ex)
            {
                e.Authenticated = false;
                Response.Write(ex.Message);

            }
            finally
            {
                konekcija.Close();
            }
        }
    }
}