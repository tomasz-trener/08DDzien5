using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Wlasciwosci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Czlowiek c = new Czlowiek()
            //{
            //    imie = "Jan",
            //    nazwisko = "Kowalski"
            //};


            Czlowiek c = new Czlowiek();
            c.ImieNazwisko = "Adam Nowak";

            Console.WriteLine(c.ImieNazwisko);

            int n = c.PoliczIleLiterMaNazwisko();

        }
    }
}
