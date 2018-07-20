using System;

namespace OnlineEducation
{
    class Program
    {
        static void Main(string[] args)
        {
            string formEducationPredvaritelno = Console.ReadLine();
            double countStudentsPredvaritelno = double.Parse(Console.ReadLine());
            string formEducationRedovno = Console.ReadLine();
            double countStudentsRedovno = double.Parse(Console.ReadLine());
            string formEducationKusno = Console.ReadLine();
            double countStudentsKusno = double.Parse(Console.ReadLine());

            double onlineStudents = 0.0;
            double onsiteStudents = 0.0;
            double rest = 0.0;
            

            if (formEducationPredvaritelno == "onsite")
            {
                onsiteStudents += countStudentsPredvaritelno;
                
            }
            else if(formEducationPredvaritelno == "online")
            {
                onlineStudents += countStudentsPredvaritelno;
            }

            if (formEducationRedovno == "onsite")
            {
                onsiteStudents += countStudentsRedovno;

            }
            else if (formEducationRedovno == "online")
            {
                onlineStudents += countStudentsRedovno;
            }

            if (formEducationKusno == "onsite")
            {
                onsiteStudents += countStudentsKusno;
                      
            }
            else if (formEducationKusno == "online")
            {
                onlineStudents += countStudentsKusno;
            }

            if (onsiteStudents > 600)
            {
                rest = onsiteStudents - 600;
                onlineStudents += rest;
                onsiteStudents -= rest; 

            }

            Console.WriteLine($"Online students: {onlineStudents}");
            Console.WriteLine($"Onsite students: {onsiteStudents}");
            Console.WriteLine($"Total students: {onsiteStudents  + onlineStudents}");
        }
    }
}
