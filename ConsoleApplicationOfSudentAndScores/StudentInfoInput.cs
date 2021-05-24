using System;
namespace ConsoleApplicationOfSudentAndScores
{
    public class StudentsInfoInput
    {
        public static Student StudentInput()
        {StudentManager studentManager = new StudentManager();

            Console.WriteLine("Student's Name :");
            string studentsName =Console.ReadLine();
           Console.WriteLine("Student's  Score :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Student's English Score :");
            int studentsEnglishScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Student's Mathematics Score :");
            int studentsMathematicsScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Student's Economics Score :");
            int studentsEconomicsScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Student's Overall Score :");
            int studentsOverallScore =studentsEconomicsScore + studentsEnglishScore + studentsMathematicsScore;

            Student student = new Student(studentsName,id,studentsEnglishScore,studentsMathematicsScore,studentsEconomicsScore,studentsOverallScore);
            
            StudentManager.AddCategory(studentsName,id, studentsEnglishScore,studentsMathematicsScore,studentsEconomicsScore,studentsOverallScore);
            return student;
        }
    }
}
