using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student myStudent = new Student("Teresa", 666, 1, 4.0);
            Console.WriteLine("Student name: " + myStudent.Name);
            Console.WriteLine("Student ID: " + myStudent.StudentId);
            Console.WriteLine("Number of credits: " + myStudent.NumberOfCredits);
            Console.WriteLine("GPA: " + myStudent.Gpa);
        }
    }
}
