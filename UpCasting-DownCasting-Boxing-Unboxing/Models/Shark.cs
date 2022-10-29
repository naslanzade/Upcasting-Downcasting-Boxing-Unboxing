using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_DownCasting_Boxing_Unboxing.Models
{
    public class Shark : Fish
    {

        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
