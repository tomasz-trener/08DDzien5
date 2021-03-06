using P02AplikacjaZawodnicy.Errors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();

            foreach (var k in Zawodnik.Kolumny)
                clbKolumny.Items.Add(k.Nazwa,k.Widocznosc);
            //for (int i = 0; i < Zawodnik.Kolumny.Length; i++)
            //{
            //    if(i<3)
            //        clbKolumny.Items.Add(Zawodnik.Kolumny[i],true);
            //    else
            //        clbKolumny.Items.Add(Zawodnik.Kolumny[i], false);
            //}

        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            // zadeklarowane zmienne zyja wewnatrz nawiasów , w których zostały
            // zadeklarowane 

     
            // ManagerZawodnikow mz;
            if (chLoklnie.Checked)
                mz = new ManagerZawodnikow(txtSciezka.Text, RodzajImportu.Lokalne);
            else
                mz = new ManagerZawodnikow();

            odswiez();
        }
        // 13:15
        private void odswiez() // ponownie pobiera zawodnikow z pliku 
        {
             List<string> kolumny = new List<string>();

            foreach (var k in clbKolumny.CheckedItems)
                kolumny.Add(k.ToString());

            Zawodnik[] zawodnicy=null; 
            try
            {
                zawodnicy = mz.WygenerujZawodnikow(kolumny.ToArray());
            }
            catch (NiepoprawnaSciezkaException ex)
            {
                MessageBox.Show(ex.Message, "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ZleSformatowaneDaneException ex)
            {
                MessageBox.Show(ex.Message, "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Bład wczytywania danych", "Błąd aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (zawodnicy !=null)
            {
                lbDane.DisplayMember = "WidoczneKolumny";
                lbDane.DataSource = zawodnicy;// rzutowanie niejawne
            }

           
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            // co sie zadzieje gdy ktos kliknie w inny element 

            // sprawdzic kto jest zaznaczony ? 
          
             Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            //  MessageBox.Show(s.DataUrodzenia.ToString());

            txtImie.Text = s.Imie;
            txtNazwisko.Text = s.Nazwisko;
            txtKraj.Text = s.Kraj;
            dtpDataUrodzenia.Value = s.DataUrodzenia;
            numWaga.Value = s.Waga;
            nunWzrost.Value = s.Wzrost;
        }

        private void btnUstawSciezke_Click(object sender, EventArgs e)
        {
            ofdOtwiwarciePliku.Title = "Wskaz ścieżke do pliku";
            ofdOtwiwarciePliku.InitialDirectory = @"c:\dane";
            ofdOtwiwarciePliku.Filter = "TXT files|*.txt";

            if (ofdOtwiwarciePliku.ShowDialog()  == DialogResult.OK)
            {
                string sciezka = ofdOtwiwarciePliku.FileName;
                txtSciezka.Text = sciezka;
            }
             

        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik();
            zczytajTextobxy(z);

            mz.Dodaj(z);
            odswiez();              // odświezenie listbox czyli wczytanie na nowo
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            // zczytac pola zawodnika z textboxow 
            Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            zczytajTextobxy(s);
            mz.Edytuj(s);
            odswiez();
        }

        private void zczytajTextobxy(Zawodnik z)
        {
            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUrodzenia = dtpDataUrodzenia.Value;
            z.Waga = Convert.ToInt32(numWaga.Value);
            z.Wzrost = Convert.ToInt32(nunWzrost.Value);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik s = (Zawodnik)lbDane.SelectedItem;
            mz.Usun(s.Id_zawodnika);
            odswiez();
        }
    }
}
