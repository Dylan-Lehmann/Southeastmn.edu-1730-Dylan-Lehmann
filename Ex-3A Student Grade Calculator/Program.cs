using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Ex_3A_Student_Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Calculator.");
            CalculateNumberStudents();
        }

        private static void CalculateNumberStudents()
        {
            Console.WriteLine("Enter the number of students.");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int numberofStudents))
            {
                List<Student> students = new List<Student>();
                for (int i = 1; i < numberofStudents + 1; i += 1)
                {
                    Console.WriteLine($"Capturing Student {i}");
                    Student student = CaptureStudentGrades();
                    students.Add(student);
                }
                Console.WriteLine("Final Grade Report.");
                foreach (Student student in students)
                { PrintStudentGrades(student); }
            }
            else
            { 
                Console.WriteLine("Invalid number of students.Please enter a numeric value");
                CalculateNumberStudents();
            }
        }

        private static void PrintStudentGrades(Student student)
        {
            Console.WriteLine($"{student.Name}: Average Grade = {student.AverageGrade:F2}, Letter Grade = {student.LetterGrade}");
        }

        private static Student CaptureStudentGrades()
        {
            Student student = new Student();

            Console.WriteLine("Enter student's name:");
            student.Name = Console.ReadLine();

            string input;
            student.Grades = new List<int>();

            while (true)
            {
                Console.Write("Enter a grade (or type 'done' to finish)");
                input = Console.ReadLine();

                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int grade))
                {
                    student.Grades.Add(grade);
                }
                else
                {
                    Console.WriteLine("Invalid grade. Please enter a numeric value");
                }
            }

            return student;
        }
    }
}
