
namespace P09AplikacjaZawodnicy
{
    partial class FrmZawodnicy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.chLoklnie = new System.Windows.Forms.CheckBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnUstawSciezke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbKolumny = new System.Windows.Forms.CheckedListBox();
            this.btnCzysc = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.ofdOtwiwarciePliku = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSciezka
            // 
            this.txtSciezka.Location = new System.Drawing.Point(167, 7);
            this.txtSciezka.Name = "txtSciezka";
            this.txtSciezka.Size = new System.Drawing.Size(179, 20);
            this.txtSciezka.TabIndex = 22;
            // 
            // chLoklnie
            // 
            this.chLoklnie.AutoSize = true;
            this.chLoklnie.Checked = true;
            this.chLoklnie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLoklnie.Location = new System.Drawing.Point(94, 10);
            this.chLoklnie.Name = "chLoklnie";
            this.chLoklnie.Size = new System.Drawing.Size(66, 17);
            this.chLoklnie.TabIndex = 21;
            this.chLoklnie.Text = "Lokalnie";
            this.chLoklnie.UseVisualStyleBackColor = true;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 5);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 20;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 38);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(334, 238);
            this.lbDane.TabIndex = 19;
            // 
            // btnUstawSciezke
            // 
            this.btnUstawSciezke.Location = new System.Drawing.Point(352, 7);
            this.btnUstawSciezke.Name = "btnUstawSciezke";
            this.btnUstawSciezke.Size = new System.Drawing.Size(109, 21);
            this.btnUstawSciezke.TabIndex = 23;
            this.btnUstawSciezke.Text = "Ustaw ścieżke";
            this.btnUstawSciezke.UseVisualStyleBackColor = true;
            this.btnUstawSciezke.Click += new System.EventHandler(this.btnUstawSciezke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbKolumny);
            this.groupBox1.Controls.Add(this.btnCzysc);
            this.groupBox1.Controls.Add(this.btnUsun);
            this.groupBox1.Controls.Add(this.btnEdytuj);
            this.groupBox1.Controls.Add(this.btnNowy);
            this.groupBox1.Location = new System.Drawing.Point(352, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 238);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";
            // 
            // clbKolumny
            // 
            this.clbKolumny.FormattingEnabled = true;
            this.clbKolumny.Location = new System.Drawing.Point(7, 148);
            this.clbKolumny.Name = "clbKolumny";
            this.clbKolumny.Size = new System.Drawing.Size(86, 79);
            this.clbKolumny.TabIndex = 4;
            // 
            // btnCzysc
            // 
            this.btnCzysc.Location = new System.Drawing.Point(6, 118);
            this.btnCzysc.Name = "btnCzysc";
            this.btnCzysc.Size = new System.Drawing.Size(75, 23);
            this.btnCzysc.TabIndex = 3;
            this.btnCzysc.Text = "Czyść";
            this.btnCzysc.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(6, 89);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(6, 60);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 1;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnNowy
            // 
            this.btnNowy.Location = new System.Drawing.Point(6, 31);
            this.btnNowy.Name = "btnNowy";
            this.btnNowy.Size = new System.Drawing.Size(75, 23);
            this.btnNowy.TabIndex = 0;
            this.btnNowy.Text = "Nowy";
            this.btnNowy.UseVisualStyleBackColor = true;
            this.btnNowy.Click += new System.EventHandler(this.btnNowy_Click);
            // 
            // ofdOtwiwarciePliku
            // 
            this.ofdOtwiwarciePliku.FileName = "openFileDialog1";
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUstawSciezke);
            this.Controls.Add(this.txtSciezka);
            this.Controls.Add(this.chLoklnie);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Zawodnicy";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.CheckBox chLoklnie;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnUstawSciezke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbKolumny;
        private System.Windows.Forms.Button btnCzysc;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.OpenFileDialog ofdOtwiwarciePliku;
    }
}

