using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplicationOfSudentAndScores
{
    public class StudentManager
    {
        public static List<Student> student = new List<Student>();
        StudentsInfoInput studentsInfoInput = new StudentsInfoInput();
        public static Student FindStudentById(int id)
        {
            return student.Find(c =>c.Id == id);
            
        }
        public static void RefreshFile()
        {
            TextWriter writer = new StreamWriter ("StudentsFile.txt");
            foreach(var item in student)
            {
                writer.WriteLine(item);
            }
            writer.Flush();
            writer.Close();
        }
       
         public static void AddCategory( string studentsName,int id, int studentsEnglishScore, int studentsMathematicsScore, int studentsEconomicsScore, int studentsOverallScore)
        {
            var categoryExist = FindStudentById(id);
            if (categoryExist != null)
            {
                Console.WriteLine($"category with {id} already exist");
            }
            Student studentadd = new Student(studentsName,id,studentsEnglishScore,studentsMathematicsScore,studentsEconomicsScore,studentsOverallScore);
            student.Add(studentadd);
            TextWriter writer = new StreamWriter ("StudentsFile.txt", true);
            writer.WriteLine(studentadd.ToString());
            Console.WriteLine("Student added successfully!");
            writer.Close();
            Menu.StudentMenu(id);
        }
        
        public void StudentRep()
        {
            FetchCategoryFromFile ();      
        }

        public void FetchCategoryFromFile()
        {
            try
            {
                var studentsLines = File.ReadAllLines("files//category.txt");
                foreach (var studentLine in studentsLines)
                {
                    var category = Student.StringToCategory(studentLine);
                    student.Add(category);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
          public static void PrintCategory (Student students)
        {
            Console.WriteLine($"Student's ID:{students.Id} Student's Name:{students.StudentsName} Student's English Score:{students.StudentsEnglishScore} Student's Mathematics Score:{students.StudentsMathematicsScore} Student's Economics Score:{students.StudentsEconomicsScore} Student's Overall Score:{students.StudentsOverallScore}\n");
        }

        public static void GetStudent()
        {
            foreach (Student pupil in student)
            {
                PrintCategory(pupil);
            }
        }
        
        public static void StudentUpdation(int id)
        {
            var studentExist = FindStudentById(id);
            if (studentExist == null)
            {
                Console.WriteLine($"category with Id : {id} does not exist");
            }else
            {UpdateStudentMenu();
                int UpdateStudentMenuOption = int.Parse(Console.ReadLine());
                if(UpdateStudentMenuOption == 1)
                {
                Console.WriteLine($" New Student's Name  : ");
                string newstudentname = Console.ReadLine();
                studentExist.StudentsName = newstudentname;
                RefreshFile();
                Menu.StudentMenu(id);
                }
                if(UpdateStudentMenuOption == 2)
                {
                Console.WriteLine($"Student's Name Added Successfully !");
                Console.WriteLine($" New Student's English Score  : ");
                int newstudentEnglishScore = int.Parse(Console.ReadLine());
                studentExist.StudentsEnglishScore = newstudentEnglishScore;
                RefreshFile();
                Menu.StudentMenu(id);
                }
                if(UpdateStudentMenuOption ==3)
                {
                Console.WriteLine($" New Student's Mathematics Score : ");
                int newstudentMathematicsScore = int.Parse(Console.ReadLine());
                studentExist.StudentsMathematicsScore = newstudentMathematicsScore;
                RefreshFile();
                Menu.StudentMenu(id);
                }
                if(UpdateStudentMenuOption == 4)
                {
                Console.WriteLine($" New Student's Economics Score: ");
                int newstudentEconomicsScore = int.Parse(Console.ReadLine());
                studentExist.StudentsEconomicsScore = newstudentEconomicsScore;
                RefreshFile();
                Menu.StudentMenu(id);
                }
                
            }
            
        }
          public static void DeleteStudent(int id)
        {
            var studentExist = FindStudentById(id);
            if (studentExist == null)
            {
                Console.WriteLine($"category with {id} does not exist");
            }
            student.Remove(studentExist);
            RefreshFile();
            Menu.StudentMenu(id);
        }
        public static void UpdateStudentMenu()
        {
            Console.WriteLine($"1.Update Student's Name");
            Console.WriteLine($"2.Update Student's English Score");
            Console.WriteLine($"3.Update Student's Mathematics Score");
            Console.WriteLine($"4.Update Student's Economics Score");

        }
    }
}