using System;

namespace customColorsAndSounds {
    public class Zero : Vehicle {
        public double BatteryKWh { get; set; }
        public void ChargeBattery () {
            Console.WriteLine ($"Your tesla is charged to {BatteryKWh} KWh");
        }
        public override void Drive () {
            Console.WriteLine ($"The {MainColor} zero goes put put!");
        }
        public override void Turn () {
            Console.Write ("Zero makes a uturn");
        }
        public override void Stop () {
            Console.WriteLine (" and comes to a screaching halt");
        }
    }

}