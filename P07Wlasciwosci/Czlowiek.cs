using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Wlasciwosci
{
    class Czlowiek
    {
        private string imie;
        private string nazwisko;

        public string ImieNazwisko
        {
            get
            {
                return imie + " " + nazwisko;
            }
            set
            {
                string toCoPrzychodzi = value;
                var tab = toCoPrzychodzi.Split(' ');
                imie =tab[0];
                nazwisko = tab[1];
            }

        }

        public int PoliczIleLiterMaNazwisko()
        {
            return nazwisko.Length;
        }

    }
}
