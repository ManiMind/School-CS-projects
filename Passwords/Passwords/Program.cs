using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //start variables
            String passwordTxt = string.Empty;
            String tooHigh = string.Empty;
            String tooLow = string.Empty;
            String score = string.Empty;
            int forsøg = 0;
            int gæt = 0;

            //login kode
            while (passwordTxt != "puzzlemaster")
            {
                Console.WriteLine("*****************************");
                Console.Write("Indtast password: ");
                passwordTxt = Console.ReadLine();
            }

            //set spil parametre
            Console.Write("Brugernavn: ");
            String userName = Console.ReadLine();
            Console.Write("Minimum: ");
            int minNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum: ");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max forsøg: ");
            int maxForsøg = Convert.ToInt32(Console.ReadLine());
            
            //rng
            Random rnd = new Random();
            int num = rnd.Next(minNum,maxNum);

            //gætte spil loop
            while (gæt != num)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Gæt mit tal: ");
                gæt = Convert.ToInt32(Console.ReadLine());
                forsøg++;
                
                if (gæt > num)
                {   
                    tooHigh = tooHigh + " " + gæt.ToString();
                    Console.WriteLine("Lavere");
                }
                if (gæt < num)
                {
                    tooLow = tooLow + " " + gæt.ToString();
                    Console.WriteLine("Højere");
                }

                Console.WriteLine("forsøg tilbage: " + (maxForsøg - forsøg));

                if (forsøg == maxForsøg)
                    break;
            }

            //resultat
            Console.WriteLine("*****************************");
            if (forsøg != maxForsøg)
            {
                Console.WriteLine("Success!");
                score = Convert.ToString(1000 * (maxNum - minNum) / forsøg);
            }
            else
            {
                Console.WriteLine("Looser!");
                score = Convert.ToString(0);
            }

            //log
            Console.WriteLine("*****************************");
            String writeText =
                "Bruger: " + userName + "\n" +
                "Kode: " + num + "\n" +
                "Forsøg: " + forsøg + "\n" +
                "Under:" + tooLow + "\n" +
                "Over:" + tooHigh + "\n" +
                "Score: " + score + "\n" +
                "*****************************";
            File.AppendAllText("puzzlelog.txt", writeText + "\n");
            String readText = File.ReadAllText("puzzlelog.txt");
            Console.WriteLine(readText);
            


            //slut
            Console.ReadLine();
        }
    }
}
