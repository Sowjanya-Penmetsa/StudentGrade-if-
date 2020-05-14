using System;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the student");
            String Name=Console.ReadLine();
            Console.WriteLine("Enter the marks");
            int Marks = Convert.ToInt32(Console.ReadLine());
            if (Marks==9 || Marks==10)
                Console.WriteLine("Grade is Excellent");
            else if (Marks==8 || Marks==7)
                Console.WriteLine("Grade is Notable");
            else if (Marks==6)
                Console.WriteLine("Grade is Good");
            else if (Marks==5)
                Console.WriteLine("Grade is Pass");
            else
                Console.WriteLine("Grade is Fail");
            Console.ReadLine();

        }
    }
}
