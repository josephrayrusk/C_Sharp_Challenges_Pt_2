using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HeroMonsterClasses
{
    public partial class HeroMonster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Hero does more damage, but monster has chance to deal bonus damage
            Character hero = new Character();
            hero.Name = "Batman";
            hero.Health = 30;
            hero.DamageMax = 20;
            hero.AttackBonus = false;

            Character monster = new Character();
            monster.Name = "Joker";
            monster.Health = 30;
            monster.DamageMax = 12;
            monster.AttackBonus = true;

            Dice dice = new Dice();

            if (hero.AttackBonus)
            {
                monster.Defend(hero.Attack(dice));
            }
            if (monster.AttackBonus)
            {
                hero.Defend(monster.Attack(dice));
            }
            // loop until one dies
            while (hero.Health > 0 && monster.Health > 0)
            {
                monster.Defend(hero.Attack(dice));
                hero.Defend(monster.Attack(dice));
                printStats(hero);
                printStats(monster);
            }
            displayResult(hero, monster);
        }

        // Show who won
        private void printStats(Character character)
        {
            labelResult.Text += String.Format("Name: {0} - Health: {1} - AttackBonus: {2}<p />", character.Name, character.Health, character.AttackBonus.ToString());
        }

        // Show the battle
        private void displayResult(Character opponent1, Character opponent2)
        {
            if (opponent1.Health <= 0 & opponent2.Health <= 0)
                labelResult.Text += String.Format("Both {0} and {1} died.", opponent1.Name, opponent2.Name);
            else if (opponent1.Health <= 0)
                labelResult.Text += String.Format("{0} Died and {1} won.", opponent1.Name, opponent2.Name);
            else if (opponent2.Health <= 0)
                labelResult.Text += String.Format("{1} Died and {0} won.", opponent1.Name, opponent2.Name);
        }

    }
    // Random Value with max being the max damage value
    class Dice
    {
        public int Sides { get; set; }
        Random rnd = new Random();
        public int Roll()
        {
            return rnd.Next(this.Sides);
        }
    }
    //Hero and Villian Class
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMax { get; set; }
        public bool AttackBonus { get; set; }

        // Attack Value
        public int Attack(Dice dice)
        {
        dice.Sides = this.DamageMax;
            return dice.Roll();
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
 
    }
}