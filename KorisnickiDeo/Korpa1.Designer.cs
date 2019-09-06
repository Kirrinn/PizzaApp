namespace KorisnickiDeo
{
    partial class Korpa1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IzbrisiKorpa1 = new System.Windows.Forms.Button();
            this.btn_NazadKorpa1 = new System.Windows.Forms.Button();
            this.txt_BrojPorudzbineKorpa1 = new System.Windows.Forms.TextBox();
            this.txt_ListaPorudzbinaKorpa1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lista porudžbina";
            // 
            // btn_IzbrisiKorpa1
            // 
            this.btn_IzbrisiKorpa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_IzbrisiKorpa1.Location = new System.Drawing.Point(235, 263);
            this.btn_IzbrisiKorpa1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_IzbrisiKorpa1.Name = "btn_IzbrisiKorpa1";
            this.btn_IzbrisiKorpa1.Size = new System.Drawing.Size(84, 48);
            this.btn_IzbrisiKorpa1.TabIndex = 9;
            this.btn_IzbrisiKorpa1.Text = "Izbriši";
            this.btn_IzbrisiKorpa1.UseVisualStyleBackColor = true;
            // 
            // btn_NazadKorpa1
            // 
            this.btn_NazadKorpa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_NazadKorpa1.Location = new System.Drawing.Point(235, 175);
            this.btn_NazadKorpa1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NazadKorpa1.Name = "btn_NazadKorpa1";
            this.btn_NazadKorpa1.Size = new System.Drawing.Size(84, 48);
            this.btn_NazadKorpa1.TabIndex = 8;
            this.btn_NazadKorpa1.Text = "Nazad";
            this.btn_NazadKorpa1.UseVisualStyleBackColor = true;
            this.btn_NazadKorpa1.Click += new System.EventHandler(this.btn_NazadKorpa1_Click);
            // 
            // txt_BrojPorudzbineKorpa1
            // 
            this.txt_BrojPorudzbineKorpa1.Location = new System.Drawing.Point(277, 93);
            this.txt_BrojPorudzbineKorpa1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BrojPorudzbineKorpa1.Multiline = true;
            this.txt_BrojPorudzbineKorpa1.Name = "txt_BrojPorudzbineKorpa1";
            this.txt_BrojPorudzbineKorpa1.Size = new System.Drawing.Size(30, 26);
            this.txt_BrojPorudzbineKorpa1.TabIndex = 7;
            // 
            // txt_ListaPorudzbinaKorpa1
            // 
            this.txt_ListaPorudzbinaKorpa1.Location = new System.Drawing.Point(22, 76);
            this.txt_ListaPorudzbinaKorpa1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ListaPorudzbinaKorpa1.Multiline = true;
            this.txt_ListaPorudzbinaKorpa1.Name = "txt_ListaPorudzbinaKorpa1";
            this.txt_ListaPorudzbinaKorpa1.Size = new System.Drawing.Size(166, 284);
            this.txt_ListaPorudzbinaKorpa1.TabIndex = 6;
            // 
            // Korpa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_IzbrisiKorpa1);
            this.Controls.Add(this.btn_NazadKorpa1);
            this.Controls.Add(this.txt_BrojPorudzbineKorpa1);
            this.Controls.Add(this.txt_ListaPorudzbinaKorpa1);
            this.Name = "Korpa1";
            this.Text = "Korpa1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_IzbrisiKorpa1;
        private System.Windows.Forms.Button btn_NazadKorpa1;
        private System.Windows.Forms.TextBox txt_BrojPorudzbineKorpa1;
        private System.Windows.Forms.TextBox txt_ListaPorudzbinaKorpa1;
    }
}