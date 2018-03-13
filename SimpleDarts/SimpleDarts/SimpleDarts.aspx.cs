using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Darts;

namespace SimpleDarts
{
    public partial class SimpleDarts : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(p1.Text) && !String.IsNullOrEmpty(p2.Text))
            {
                Game game = new Game(p1.Text.ToString(), p2.Text.ToString());
                string result = game.Play();
                resultLabel.Text = result;
            }
            else resultLabel.Text = "Please enter player names!";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void p2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}