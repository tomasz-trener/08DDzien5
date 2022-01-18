using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08KomunikacjaPomiedzyFormularzami
{
    public partial class FrmStartowy : Form
    {

        FrmSzczegoly fs;

        public Label LblOdpowiedz
        {
            get { return lblOdpowiedz; }
        }

        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnOtworzNoweOkno_Click(object sender, EventArgs e)
        {
            fs = new FrmSzczegoly(this);
            fs.Show();
             
        }

        private void bnWyslij_Click(object sender, EventArgs e)
        {
            fs.LblOdpowiedz.Text = txtWiadomosc.Text;
        }
    }
}
