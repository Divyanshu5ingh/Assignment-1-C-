using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //2. Program that accepts details from user
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //2.1 Asking the user for ID, Name, DepartmentName
                Console.Write("Enter the employee Id: ");
                int empId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter you Name : ");
                string empName = Console.ReadLine();

                Console.Write("Enter the Department Name : ");
                string empDepartmentName = Console.ReadLine();

                //2.2 After getting details from user, here I am creating object of the Employee class
                Employee emp = new Employee(empId, empName, empDepartmentName);
                emp.EventCaller += OnEventCaller;
                Console.WriteLine();

                //2.3 After creating an object, This is how to print all three properties one by one
                Console.WriteLine("ID =  " + emp.GetId());
                Console.WriteLine("Name = " + emp.GetName());
                Console.WriteLine("Department Name = " + emp.GetDepartmentName());
                //For blank new line I am using Console.WriteLine
                Console.WriteLine();

                Console.WriteLine("....Updating Employee Details....");

                Console.WriteLine();

                //Getting user input for updating Employee details
                Console.Write("Enter new Employee ID : ");
                int newEmpId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new Employee Name : ");
                string newEmpName = Console.ReadLine();

                Console.Write("Enter new Department Name : ");
                string newEmpDepartmentName = Console.ReadLine();

                //To update
                emp.update(newEmpId);
                emp.update(newEmpName);
                emp.update(newEmpDepartmentName);

                Console.WriteLine();

                //Printing the updated Message
                Console.WriteLine("Updated ID =  " + emp.GetId());
                Console.WriteLine("Updated Name = " + emp.GetName());
                Console.WriteLine("Updated Department Name = " + emp.GetDepartmentName());
            }

            //Exception for any error Like invalid input in employee ID
            catch(Exception e)
            {
                Console.WriteLine("Invalid Input\n{0}", e.Message);
            }


            Console.ReadKey();
        }
                
        private static void OnEventCaller(string message)
        {
            Console.WriteLine(message);
        }
    }
}
