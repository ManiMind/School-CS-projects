using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte myNum = 129;
            int resultat;
            int rest = myNum;



            resultat = myNum / 128;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = myNum - 128;
            }
            else
                Console.Write("0");

            resultat = rest / 64;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = rest - 64;
            }
            else
                Console.Write("0");

            resultat = rest / 32;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = rest - 32;
            }
            else
                Console.Write("0");

            resultat = rest / 16;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = rest - 16;
            }
            else
                Console.Write("0");

            Console.Write(" ");

            resultat = rest / 8;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = rest - 8;
            }
            else
                Console.Write("0");

            resultat = rest / 4;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = rest - 4;
            }
            else
                Console.Write("0");

            resultat = rest / 2;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = rest - 2;
            }
            else
                Console.Write("0");

            resultat = rest / 1;
            if (resultat == 1)
            {
                Console.Write("1");
                rest = rest - 1;
            }
            else
                Console.Write("0");

            Console.ReadLine();
        }
    }
}
