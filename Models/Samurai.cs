using System;

namespace WizardNS.Models {
    public class Samurai : Human {
        public Samurai (string name) : base (name, 3, 3, 3, 200) {

        }
        public override int Attack (Human target) {
            int dmg = 0;
            if (target.Health < 50) {
                dmg = target.Health;
            }
            target.TakeDmg(dmg);
            Console.WriteLine ($"{Name} attacked {target.Name} for {dmg} damage!");
            // health+=dmg;
            return target.Health;
        }
        public int Meditate(){
            health = 200;
            return health;
        }
    }
}