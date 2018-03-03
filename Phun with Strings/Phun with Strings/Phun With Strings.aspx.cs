using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phun_with_Strings
{
    public partial class Phun_With_Strings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Bob Tabor";
            string nameReverse = "";
            int j = name.Length - 1;
            for (int i = 0; i < name.Length; i++)
            {
                nameReverse += name[j].ToString();
                j--;  
            }
            reverseName.Text = String.Format("The Name {0} backwards is {1}", name, nameReverse);


            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            var rName = string.Join(" , ", names.Split(',').Reverse());
            reverseNames.Text = names + " in reverse (with spaces) is " + rName.ToString() + ".";



            // 3. Use the sequence to create ascii art:
            //14 char
            // *****luke*****
            // *****leia*****
            // *****han******
            // **chewbacca***
            string result = "";
            string[] anames = names.Split(',');
            for (int i = 0; i < anames.Length; i++)
            {
                int total = (14-anames[i].Length)/2;
                int left= total+anames[i].Length;
   // If I wanted more ascii on left than right when odd amount of characters in word
               /* if ((total%2) == 0)
                {
                    left++;
                } */
                string pLeft = anames[i].PadLeft(left,'*');
                
                result += pLeft.PadRight(14,'*') + "<br />";
            }

            artLabel.Text = "Those same words with ascii art are;" + "<br />" + result;



            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            removeMe.Text = "Before the fix is: " + puzzle + "<br />" + "After: ";
            puzzle = puzzle.Replace("remove-me", "").Replace("Z", "T");
            removeMe.Text += char.ToUpper(puzzle[0]).ToString() + puzzle.Substring(1).ToLower();

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
        }
    }
}