using System.Runtime.Intrinsics.X86;

namespace Ex_3A_Student_Grade_Calculator
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
        public double AverageGrade 
        { 
          get 
            { return Grades.Average(); }
        }
        public string LetterGrade 
        {
        get {return Grading.EvaluateGrade(AverageGrade);}
        }
    }
}
