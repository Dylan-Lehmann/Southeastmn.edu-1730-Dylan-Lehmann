namespace Ex_3A_Student_Grade_Calculator
{
    public class Grading
    {
        public static string EvaluateGrade(double average)
        {
            if (average >= 90)
                return "A";
            else if (average >= 80)
                return "B";
            else if (average >= 70)
                return "C";
            else if (average >= 60)
                return "D";
            else 
                return "F";
        }
       
    }
}
