using System;
namespace ConsoleApplicationOfSudentAndScores
{
    public class Menu
    {
       public static void StudentMenu(int id)
       {
           
            Console.WriteLine("Welcome To Our Student Application");
            Console.WriteLine("***************************************");
            Console.WriteLine("These AreWhat We Offer :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("1.Add a student");
            Console.WriteLine("2.See All Our Student");
            Console.WriteLine("3.Find A Student");
            Console.WriteLine("4.Update A Student Info");
            Console.WriteLine("5.Remove A Student");
            Console.WriteLine("0.Exit");

            int MainMenuOption = int.Parse(Console.ReadLine());
            bool whenAllAreTrue = true;
            switch(MainMenuOption)
            {
                  case 0:
                whenAllAreTrue = false;
                break;
                case 1:
                do
                {
                     
                StudentsInfoInput.StudentInput();
                Console.WriteLine("Do you want to continue?\n Yes / No");
                string continueApp = Console.ReadLine().Trim().ToLower();
                if (continueApp == "yes")
                {
                    whenAllAreTrue = false;
                }
                } while (whenAllAreTrue);
                break;
                case 2:
                StudentManager.GetStudent();
                break;
                case 3:
                 Console.Write("Enter Id of Student you want to Find: ");
                int iD = int.Parse(Console.ReadLine());
                StudentManager.FindStudentById(iD);
                Console.WriteLine($"");
                break;
                case 4:
                Console.Write("Enter Id of Category: ");
                    int ID = int.Parse(Console.ReadLine());

                    Console.Write("Update Category Name: ");
                    string name = Console.ReadLine();
                    StudentManager.StudentUpdation(id);
                break;
                case 5:
                Console.Write("Enter Id of Category you want to Delete: ");
                    int Id = int.Parse(Console.ReadLine());
                    StudentManager.DeleteStudent(Id);
                    
                break;
            }
       } 
    }
}