﻿using P02AplikacjaZawodnicy;
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

namespace P09AplikacjaZawodnicy
{
    public partial class FrmZawodnicy : Form
    {
        ManagerZawodnikow mz;
        public FrmZawodnicy()
        {
            InitializeComponent();
            foreach (var k in Zawodnik.Kolumny)
                clbKolumny.Items.Add(k.Nazwa, k.Widocznosc);

        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            if (chLoklnie.Checked)
                mz = new ManagerZawodnikow(txtSciezka.Text, RodzajImportu.Lokalne);
            else
                mz = new ManagerZawodnikow();

            odswiez();
        }

        private void odswiez() // ponownie pobiera zawodnikow z pliku 
        {
            List<string> kolumny = new List<string>();

            foreach (var k in clbKolumny.CheckedItems)
                kolumny.Add(k.ToString());

            Zawodnik[] zawodnicy = null;
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

            if (zawodnicy != null)
            {
                lbDane.DisplayMember = "WidoczneKolumny";
                lbDane.DataSource = zawodnicy;// rzutowanie niejawne
            }


        }

        private void btnUstawSciezke_Click(object sender, EventArgs e)
        {
            ofdOtwiwarciePliku.Title = "Wskaz ścieżke do pliku";
            ofdOtwiwarciePliku.InitialDirectory = @"c:\dane";
            ofdOtwiwarciePliku.Filter = "TXT files|*.txt";

            if (ofdOtwiwarciePliku.ShowDialog() == DialogResult.OK)
            {
                string sciezka = ofdOtwiwarciePliku.FileName;
                txtSciezka.Text = sciezka;
            }
        }
    }
}