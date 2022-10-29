using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_DownCasting_Boxing_Unboxing.Models
{
    public class Eagle : Bird
    {

        public string Color { get; set; }



        //public Eagle()
        //{
        //    Console.WriteLine("Eagle Constructor");
        //}
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
