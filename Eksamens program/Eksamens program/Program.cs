using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_program
{
    internal class Program
    {
        //definere static strings til brug i flere forskellige funktioner
        static string usersStr = "";
        static string usersFil = "User_Fil.txt";

        static void Vis_bruger ()
        {
            int Timer = 0;

            //tekst
            Console.WriteLine
                (
                "--Vis Bruger--\n" +
                "\n\n\n\n" +
                usersStr + 
                "\n" +
                "--------------------------------"
                );

            //array split og print
            string[] userList = usersStr.Split(',');
            foreach (string user in userList)
            {
                Console.WriteLine(user);
                Timer++;
                if (Timer == 4)
                {
                    Console.WriteLine("--------------------------------");
                    Timer = 0;
                }
            }

            Console.ReadLine();
        }

        static void Tilføj_bruger ()
        {
            //fornavn input
            Console.Write
                (
                "--Tilføj bruger--\n"+
                "\n\n\n\n" +
                "Indtast fornavn -> "
                );
            string fornavn = Console.ReadLine ();

            //input efternavn
            Console.Write
                (
                "Indtast efternavn -> "
                );
            string efternavn = Console.ReadLine ();

            //input domæne
            Console.Write
                (
                "Indtast domæne -> "
                );
            string domæne = Console.ReadLine ();

            //domæneendelse input
            Console.Write
                (
                "Indtast domæneendelse -> "
                );
            string domæneendelse = Console.ReadLine ();

            //direktør input
            Console.Write
                (
                "Indtast direktør -> "
                );
            string direktør = Console.ReadLine ();

            //initialer og email fra tidligere inputs
            string initialer = "";
            string Email = "";
            initialer += fornavn[0];
            initialer += efternavn[0];
            initialer += efternavn[1];
            initialer = initialer.ToUpper();
            Email += initialer + "@" + domæne + domæneendelse;

            //fyld string til csv fil
            if (usersStr.Length != 0 ) 
            {
                usersStr = usersStr + ",";
            }
            usersStr = usersStr + fornavn + "," + efternavn + "," + initialer + "," + Email;

            //skriv/gem til scv fil
            File.WriteAllText(usersFil, usersStr);

            Console.Clear ();

            //velkomstbrev
            Console.Write
                (
                "Hej " + fornavn + " " + efternavn + "\n" +
                "\n" +
                "Velkommen til danit. Arbejdstiden er 8.10 til 15.00. Vi forventer du møder til tiden.\n" +
                "Din email er: " + Email + "\n" +
                "\n\n" +
                "Med venlig hilsen\n" +
                "\n" +
                direktør + "\n" +
                "danit" +
                "\n\n\n"
                );

            Console.Write("tryk enter for at fortsætte");
            Console.ReadLine();
        }

        static void Slet ()
        {
            //Tekst
            Console.WriteLine
                (
                "--Sletter User_Fil.txt--" +
                "\n\n\n" +
                "Tryk enter for at fortsætte"
                );
            Console.ReadLine();

            //kører batch script til at slette usersFil
            Process.Start("C:\\Users\\flobb\\Desktop\\Programming\\Eksamens program\\Eksamens program\\bin\\Debug\\Delete usersFil.bat");
            
            //tømmer usersStr
            usersStr = "";

            //genopretter tom fil
            File.WriteAllText(usersFil, usersStr);
        }

        static void Afslut ()
        {
            //program sluk
            Environment.Exit (0);
        }

        static void Vejledning ()
        {
            //Vejledning tekst
            Console.Write
                (
                "--Brugervejledning--\n\n" +
                "Naviger Menuen med tal inputs\n" +
                "-Vis bruger- viser registrede brugere\n" +
                "-Tilføj bruger- ber om input til fornavn, efternavn, domæne, domæneendelse, og direktør. oprætter bruger med disse inputs og viser velkomstbrev\n" +
                "-Slet alle brugere- sletter registrerede brugere\n" +
                "-Afslut- terminerer programmet\n" +
                "\n" +
                "Tryk enter for at fortsætte"
                );
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //tjekker om fil findes, og hvis ikke, opretter den
            if (File.Exists("User_Fil.txt") == false)
                File.WriteAllText(usersFil, usersStr);

            //læser fra fil til usersStr
            usersStr = File.ReadAllText(usersFil);

            //menu loop
            while (true)
            {
                //menu tekst
                Console.Write
                ("--Menu--\n" +
                "                   1: Vis bruger\n" +
                "                   2: Tilføj bruger\n" +
                "                   3: Slet alle brugere\n" +
                "                   4: Afslut\n" +
                "                   5: Vejledning\n" +
                "\n" +
                "Vælg funktion ->"
                );

                //menu input switch
                int.TryParse(Console.ReadLine(), out int input);
                switch (input) 
                {
                    case 1:
                        Console.Clear();
                        Vis_bruger();
                        break;
                    case 2:
                        Console.Clear();
                        Tilføj_bruger();
                        break;
                    case 3:
                        Console.Clear();
                        Slet();
                        break;
                    case 4:
                        Console.Clear();
                        Afslut();
                        break;
                    case 5:
                        Console.Clear();
                        Vejledning ();
                        break;
                    default:
                        break;
                }
                Console.Clear();

            }
            
            
            
            
            
        }
    }
}
