using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Michis Telefonbuch");
            Console.WriteLine("A = Neuen Eintrag erstellen");
            Console.WriteLine("B = Eintrag suchen");
            Console.WriteLine("C = Eintrag löschen");

            ConsoleKeyInfo keyInfo;
            StringBuilder sb = new StringBuilder();
            keyInfo = Console.ReadKey(true);
            bool ende = false;

            while (!ende)
            {
                if (keyInfo.Key != ConsoleKey.Escape)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Neuen Eintrag erstellen");
                            Console.WriteLine("Beeneden?");
                            Console.ReadKey(keyInfo.Key == ConsoleKey.Escape);

                            if (keyInfo.Key == ConsoleKey.Escape)
                            {
                                Console.ReadKey();
                                ende = true;
                            }
                            else
                            {
                                Console.WriteLine("Michis Telefonbuch");
                                Console.WriteLine("A = Neuen Eintrag erstellen");
                                Console.WriteLine("B = Eintrag suchen");
                                Console.WriteLine("C = Eintrag löschen");
                                ende = false;
                            }
                            break;

                        case ConsoleKey.B:
                            Console.WriteLine("Eintrag suchen");
                            Console.WriteLine("Beeneden?");
                            Console.ReadKey(keyInfo.Key == ConsoleKey.Escape);
                            ende = true;
                            break;

                        case ConsoleKey.C:
                            Console.WriteLine("Eintrag löschen");
                            Console.WriteLine("Beeneden?");
                            Console.ReadKey(keyInfo.Key == ConsoleKey.Escape);
                            ende = true;
                            break;
                    }
                }
            }
        }
    }
}
