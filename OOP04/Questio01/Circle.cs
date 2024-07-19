using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Questio01
{
    internal class Circle : ICircle
    {
        public double Radius { get ; set ; }

        public double Area 
        { 
            get 
            {
                return Math.PI * Math.Pow(Radius, 2);
            } 
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius:{Radius}");
            Console.WriteLine($"Area:{Area}");
 
        }
    }
}
