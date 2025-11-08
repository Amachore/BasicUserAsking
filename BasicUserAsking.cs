using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string welcomeMessage = $"Hi! Welcome to Vaughn's Contact Tracing Program. \nWrite the following details: \nName: ";
            Console.Write(welcomeMessage);
            string Name = Console.ReadLine();
            Console.Write("Number/email: ");
            string Contact = Console.ReadLine();
            Console.Write("Address: ");
            string Address = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor. Green;
            Console.WriteLine("\nWell done. Ingat!:)");
            Console.ResetColor();
        }
    }
}
