using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    internal class Program1
    {
        static void Main()
        {
            Employee employee = new Employee();
            Console.WriteLine(Employee.companyName);
            Employee.dept = "IT";
            Console.WriteLine(Employee.dept);
            Console.WriteLine(employee.id);
            employee.GetDetails();
            employee.DisplayDeatils();
            Employee employee2 = new Employee();
            employee2.GetDetails();
            employee2.DisplayDeatils();



        }
    }
}
