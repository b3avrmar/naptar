using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naptar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Felhasznalo();
        }

        static string Felhasznalo()
        {
            while (true)
            {
                Console.Write("Adja meg a felhasználot: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Apa":
                        return "Apa";
                    case "Anya":
                        return "Anya";
                    default:
                        Console.WriteLine("Hibás felhasználó, próbálja újra.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine("1. Naptár megjelenítése");
            Console.WriteLine("2. Esemény hozzáadása");
            Console.WriteLine("3. Legközelebbi esemány megjelenítése");
            Console.WriteLine("4. Kilépés");

            Console.Write("Válasszon egy opciót: ");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Naptar_megjelenites();
                    break;
                case 2:
                    Esemeny_hozzaadas();
                    break;
                case 3:
                    Legkozelebbi_esemeny();
                    break;
                case 4:
                    Kilepes();
                    break;
                default:
                    Console.WriteLine("Hibás opció, próbálja újra.");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        static void Naptar_megjelenites()
        {
            Console.WriteLine("Naptár megjelenítése");
        }

        static void Esemeny_hozzaadas()
        {
            Console.WriteLine("Esemény hozzáadása");
        }

        static void Legkozelebbi_esemeny()
        {
            Console.WriteLine("Legközelebbi esemény megjelenítése");
        }

        static void Kilepes()
        {
            Mentes();
            Console.WriteLine("Kilépés");
        }

        static void Mentes()
        {
            Console.WriteLine("Adatok mentése");
        }

        public struct Datetime
        {
            
        }
    }
}
