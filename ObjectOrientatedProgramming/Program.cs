using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientatedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Object Oriented Programming";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Mage Aiden = new Mage("Aiden", 18, true, 99999);
            Human Ashton = new Human("Ashton", 16, false);
            Human Brad = new Human("Brad", 17, true);
            Aiden.PrintInfo();
            Ashton.PrintInfo();
            Brad.PrintInfo();
            MyStaticClass.test("Hello, World");
            Console.ReadKey();
        }
    }
    static class MyStaticClass
    {
        public static void test(String message)
        {
            Console.WriteLine(message);
        }
    }
}