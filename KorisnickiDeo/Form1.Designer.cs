namespace KorisnickiDeo
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
            this.lbl_Dobrodošli = new System.Windows.Forms.Label();
            this.lbl_pitanje = new System.Windows.Forms.Label();
            this.btn_Gotove = new System.Windows.Forms.Button();
            this.btn_Nova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Dobrodošli
            // 
            this.lbl_Dobrodošli.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Dobrodošli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dobrodošli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Dobrodošli.Location = new System.Drawing.Point(295, 64);
            this.lbl_Dobrodošli.Name = "lbl_Dobrodošli";
            this.lbl_Dobrodošli.Size = new System.Drawing.Size(183, 49);
            this.lbl_Dobrodošli.TabIndex = 0;
            this.lbl_Dobrodošli.Text = "Dobrodošli";
            this.lbl_Dobrodošli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_pitanje
            // 
            this.lbl_pitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pitanje.Location = new System.Drawing.Point(98, 153);
            this.lbl_pitanje.Name = "lbl_pitanje";
            this.lbl_pitanje.Size = new System.Drawing.Size(654, 61);
            this.lbl_pitanje.TabIndex = 1;
            this.lbl_pitanje.Text = "Da li želite da poručite već gotove pice ili želite da napravite novu?";
            // 
            // btn_Gotove
            // 
            this.btn_Gotove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gotove.Location = new System.Drawing.Point(187, 279);
            this.btn_Gotove.Name = "btn_Gotove";
            this.btn_Gotove.Size = new System.Drawing.Size(138, 50);
            this.btn_Gotove.TabIndex = 2;
            this.btn_Gotove.Text = "Gotove pice";
            this.btn_Gotove.UseVisualStyleBackColor = true;
            this.btn_Gotove.Click += new System.EventHandler(this.btn_Gotove_Click);
            // 
            // btn_Nova
            // 
            this.btn_Nova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nova.Location = new System.Drawing.Point(465, 279);
            this.btn_Nova.Name = "btn_Nova";
            this.btn_Nova.Size = new System.Drawing.Size(144, 50);
            this.btn_Nova.TabIndex = 3;
            this.btn_Nova.Text = "Napravi novu picu";
            this.btn_Nova.UseVisualStyleBackColor = true;
            this.btn_Nova.Click += new System.EventHandler(this.btn_Nova_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Nova);
            this.Controls.Add(this.btn_Gotove);
            this.Controls.Add(this.lbl_pitanje);
            this.Controls.Add(this.lbl_Dobrodošli);
            this.Name = "Form1";
            this.Text = "Početna strana";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dobrodošli;
        private System.Windows.Forms.Label lbl_pitanje;
        private System.Windows.Forms.Button btn_Gotove;
        private System.Windows.Forms.Button btn_Nova;
    }
}

