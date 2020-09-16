using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using System.Configuration;

namespace _4tavjezba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int counter = 0;
        int bodovi = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["counter"] = ((int)Session["counter"]);
            if (Session["counter"] != null)
            {
                counter = (int)Session["counter"];
            }
            else
            {
                counter = 0;
            }

            if (Session["bodovi"] != null)
            {
                bodovi = (int)Session["bodovi"];
            }
            else
            {
                bodovi = 0;
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Session["counter"] = counter;
            Session["bodovi"] = bodovi;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button1.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button1.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button1.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button2.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button2.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button2.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button3.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button3.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button3.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button4.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button4.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button4.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button5.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button5.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button5.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button6.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button6.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button6.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button7.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button7.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button7.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button8.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button8.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button8.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //Check who's turn it is
            if (counter == 0)
            {
                Button9.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                Button9.Text = "O";
                counter--;
            }
            //Disable button so it cannot be changed
            Button9.Enabled = false;
            bodovi++;
            //Check if anyone won, lose, tie
            check();
        }
        void check()
        {
            //Check if tie
            if (Button1.Text != "" && Button2.Text != "" && Button3.Text != "" &&
                Button4.Text != "" && Button5.Text != "" && Button6.Text != "" &&
                Button7.Text != "" && Button8.Text != "" && Button9.Text != "")
            {
                textBox1.Text = "Tied";
            }

            //Check diagonal for X
            if (Button1.Text == "X" && Button5.Text == "X" && Button9.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button3.Text == "X" && Button5.Text == "X" && Button7.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            //Check rows for X
            if (Button1.Text == "X" && Button2.Text == "X" && Button3.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button4.Text == "X" && Button5.Text == "X" && Button6.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button7.Text == "X" && Button8.Text == "X" && Button9.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            //Check columns for X
            if (Button1.Text == "X" && Button4.Text == "X" && Button7.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button2.Text == "X" && Button5.Text == "X" && Button8.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button3.Text == "X" && Button6.Text == "X" && Button9.Text == "X")
            {
                textBox1.Text = "Player X wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }

            //Check diagonal for O
            if (Button1.Text == "O" && Button5.Text == "O" && Button9.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button3.Text == "O" && Button5.Text == "O" && Button7.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            //Check rows for O
            if (Button1.Text == "O" && Button2.Text == "O" && Button3.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button4.Text == "O" && Button5.Text == "O" && Button6.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button7.Text == "O" && Button8.Text == "O" && Button9.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            //Check columns for O
            if (Button1.Text == "O" && Button4.Text == "O" && Button7.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button2.Text == "O" && Button5.Text == "O" && Button8.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }
            if (Button3.Text == "O" && Button6.Text == "O" && Button9.Text == "O")
            {
                textBox1.Text = "Player O wins";
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false;
                Button7.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
            }

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Button1.Text = "";
            Button1.Enabled = true;
            Button2.Text = "";
            Button2.Enabled = true;
            Button3.Text = "";
            Button3.Enabled = true;
            Button4.Text = "";
            Button4.Enabled = true;
            Button5.Text = "";
            Button5.Enabled = true;
            Button6.Text = "";
            Button6.Enabled = true;
            Button7.Text = "";
            Button7.Enabled = true;
            Button8.Text = "";
            Button8.Enabled = true;
            Button9.Text = "";
            Button9.Enabled = true;
            textBox1.Text = "";
            TextBoxPlayerX.Text = "Player X";
            TextBoxPlayerY.Text = "Player Y";

            counter = 0;
            bodovi = 0;
        }

        protected void FormView2_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void Button11_Click1(object sender, EventArgs e)
        {
            OleDbConnection konekcija = new OleDbConnection(ConfigurationManager.ConnectionStrings["KonekcijaNaBazu"].ConnectionString);

            if (textBox1.Text == "Player X wins")
            {
                OleDbCommand naredba = new OleDbCommand("INSERT INTO studenti ( Name, Score)Values( @imex , @bodovi)", konekcija);
                naredba.Parameters.AddWithValue("@imex", TextBoxPlayerX.Text);
                naredba.Parameters.AddWithValue("@bodovi", 10 - bodovi);
                konekcija.Open();

                naredba.ExecuteNonQuery();

                konekcija.Close();
                
            }
            else if (textBox1.Text == "Player O wins")
            {
                OleDbCommand naredba = new OleDbCommand("INSERT INTO studenti ( Name, Score) Values( @imey , @bodovi)", konekcija);
                naredba.Parameters.AddWithValue("@imey", TextBoxPlayerY.Text);
                naredba.Parameters.AddWithValue("@bodovi", 10 - bodovi);
                konekcija.Open();

                naredba.ExecuteNonQuery();

                konekcija.Close();
            }

            this.GridView1.DataBind();

        }
    }

}