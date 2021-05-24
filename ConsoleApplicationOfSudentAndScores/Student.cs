using System;
namespace ConsoleApplicationOfSudentAndScores
{
    public class Student
    {
        public string StudentsName{ get ;set;}
        public int Id {get;set;}
        public int StudentsEnglishScore{get ;set ;}
        public int StudentsMathematicsScore{get; set;}
        public int StudentsEconomicsScore{get; set;}
        public int StudentsOverallScore{get;set;}

        public Student(string studentsName,int id,int studentsEnglishScore,int studentsMathematicsScore,int studentsEconomicsScore,int studentsOverallScore)
        {
            StudentsName = studentsName;
            Id = id;
            StudentsEnglishScore = studentsEnglishScore;
            StudentsMathematicsScore = studentsMathematicsScore;
            StudentsEconomicsScore = studentsEconomicsScore;
            StudentsOverallScore = studentsOverallScore;
        }

        // public Student(int studentsName, int id, int studentsEnglishScore, int studentsMathematicsScore, int studentsEconomicsScore, int studentsOverallScore)
        // {
        //     Id = id;
        //     StudentsEnglishScore = studentsEnglishScore;
        //     StudentsMathematicsScore = studentsMathematicsScore;
        //     StudentsEconomicsScore = studentsEconomicsScore;
        //     StudentsOverallScore = studentsOverallScore;
        // }

        public override string ToString()
        {
            return $"{Id}\t{StudentsName}\t{StudentsEnglishScore}\t{ StudentsMathematicsScore}\t{StudentsEconomicsScore}\t{  StudentsOverallScore }";
        }
          internal static Student StringToCategory(string studentString)
        {
            var props = studentString.Split("\t");

            int id = int.Parse(props[0]);
            int studentsEnglishScore = int.Parse(props[2]);
            int studentsMathematicsScore = int.Parse(props[3]);
            int studentsEconomicsScore = int.Parse(props[4]);
            int studentsOverallScore = int.Parse(props[5]); 

            return new Student( props[1],id,studentsEnglishScore,studentsMathematicsScore,studentsEconomicsScore,studentsOverallScore);
        }
    }
}