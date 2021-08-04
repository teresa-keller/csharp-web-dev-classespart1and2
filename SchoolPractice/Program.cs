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

            Student otherNewStudent = new Student("Mom");
     
            Console.WriteLine(otherNewStudent.Gpa);
            otherNewStudent.AddGrade(3, 4.0);
            Console.WriteLine(otherNewStudent.Gpa);
            otherNewStudent.AddGrade(4, 3.0);
            Console.WriteLine(otherNewStudent.Gpa);

            Console.WriteLine(otherNewStudent.ToString());
        }
    }
}
