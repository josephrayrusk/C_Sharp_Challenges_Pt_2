using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void widthText_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void groundButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCost();
        }

        protected void airButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCost();
        }

        protected void nextDayButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateCost();
        }

        protected void heightText_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void lengthText_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void calculateCost()
        {         
            if (!String.IsNullOrEmpty(widthText.Text) && !String.IsNullOrEmpty(heightText.Text))
            {
                double width;
                double height;
                double length;

                Double.TryParse(widthText.Text, out width);
                Double.TryParse(heightText.Text, out height);
                if (!Double.TryParse(lengthText.Text, out length))
                    length = 1;
                 
                
                double cost= 0.00;
                double size = width * height * length;
                    if (groundButton.Checked) cost = size * 0.15;
                    else if (airButton.Checked) cost = size * 0.25;
                    else if (nextDayButton.Checked) cost = size * 0.45;

                resultLabel.Text = "Total Cost is " + cost.ToString("C");
            }
            else resultLabel.Text = "Please enter Width and Height.";
        }
    }


}