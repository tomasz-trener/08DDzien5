
namespace P02AplikacjaZawodnicy
{
    partial class Form1
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.numWaga = new System.Windows.Forms.NumericUpDown();
            this.nunWzrost = new System.Windows.Forms.NumericUpDown();
            this.chLoklnie = new System.Windows.Forms.CheckBox();
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.ofdOtwiwarciePliku = new System.Windows.Forms.OpenFileDialog();
            this.btnUstawSciezke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCzysc = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnNowy = new System.Windows.Forms.Button();
            this.clbKolumny = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunWzrost)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 46);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(334, 238);
            this.lbDane.TabIndex = 0;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 13);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(370, 62);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(151, 20);
            this.txtImie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(370, 103);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(151, 20);
            this.txtNazwisko.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kraj";
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(370, 143);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(151, 20);
            this.txtKraj.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data urodzenia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Waga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Wzrost";
            // 
            // dtpDataUrodzenia
            // 
            this.dtpDataUrodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataUrodzenia.Location = new System.Drawing.Point(370, 182);
            this.dtpDataUrodzenia.Name = "dtpDataUrodzenia";
            this.dtpDataUrodzenia.Size = new System.Drawing.Size(151, 20);
            this.dtpDataUrodzenia.TabIndex = 14;
            // 
            // numWaga
            // 
            this.numWaga.Location = new System.Drawing.Point(370, 222);
            this.numWaga.Name = "numWaga";
            this.numWaga.Size = new System.Drawing.Size(151, 20);
            this.numWaga.TabIndex = 15;
            // 
            // nunWzrost
            // 
            this.nunWzrost.Location = new System.Drawing.Point(370, 264);
            this.nunWzrost.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nunWzrost.Name = "nunWzrost";
            this.nunWzrost.Size = new System.Drawing.Size(151, 20);
            this.nunWzrost.TabIndex = 16;
            // 
            // chLoklnie
            // 
            this.chLoklnie.AutoSize = true;
            this.chLoklnie.Checked = true;
            this.chLoklnie.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLoklnie.Location = new System.Drawing.Point(94, 18);
            this.chLoklnie.Name = "chLoklnie";
            this.chLoklnie.Size = new System.Drawing.Size(66, 17);
            this.chLoklnie.TabIndex = 17;
            this.chLoklnie.Text = "Lokalnie";
            this.chLoklnie.UseVisualStyleBackColor = true;
            // 
            // txtSciezka
            // 
            this.txtSciezka.Location = new System.Drawing.Point(167, 15);
            this.txtSciezka.Name = "txtSciezka";
            this.txtSciezka.Size = new System.Drawing.Size(179, 20);
            this.txtSciezka.TabIndex = 18;
            // 
            // ofdOtwiwarciePliku
            // 
            this.ofdOtwiwarciePliku.FileName = "openFileDialog1";
            // 
            // btnUstawSciezke
            // 
            this.btnUstawSciezke.Location = new System.Drawing.Point(370, 15);
            this.btnUstawSciezke.Name = "btnUstawSciezke";
            this.btnUstawSciezke.Size = new System.Drawing.Size(151, 21);
            this.btnUstawSciezke.TabIndex = 19;
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
            this.groupBox1.Location = new System.Drawing.Point(527, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 238);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";
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
            // clbKolumny
            // 
            this.clbKolumny.FormattingEnabled = true;
            this.clbKolumny.Location = new System.Drawing.Point(7, 148);
            this.clbKolumny.Name = "clbKolumny";
            this.clbKolumny.Size = new System.Drawing.Size(86, 79);
            this.clbKolumny.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUstawSciezke);
            this.Controls.Add(this.txtSciezka);
            this.Controls.Add(this.chLoklnie);
            this.Controls.Add(this.nunWzrost);
            this.Controls.Add(this.numWaga);
            this.Controls.Add(this.dtpDataUrodzenia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numWaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nunWzrost)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataUrodzenia;
        private System.Windows.Forms.NumericUpDown numWaga;
        private System.Windows.Forms.NumericUpDown nunWzrost;
        private System.Windows.Forms.CheckBox chLoklnie;
        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.OpenFileDialog ofdOtwiwarciePliku;
        private System.Windows.Forms.Button btnUstawSciezke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCzysc;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnNowy;
        private System.Windows.Forms.CheckedListBox clbKolumny;
    }
}

