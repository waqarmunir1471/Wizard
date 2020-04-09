using System;

namespace WizardNS.Models
{
    public class Ninja:Human
    {
        public Ninja(string name):base(name,3,3,175,3)
        {

        }
        public override int Attack(Human target){
            int dmg= Dexterity * 5;
            Random rand = new Random();
            if(rand.Next(5)>3){
                dmg+=10;
            }
            target.TakeDmg(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            // health+=dmg;
            return target.Health;
        }
        public int Steal(Human target){
            int steal =  5;
            target.TakeDmg(steal);
            this.health += steal;
            return this.health;
        }
    }
}