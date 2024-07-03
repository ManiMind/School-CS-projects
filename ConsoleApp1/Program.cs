using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Yoda says hello and does math
            /*whaaat uuuuuup
             * bananas
             * lightsabers*/
            Console.WriteLine("World Hello");
            Console.WriteLine("Learning C# I am");
            Console.WriteLine("Do or do not, there is no try"); //a classic
            Console.WriteLine(16 + 32);
            Console.WriteLine("Who you are?");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome: " + userName);
            Console.WriteLine("How old you are?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old, geezer");
            Console.ReadLine();
        }
    }
}
