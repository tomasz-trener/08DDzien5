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
    public partial class FrmSzczegoly : Form
    {
        FrmStartowy frmStartowy;

        public FrmSzczegoly(FrmStartowy frmStartowy)
        {
            InitializeComponent();
            this.frmStartowy = frmStartowy;
        }

        public Label LblOdpowiedz
        {
            get { return lblOdpowiedz; }
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            frmStartowy.LblOdpowiedz.Text = txtWiadomosc.Text;
        }
    }
}
