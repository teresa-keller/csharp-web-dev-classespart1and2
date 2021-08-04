using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        //public Student() { }
        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double currentTotalQualityScore = this.Gpa * this.NumberOfCredits;
            double qualityScore = grade * courseCredits;
            double totalQualityScore = currentTotalQualityScore + qualityScore;
            int totalNumberOfCredits = this.NumberOfCredits + courseCredits;
            double newGpa = (totalQualityScore / (totalNumberOfCredits));
            this.NumberOfCredits = totalNumberOfCredits;
            this.Gpa = newGpa;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            

            if (this.NumberOfCredits <= 29)
            {
                return "Freshman";
            } else if (this.NumberOfCredits >= 30 && this.NumberOfCredits <= 59)
            {
                return "Sophomore";
            } else if (this.NumberOfCredits >= 60 && this.NumberOfCredits <= 89)
            {
                return "Junior";
            }
            return "Senior";
        }

        public override string ToString()
        {
            return "Student ID: " + this.StudentId + "\nName: " + this.Name + "\nNumber of Credits: " + this.NumberOfCredits + "\nGPA: " + this.Gpa + "\nGrade Level: " + this.GetGradeLevel(this.NumberOfCredits);
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId &&
                   NumberOfCredits == student.NumberOfCredits &&
                   Gpa == student.Gpa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId, NumberOfCredits, Gpa);
        }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

    }
}
