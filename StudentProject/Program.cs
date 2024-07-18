using System.Collections;

namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int x; x is var of int type
            // object is variable / instance of class
            //Student student = new Student();
            // //Student student1; // daclaration
            // //student1 = = new Student(); // initialization

            // // new keyword will do 2 things

            // //student.rn = 1;
            // student.GetDetails();
            // student.DisplayDetails();  

            // STore details for 2 students
            //Student student1 = new Student();
            //Student student2 = new Student();
            //student1.GetDetails();
            //student1.DisplayDetails();
            //student2.GetDetails();
            //student2.DisplayDetails();

            // store details of 10 students
            // array of objects
            //Student[] students = new Student[10];
            //for (int i = 0; i < 2; i++)
            //{
            //    students[i] = new Student();
            //    students[i].GetDetails();
            //}
            //Console.WriteLine("Details of students are");
            //foreach (Student student in students)
            //{
            //   if(student != null)
            //    student.DisplayDetails();
            //}

            // Store multiple records// use collection
            //ArrayList students = new ArrayList();
            //Student student1 = new Student();
            //student1.GetDetails();
            //students.Add(student1);

            //Student student2 = new Student();
            //student2.GetDetails();
            //students.Add(student2);

            //students.Add(10);

            //Console.WriteLine("details are ");
            //foreach (Student student in students)
            //{
            //    student.DisplayDetails();
            //}
            // Generic collection
            List<Student> students = new List<Student>();
            Student student1 = new Student();
            student1.GetDetails();
            students.Add(student1);

            Student student2 = new Student();
            student2.GetDetails();
            students.Add(student2);

            //students.Add(10);

            Console.WriteLine("details are ");
            foreach (Student student in students)
            {
                student.DisplayDetails();
            }
        }

    }
}
