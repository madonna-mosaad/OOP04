using OOP04.interfaces;
using OOP04.Questio01;
using OOP04.Question02;
using OOP04.Question03;
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

            #region part3
            #region Q01
            //Circle circle = new Circle() { Radius = 10 };
            //Rectangle rectangle = new Rectangle() 
            //{ 
            //    Length = 10 ,
            //    Width = 10 
            //};
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion
            #region Q02
            //int size;
            //int[] pass;
            //string[] name;
            //string[] role;
            //do
            //{
            //    Console.WriteLine("enter the size : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out  size)&& size<=0);
            //pass = new int[size];
            //name = new string[size];
            //role = new string[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("enter the user name : ");
            //    name[i] = Console.ReadLine();
            //    do
            //    {
            //        Console.Write("enter the password : ");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out pass[i]) );
            //    Console.Write("enter the role : ");
            //    role[i] = Console.ReadLine();
            //}


            //IAuthenticationService authenticationService = new BasicAuthenticationService(pass,name,role);

            //Console.WriteLine(authenticationService.AuthenticateUser("madonna", 9876)) ;
            //Console.WriteLine(authenticationService.AuthorizeUser("madonna","admin"));
            #endregion
            #region Q03
            //INotificationService emailService = new EmailNotificationService();
            //emailService.SendNotification("john@example.com", "Hello, John!");

            //INotificationService smsService = new SmsNotificationService();
            //smsService.SendNotification("+123456789", "Hello, SMS!");

            //INotificationService pushService = new PushNotificationService();
            //pushService.SendNotification("Alice", "Hello, Alice!");
            #endregion
            #endregion
        }
    }
}
