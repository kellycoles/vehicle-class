using System;

namespace customColorsAndSounds {
    public class Ram : Vehicle {

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} ram goes rrmmmbbbum!");
        }
        public override void Turn () {
            Console.Write ($"The ram turns gracefully");
        }
        public override void Stop () {
            Console.WriteLine ($" and doesn't stop");
        }
    }
}