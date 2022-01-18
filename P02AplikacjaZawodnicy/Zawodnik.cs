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
        private string[] kolumny;

        public static string[] Kolumny
        {
            get
            {
                return new string[]
                {
                    "Imie",
                    "Nazwisko",
                    "Kraj",
                    "DataUrodzenia",
                    "Wzrost",
                    "Waga"
                };
            }
        }

        public string WidoczneKolumny
        {
            get
            {
                string s = "";
                if (kolumny.Contains("Imie"))
                    s += Imie + " ";
                if (kolumny.Contains("Nazwisko"))
                    s += Nazwisko + " ";
                if (kolumny.Contains("Kraj"))
                    s += Kraj + " ";
                if (kolumny.Contains("DataUrodzenia"))
                    s += DataUrodzenia + " ";
                if (kolumny.Contains("Wzrost"))
                    s += Wzrost + " ";
                if (kolumny.Contains("Waga"))
                    s += Waga + " ";

                return s;
            }
        }

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

        public string ImieNazwisko { get { return Imie + " " + Nazwisko; } }


        public Zawodnik()
        {

        }
        public Zawodnik(string[] kolumny)
        {
            this.kolumny = kolumny;
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
