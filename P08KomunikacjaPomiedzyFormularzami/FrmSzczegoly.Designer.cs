
namespace P08KomunikacjaPomiedzyFormularzami
{
    partial class FrmSzczegoly
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
            this.lblOdpowiedz = new System.Windows.Forms.Label();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.txtWiadomosc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOdpowiedz
            // 
            this.lblOdpowiedz.AutoSize = true;
            this.lblOdpowiedz.Location = new System.Drawing.Point(75, 52);
            this.lblOdpowiedz.Name = "lblOdpowiedz";
            this.lblOdpowiedz.Size = new System.Drawing.Size(35, 13);
            this.lblOdpowiedz.TabIndex = 0;
            this.lblOdpowiedz.Text = "label1";
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(217, 47);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(100, 23);
            this.btnWyslij.TabIndex = 1;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // txtWiadomosc
            // 
            this.txtWiadomosc.Location = new System.Drawing.Point(217, 76);
            this.txtWiadomosc.Name = "txtWiadomosc";
            this.txtWiadomosc.Size = new System.Drawing.Size(100, 20);
            this.txtWiadomosc.TabIndex = 2;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 289);
            this.Controls.Add(this.txtWiadomosc);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.lblOdpowiedz);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdpowiedz;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.TextBox txtWiadomosc;
    }
}