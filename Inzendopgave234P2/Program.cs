using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inzendopgave234P2
{
    /* Instructies
    Maak een applicatie Boodschappenlijst. De applicatie Boodschappenlijst heeft een class Boodschappenlijst. De class Boodschappenlijst heeft een instance variabele producten, wat een array is.
    Het arrayobject, bevat objecten van het type Product.
    De class product heeft de string naam en de int aantal als attributen. Maak de class product abstract.
    Maak van product twee subclasses, namelijk Kruidenierswaren en Verswaren. Laat in een demo-applicatie zien dat er Kruidenierswaren en Verswaren in de boodschappenlijst geplaatst kunnen worden. */
    class Program
    {
        static void Main(string[] args)
        {
            Boodschappenlijst boodschappenlijst = new Boodschappenlijst();
        }
    }

    class Boodschappenlijst : Kruidenierswaren, KratBier
    {
        string[] Product = { Gebak };
    }

    abstract class Product
    {
        string naam = "taart";
        int aantal = 24;

    }

    class Kruidenierswaren : Product
    {
        public static void Gebak(string naam)
        {
            Console.WriteLine($"De {naam} is erg lekker");
        }
    }

    class Verswaren : Product
    {
        public static void KratBier(int aantal)
        {
            Console.WriteLine($"In de krat zitten er {aantal} flessen bier");
        }
    }
}
