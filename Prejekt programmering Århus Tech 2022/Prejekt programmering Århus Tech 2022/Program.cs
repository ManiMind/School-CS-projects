using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_programmering_Århus_Tech_2022
{
    internal class Program
    {
        //Static variables for filnavn og string
        static string usersStr = "";
        static string usersFil = "User_Fil.txt";
        static void B_vejl () //Bruger vejledning
        {
            Console.Clear();
            Console.Write
                    (
                    "-- Brugervejledning --\n" +
                    "\n" +
                    "Tryk enter for at fortsætte"
                    );

            Console.ReadLine();        
        }
        static void S_farver () //Farve menu
        {
            Console.Clear();

            
            Console.Write
                (
                "-- Farve menu --\n" +
                "\n" +
                "1. Bluescreen\n" +
                "2. Matrix\n" +
                "3. Discord\n" +
                "4. Default\n" +
                "\n" +
                "Tast valg->"
                );

            //Farve menu controller
            Int32.TryParse(Console.ReadLine(), out int finput);
            switch (finput)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.Beep();
                    break;
            }    
        }
        static void Vis_brugere () //viser brugere fra string
        {
            Console.Clear();

            Console.WriteLine
                (
                "-- Bruger liste--\n" +
                ""
                );
            string[] userList = usersStr.Split(',');
            foreach (string user in userList)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine("\nTryk enter for at forsætte");
            Console.ReadLine();
        }
        static void Ny_bruger () //oprætter bruger
        {
            Console.Clear();
            
            //Fornavn
            Console.Write
                (
                "-- Opret bruger --\n" +
                "\n" +
                "Brugernavn->"
                );
            string Fornavn = Console.ReadLine();
            
            //Efternavn
            Console.Write
                (
                "Efternavn->"
                );
            string Efternavn = Console.ReadLine();

            //Initialer + Email
            String Initialer = "";
            String Email = "";
            String Domain = "@GRP4-Domain.test";
            Initialer += Fornavn[0];
            Initialer += Efternavn[0];
            Initialer += Efternavn[1];
            Initialer = Initialer.ToUpper();
            Email += Initialer + Domain;

            if (usersStr.Length != 0)
            {
                usersStr = usersStr + ",";
            }
            usersStr = usersStr + Fornavn + " " + Efternavn + " - " + Initialer + " - " + Email;
        }
        static void Gem () //gemmer bruger string til fil
        {
            Console.Clear();

            Console.Write
                (
                "-- Gemmer i fil --\n" +
                "\n" +
                "Tast enter for at fortsætte"
                );

            File.WriteAllText(usersFil, usersStr);

            Console.ReadLine();
        }
        static void End () //slukker programmet
        {
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            //Oprætter fil hvis den ikke existerer
            if (File.Exists("User_Fil.txt") == false)
                File.WriteAllText(usersFil, usersStr);
                
            //Læser filen og gemmer det i en string
            usersStr = File.ReadAllText(usersFil);

            //Menu loop
            while (true)
            {
                //Menu text
                Console.Write
                    (
                    "-- Menu --\n" +
                    "\n" +
                    "1. Brugervejledning\n" +
                    "2. Setup farver\n" +
                    "3. Vis brugere\n" +
                    "4. Opret ny bruger\n" +
                    "5. Gem i fil\n" +
                    "9. Afslut\n" +
                    "\n" +
                    "Tast valg->"
                    );

                //Menu controller
                Int32.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        B_vejl ();
                        break;

                    case 2:
                        S_farver ();
                        break;

                    case 3:
                        Vis_brugere ();
                        break;

                    case 4:
                        Ny_bruger ();
                        break;

                    case 5:
                        Gem ();
                        break;

                    case 9:
                        End ();
                        break;

                    default:
                        Console.Beep();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
