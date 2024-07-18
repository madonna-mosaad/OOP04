using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.interfaces
{
    internal class Employee : IUnderGrade, IGrade, ICloneable, IComparable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new Employee()
            {
                ID = this.ID,
                Name = this.Name
            };
        }

        public int CompareTo(object? obj)
        {
            Employee Emp =(Employee)obj;
            return this.ID.CompareTo(Emp.ID);
        }

        public void degree()
        {
            Console.WriteLine("degree");
        }

        void IGrade.GradeYear()
        {
            Console.WriteLine("grade");
        }
        void IUnderGrade.GradeYear()
        {
            Console.WriteLine("under grade");
        }
        public override string ToString()
        {
            return $"{Name} {ID}";
        }
    }
}
