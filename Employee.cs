using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    //As said in the Assignment, 
    // 1. Create a class called Employee
    
    class Employee // Class Employee created
    {       
        // 1.1 It has three private property as mentioned
        private int Id;
        private string Name;
        private string Departmentname;

        //3. Here I am creating event in the Employee Class 
        public delegate void HandlingEvent(string msg);
        public event HandlingEvent EventCaller;

        public virtual void OnEventCaller(string message)
        {
            EventCaller?.Invoke(message);
        }

        // 1.2 Constructor should accept all three properties
        public Employee(int empId, string empName, string empDepartmentName)
        {
            Id = empId;
            Name = empName;
            Departmentname = empDepartmentName;
        }
        //1.3 It should have three methods that individually returns the above properties
        public int GetId()
        {
            //It fires a message when any of the class method is called as mentioned in the Assignment
            OnEventCaller("GetId() method called");
            return Id;
        }
        public string GetName()
        {
            //Message for GetName method
            OnEventCaller("GetName() method called");
            return Name;
        }

        public string GetDepartmentName()
        {
            //Message for GetDepartmentName() method
            OnEventCaller("GetDepartmentName() method called");
            return Departmentname;
        }

        //4. This is how I have created 3 overloaded methods that allow updating any of the Employee property
        public void update(int empId)
        {
            Id = empId;
        }
        public void update(string empName)
        {
            Name = empName;
        }
        public void update(string empName, string empDepartmentName)
        {
            Name= empName;
            Departmentname= empDepartmentName;
        }
    }
}
