using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHK_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Welcome to TTHK students page!");

            Console.WriteLine("Lets add you to the students list. Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("And your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Are you currently studying? Y/N");
            string isStudying = Console.ReadLine();
            
            Student student = new Student(firstName, lastName, isStudying);
            Console.WriteLine($"Welcome, {student}!");

            Console.WriteLine("\nTo add next student press press - A \nTo look at the current list press - L");
            string usersChoise = Console.ReadLine();

            if (usersChoise == "A")
            {

            }

            else if (usersChoise == "L")
            {

            }



            Console.ReadKey();
        }
    }
}
