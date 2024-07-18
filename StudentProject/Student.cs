using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    // what is class
    // class is a user defined type
    // data type
    // any type indicates what??
    // it indicates 2 things
    // what value we can store
    // what functions can be performed
    // int indicates what > what value we can store 1,2,3
    // what functions can be performed + - */ strcmp
    // int x
    // inbuilt / primitive types> int char float double bool string
    // user defined types > class struct enum

    // encapsulation /abstraction
    // encapsulation > hiding the details from the user
    // abstraction> showing the deatils needed by user

    // how do we acheive them ?
    // using access specifiers
    // private  > by def class members are private
    // public  ? those members can be accessed frm outside the project also
    // internal   > by def class has internal , accessible anywhere in same assmebly/project
    // protected  > used in inheritance
    // protected internal
     class Student
    {
        int rn;
        string name;
        string address;
        int marks;
        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
            Console.WriteLine("enter marks");
            marks = byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"rn is {rn}");
            Console.WriteLine($"name is {name}");
            Console.WriteLine($"address is {address}");
            Console.WriteLine($"marks are {marks}");
        }
    }
}
