using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06WywolywanieKonstruktorow
{
    class Czlowiek
    {
        public string Imie;
        public string Nazwisko;


        public Czlowiek(string nazwisko)
        {
            nazwisko = Nazwisko;
        }
        public Czlowiek(string nazwisko, string imie) : this(nazwisko)
        {
            imie = Imie;
        }
    }
}
