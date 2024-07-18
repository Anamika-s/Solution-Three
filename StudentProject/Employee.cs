using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    internal class Employee
    {
        public int id;   // instance variable
        string name;  // instance variable
        public static string dept;  // static variable
        public const string companyName="ABC Ltd.";  // constant variables
        float salary;  // instance variable
        public void GetDetails()
        {
            Console.WriteLine("enter id");
            id = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            //Console.WriteLine("enter dept");
            //dept = Console.ReadLine();
            //Console.WriteLine("enter companyName");
            //companyName = Console.ReadLine();
            Console.WriteLine("enter salary");
            salary = float.Parse(Console.ReadLine());
        }
        public void DisplayDeatils()
        {
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
            //Console.WriteLine("dept is " +  dept);
            //Console.WriteLine("companyName is " + companyName);
            Console.WriteLine("salary is " +salary);
        }
        }
    }

