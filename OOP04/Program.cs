using OOP04.interfaces;
using System.Text;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region part1
            Employee e1 = new Employee()
            {
                ID = 100,
                Name = "madonna"
            };
            Employee e2 = new Employee()
            {
                ID = 20,
                Name = "mirna"
            };
            Employee e3 = new Employee()
            {
                ID = 3,
                Name = "mariam"
            };
            Employee[] e ={ e1, e2 };
            Employee[] emp = new Employee[2];
            #region shallow and deep copy
            //emp = e;//shallow copy
            //emp[0] = e3;
            //Console.WriteLine(e[0]); // has same change that happend in emp
            //emp =(Employee[])emp.Clone();//deep copy
            //emp[0] = e2;
            //Console.WriteLine(e[0]); // has not same change that happend in emp
            #endregion
            #region sort
            //Array.Sort(e);
            //foreach (Employee employee in e)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion
            #endregion

            
        }
    }
}
