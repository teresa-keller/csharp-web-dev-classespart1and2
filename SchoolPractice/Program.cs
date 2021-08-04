using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.

            Student newStudent = new Student("Teresa");
            newStudent.NumberOfCredits = 44;
            Console.WriteLine(newStudent.GetGradeLevel(newStudent.NumberOfCredits));
        }
    }
}
