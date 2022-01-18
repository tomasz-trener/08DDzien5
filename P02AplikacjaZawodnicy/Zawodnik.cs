using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaZawodnicy
{
    class Zawodnik
    {
        public int Id_zawodnika;
        public int Id_trenera;
        public string Imie; 
        public string Nazwisko { get; set; }
        public string Kraj;
        public DateTime DataUrodzenia; 
        public int Wzrost;
        public int Waga;

        public string DataUrodzeniaFormat
        {
            get { return DataUrodzenia.ToString("yyyy-MM-dd"); }
        }


        public string Wiersz
        {
            get
            {
                return $"{Id_zawodnika};{Id_trenera};{Imie};{Nazwisko};{Kraj};{DataUrodzeniaFormat};{Wzrost};{Waga}";
            }
        }

        public Zawodnik()
        {
            //13:30 
        }

        public Zawodnik(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string PrzedstawSie()
        {
            return $"Nazywam się {Imie} {Nazwisko} i pochodzę z {Kraj}";
        }
    }
}
