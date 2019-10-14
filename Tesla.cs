using System;

namespace customColorsAndSounds {
    public class Tesla : Vehicle {
         public override void Drive () {
            Console.WriteLine ($"The {MainColor} tesla goes vroom!");
        }
        public override void Turn () {
            Console.Write ($"Tesla turns wide");
        }
        public override void Stop () {
            Console.WriteLine ($" and stops frequently");
        }

    }
}