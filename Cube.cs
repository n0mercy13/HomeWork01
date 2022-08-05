using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructClasses
{
    internal class Cube : Shape
    {
        public double Length { get; set; }
        

        public Cube(double length)
        {
            Name = "Cube";
            Length = length;
        }

        public override double CalculateVolume()
        {
            return Math.Pow(Length,3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} side has a length of {Length}");
        }
    }
}
