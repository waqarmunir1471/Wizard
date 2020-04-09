using System;

namespace WizardNS.Models
{
    public class Wizard : Human
    {
        public Wizard(string name):base(name,3,25,3,50)
        {
        }
        public override int Attack(Human target){
            int dmg= Intelligence * 5;
            target.TakeDmg(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            health+=dmg;
            return target.Health;
        }
        public int Heal(Human target){
            int heal = Intelligence *10;
            target.GetHeal(heal);
            return target.Health;
        }
    }
}