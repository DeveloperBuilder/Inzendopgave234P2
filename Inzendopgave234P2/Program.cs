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
    public class Program
    {
        public static void Main(string[] args)
        {
            Boodschappenlijst boodschappenlijst = new Boodschappenlijst();
            boodschappenlijst.Producten();
            Console.ReadKey();
        }
    }

    public class Boodschappenlijst
    {
        public void Producten(Kruidenierswaren first, Verswaren second)
        {
            Product[] Producten;
        }
    }

    public abstract class Product
    {
        string naam;
        int aantal;
    }

    public class Kruidenierswaren : Product
    {
        public Kruidenierswaren(string naam, int aantal)
        {
            string Naam = naam;
            int Aantal = aantal;
        }
    }

    public class Verswaren : Product
    {
        public Verswaren(string naam, int aantal)
        {
            string Naam = naam;
            int Aantal = aantal;
        }
    }
}
