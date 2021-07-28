using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        private List<Student> StudentRoster { get; set; }
        private List<Teacher> ProfessorRoster { get; set; }
        private double AverageGrade { get; set; }

        public Course(List<Student> studentRoster, List<Teacher> professorRoster, double averageGrade)
        {
            StudentRoster = studentRoster;
            ProfessorRoster = professorRoster;
            AverageGrade = averageGrade;
        }
        
    }
}
