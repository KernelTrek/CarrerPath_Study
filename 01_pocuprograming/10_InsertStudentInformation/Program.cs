using System;

namespace _10_InsertStudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 정보를 채워 주세요");

            Console.Write("이름: ");
            string studentName = Console.ReadLine();

            Console.Write("학생 번호 : ");
            int studentNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"학생 : {studentName}, 학번 : {studentNumber}");

        }
    }
}
