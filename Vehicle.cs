using System;

namespace customColorsAndSounds {
    public class Vehicle {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive () {
            Console.WriteLine ("Vrooom!");
        }
        public virtual void Turn () {
            Console.WriteLine ("left");
        }
        public virtual void Stop () {
            Console.WriteLine ("Skids");
        }

    }
}