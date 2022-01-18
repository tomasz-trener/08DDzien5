
namespace P08KomunikacjaPomiedzyFormularzami
{
    partial class FrmStartowy
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
            this.btnOtworzNoweOkno = new System.Windows.Forms.Button();
            this.txtWiadomosc = new System.Windows.Forms.TextBox();
            this.bnWyslij = new System.Windows.Forms.Button();
            this.lblOdpowiedz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOtworzNoweOkno
            // 
            this.btnOtworzNoweOkno.Location = new System.Drawing.Point(12, 12);
            this.btnOtworzNoweOkno.Name = "btnOtworzNoweOkno";
            this.btnOtworzNoweOkno.Size = new System.Drawing.Size(97, 67);
            this.btnOtworzNoweOkno.TabIndex = 0;
            this.btnOtworzNoweOkno.Text = "Nowe okno";
            this.btnOtworzNoweOkno.UseVisualStyleBackColor = true;
            this.btnOtworzNoweOkno.Click += new System.EventHandler(this.btnOtworzNoweOkno_Click);
            // 
            // txtWiadomosc
            // 
            this.txtWiadomosc.Location = new System.Drawing.Point(127, 59);
            this.txtWiadomosc.Name = "txtWiadomosc";
            this.txtWiadomosc.Size = new System.Drawing.Size(100, 20);
            this.txtWiadomosc.TabIndex = 1;
            // 
            // bnWyslij
            // 
            this.bnWyslij.Location = new System.Drawing.Point(127, 13);
            this.bnWyslij.Name = "bnWyslij";
            this.bnWyslij.Size = new System.Drawing.Size(100, 40);
            this.bnWyslij.TabIndex = 2;
            this.bnWyslij.Text = "Wyslij";
            this.bnWyslij.UseVisualStyleBackColor = true;
            this.bnWyslij.Click += new System.EventHandler(this.bnWyslij_Click);
            // 
            // lblOdpowiedz
            // 
            this.lblOdpowiedz.AutoSize = true;
            this.lblOdpowiedz.Location = new System.Drawing.Point(289, 27);
            this.lblOdpowiedz.Name = "lblOdpowiedz";
            this.lblOdpowiedz.Size = new System.Drawing.Size(35, 13);
            this.lblOdpowiedz.TabIndex = 3;
            this.lblOdpowiedz.Text = "label1";
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 271);
            this.Controls.Add(this.lblOdpowiedz);
            this.Controls.Add(this.bnWyslij);
            this.Controls.Add(this.txtWiadomosc);
            this.Controls.Add(this.btnOtworzNoweOkno);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtworzNoweOkno;
        private System.Windows.Forms.TextBox txtWiadomosc;
        private System.Windows.Forms.Button bnWyslij;
        private System.Windows.Forms.Label lblOdpowiedz;
    }
}

