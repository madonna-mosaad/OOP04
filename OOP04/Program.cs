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

            #region part2
            //Question 1: What is the primary purpose of an interface in C#
            //Answer: b) To define a blueprint for a class

            //Question 2: Which of the following is NOT a valid access modifier for interface members in C#?
            //Answer: a) private

            //Question 3: Can an interface contain fields in C#?
            //Answer: b) No

            //Question 4: In C#, can an interface inherit from another interface?
            //Answer: b) Yes, interfaces can inherit from multiple interfaces

            //Question 5: Which keyword is used to implement an interface in a class in C#?
            //Answer: d) implements

            //Question 6: Can an interface contain static methods in C#?
            //Answer: b) No

            //Question 7: In C#, can an interface have explicit access modifiers for its members?
            //Answer: b) No, all members are implicitly public

             //Question 8: What is the purpose of an explicit interface implementation in C#?
             //Answer: a) To hide the interface members from outside access

             //Question 9: In C#, can an interface have a constructor?
             //Answer: b) No, interfaces cannot have constructors

             //Question 10: How can a C# class implement multiple interfaces?
             //Answer: c) By separating interface names with commas
            #endregion
        }
    }
}
