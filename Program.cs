using System;

namespace customColorsAndSounds {
    class Program {
        static void Main (string[] args) {
            // Create an instance of each vehicle.
            Zero zero = new Zero ();
            zero.MainColor = "red";
            zero.MaximumOccupancy = "2";

            Cessna cessna = new Cessna ();
            cessna.MainColor = "blue";
            cessna.MaximumOccupancy = "3";

            Tesla tesla = new Tesla ();
            tesla.MainColor = "red";
            tesla.MaximumOccupancy = "4";

            Ram ram = new Ram ();
            ram.MainColor = "black";
            ram.MaximumOccupancy = "6";

            zero.Drive ();
            ram.Drive ();
            tesla.Drive ();
            cessna.Drive ();

            zero.Turn ();
            zero.Stop ();
            ram.Turn ();
            ram.Stop ();
            tesla.Turn ();
            tesla.Stop ();
            cessna.Turn ();
            cessna.Stop ();
        }

    }

}
// 1 Move all common properties in your vehicles to a new Vehicle class.
// 2 Create an instance of each vehicle.
// 3 Define a different value for each vehicle's properties.
// 4 Create a Drive() method in the Vehicle class.
// 5 Override the Drive() method in all the other vehicle classes. Include the
// 6 Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.
// 7 Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."
// 8 Make your vehicle instances perform all three behaviors.