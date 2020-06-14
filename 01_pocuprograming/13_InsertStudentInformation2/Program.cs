using System;

namespace _13_InsertStudentInformation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Name :");
            string StudentName = Console.ReadLine();

            Console.Write("Grade : ");
            string studentGrade = Console.ReadLine();
            int Grade = int.Parse(studentGrade);

            if( Grade >= 90)
            {
                Console.WriteLine("Excellent, Over 90");
            }
            else if (Grade >= 80)
            {
                Console.WriteLine("Good, Over 80");
            }
            else if (Grade >= 70)
            {
                Console.WriteLine("Normal, Over 70");
            }
            else
            {
                Console.WriteLine("Are you crazy ? ");
            }
                
        }
    }
}
