using System;

namespace customColorsAndSounds {
    public class Cessna : Vehicle {
        public double FuelCapacity { get; set; }

        public void RefuelTank () { }

        public override void Drive () {
            Console.WriteLine ($"The {MainColor} cessna goes rum!");
        }
        public override void Turn () {
            Console.Write ($"Cessna turns without a blinker");
        }
        public override void Stop () {
            Console.WriteLine ($" and comes to a dead stop");
        }
    }
}
