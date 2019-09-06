namespace RadnickiDeo
{
    partial class FormaZaPrikupljanjeInformacijaSaKartice
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
            this.lbl_KorRac = new System.Windows.Forms.Label();
            this.txt_BrojKartice = new System.Windows.Forms.TextBox();
            this.btn_Kraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_KorRac
            // 
            this.lbl_KorRac.AutoSize = true;
            this.lbl_KorRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_KorRac.Location = new System.Drawing.Point(30, 112);
            this.lbl_KorRac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_KorRac.Name = "lbl_KorRac";
            this.lbl_KorRac.Size = new System.Drawing.Size(286, 26);
            this.lbl_KorRac.TabIndex = 0;
            this.lbl_KorRac.Text = "Unesite Vaš korisnički račun";
            // 
            // txt_BrojKartice
            // 
            this.txt_BrojKartice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_BrojKartice.Location = new System.Drawing.Point(69, 162);
            this.txt_BrojKartice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_BrojKartice.Name = "txt_BrojKartice";
            this.txt_BrojKartice.Size = new System.Drawing.Size(181, 29);
            this.txt_BrojKartice.TabIndex = 1;
            // 
            // btn_Kraj
            // 
            this.btn_Kraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Kraj.Location = new System.Drawing.Point(117, 213);
            this.btn_Kraj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Kraj.Name = "btn_Kraj";
            this.btn_Kraj.Size = new System.Drawing.Size(83, 35);
            this.btn_Kraj.TabIndex = 2;
            this.btn_Kraj.Text = "Kraj";
            this.btn_Kraj.UseVisualStyleBackColor = true;
            this.btn_Kraj.Click += new System.EventHandler(this.btn_Kraj_Click);
            // 
            // FormaZaPrikupljanjeInformacijaSaKartice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 316);
            this.Controls.Add(this.btn_Kraj);
            this.Controls.Add(this.txt_BrojKartice);
            this.Controls.Add(this.lbl_KorRac);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaZaPrikupljanjeInformacijaSaKartice";
            this.Text = "FormaZaPrikupljanjeInformacijaSaKartice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormaZaPrikupljanjeInformacijaSaKartice_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KorRac;
        private System.Windows.Forms.TextBox txt_BrojKartice;
        private System.Windows.Forms.Button btn_Kraj;
    }
}