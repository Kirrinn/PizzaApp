namespace KorisnickiDeo
{
    partial class Potvrda
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
            this.txt_DodatneInfPotvrda = new System.Windows.Forms.TextBox();
            this.btn_PosaljiPotvrda = new System.Windows.Forms.Button();
            this.btn_NastavakKupovinePotvrda = new System.Windows.Forms.Button();
            this.btn_KrajKupovinePotvrda = new System.Windows.Forms.Button();
            this.lbl_Potvrda = new System.Windows.Forms.Label();
            this.btn_KorpaPotvrda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_DodatneInfPotvrda
            // 
            this.txt_DodatneInfPotvrda.Location = new System.Drawing.Point(70, 24);
            this.txt_DodatneInfPotvrda.Multiline = true;
            this.txt_DodatneInfPotvrda.Name = "txt_DodatneInfPotvrda";
            this.txt_DodatneInfPotvrda.Size = new System.Drawing.Size(297, 116);
            this.txt_DodatneInfPotvrda.TabIndex = 0;
            // 
            // btn_PosaljiPotvrda
            // 
            this.btn_PosaljiPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_PosaljiPotvrda.Location = new System.Drawing.Point(236, 159);
            this.btn_PosaljiPotvrda.Name = "btn_PosaljiPotvrda";
            this.btn_PosaljiPotvrda.Size = new System.Drawing.Size(114, 55);
            this.btn_PosaljiPotvrda.TabIndex = 1;
            this.btn_PosaljiPotvrda.Text = "Pošalji";
            this.btn_PosaljiPotvrda.UseVisualStyleBackColor = true;
            // 
            // btn_NastavakKupovinePotvrda
            // 
            this.btn_NastavakKupovinePotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_NastavakKupovinePotvrda.Location = new System.Drawing.Point(70, 342);
            this.btn_NastavakKupovinePotvrda.Name = "btn_NastavakKupovinePotvrda";
            this.btn_NastavakKupovinePotvrda.Size = new System.Drawing.Size(114, 55);
            this.btn_NastavakKupovinePotvrda.TabIndex = 2;
            this.btn_NastavakKupovinePotvrda.Text = "Nastavak kupovine";
            this.btn_NastavakKupovinePotvrda.UseVisualStyleBackColor = true;
            this.btn_NastavakKupovinePotvrda.Click += new System.EventHandler(this.btn_NastavakKupovinePotvrda_Click);
            // 
            // btn_KrajKupovinePotvrda
            // 
            this.btn_KrajKupovinePotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_KrajKupovinePotvrda.Location = new System.Drawing.Point(236, 342);
            this.btn_KrajKupovinePotvrda.Name = "btn_KrajKupovinePotvrda";
            this.btn_KrajKupovinePotvrda.Size = new System.Drawing.Size(114, 55);
            this.btn_KrajKupovinePotvrda.TabIndex = 3;
            this.btn_KrajKupovinePotvrda.Text = "Kraj kupovine";
            this.btn_KrajKupovinePotvrda.UseVisualStyleBackColor = true;
            this.btn_KrajKupovinePotvrda.Click += new System.EventHandler(this.btn_KrajKupovinePotvrda_Click);
            // 
            // lbl_Potvrda
            // 
            this.lbl_Potvrda.AutoSize = true;
            this.lbl_Potvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_Potvrda.Location = new System.Drawing.Point(163, 267);
            this.lbl_Potvrda.Name = "lbl_Potvrda";
            this.lbl_Potvrda.Size = new System.Drawing.Size(95, 29);
            this.lbl_Potvrda.TabIndex = 4;
            this.lbl_Potvrda.Text = "Potvrda";
            // 
            // btn_KorpaPotvrda
            // 
            this.btn_KorpaPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_KorpaPotvrda.Location = new System.Drawing.Point(70, 159);
            this.btn_KorpaPotvrda.Name = "btn_KorpaPotvrda";
            this.btn_KorpaPotvrda.Size = new System.Drawing.Size(114, 55);
            this.btn_KorpaPotvrda.TabIndex = 5;
            this.btn_KorpaPotvrda.Text = "Korpa";
            this.btn_KorpaPotvrda.UseVisualStyleBackColor = true;
            this.btn_KorpaPotvrda.Click += new System.EventHandler(this.btn_KorpaPotvrda_Click);
            // 
            // Potvrda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.btn_KorpaPotvrda);
            this.Controls.Add(this.lbl_Potvrda);
            this.Controls.Add(this.btn_KrajKupovinePotvrda);
            this.Controls.Add(this.btn_NastavakKupovinePotvrda);
            this.Controls.Add(this.btn_PosaljiPotvrda);
            this.Controls.Add(this.txt_DodatneInfPotvrda);
            this.Name = "Potvrda";
            this.Text = "Potvrda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_DodatneInfPotvrda;
        private System.Windows.Forms.Button btn_PosaljiPotvrda;
        private System.Windows.Forms.Button btn_NastavakKupovinePotvrda;
        private System.Windows.Forms.Button btn_KrajKupovinePotvrda;
        private System.Windows.Forms.Label lbl_Potvrda;
        private System.Windows.Forms.Button btn_KorpaPotvrda;
    }
}