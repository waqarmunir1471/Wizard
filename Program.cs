using System;
using WizardNS.Models;
namespace WizardNS {
    class Program {
        static void Main (string[] args) {
            Wizard w1 = new Wizard ("Vicky");
            Ninja n1 = new Ninja ("Ninja");
            Console.WriteLine ("Healed" + w1.Heal (n1));
            Samurai s1 = new Samurai ("Samurai");
            Console.WriteLine ("N1 Attack S1: " + n1.Attack (s1));
            Console.WriteLine ("S1 Meditates : " + s1.Meditate ());
            Console.WriteLine ("N1 Steal from S1: " + n1.Steal (s1));
            Console.WriteLine ("S1 healther" + s1.Health);
        }
    }
}