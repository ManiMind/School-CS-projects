using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_test
{
    internal class Program
    {
        static bool clear = true;
        static string[,] Sea =
            {
                {"#","#","#","#","#","#","#","#","4","#"},
                {"#","#","#","#","#","#","#","#","4","#"},
                {"#","#","2","#","#","#","#","#","4","#"},
                {"#","#","2","#","#","#","#","#","4","#"},
                {"#","#","#","#","#","#","#","#","#","#"},
                {"#","#","#","#","#","#","#","#","#","#"},
                {"#","#","#","#","3","3","3","#","#","#"},
                {"#","#","#","#","#","#","#","#","#","#"},
                {"#","#","#","#","#","#","#","#","#","#"},
                {"#","#","#","#","#","#","#","#","#","#"},
            };

static void print()
        {
            for (int x = 0; x < Sea.GetLength(0); x++)
            {
                for (int y = 0; y < Sea.GetLength(1); y++)
                {
                    Console.Write(Sea[x, y]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void check()
        {
            foreach (string i in Sea)
            {
                switch (i)
                {
                    case "2":
                    case "3":
                    case "4":
                        clear = false;
                        break;

                    default:
                        clear = true;
                        break;
                }
                if (clear == false)
                    break;
            }
        }
        static void Main(string[] args)
        {
            print();
            check();

            while (clear == false)
            {
                Console.Write("y:");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("x:");
                int y2 = Convert.ToInt32(Console.ReadLine());

                if (Sea[x2, y2] == "#")
                    Console.WriteLine("plask");
                else
                {
                    Console.WriteLine("bum");
                    Sea[x2, y2] = "#";
                }

                Console.Clear();
                print();
                check();
            }

            Console.WriteLine("you win");

            Console.ReadLine();
        }
    }
}
