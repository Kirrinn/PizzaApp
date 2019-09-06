namespace RadnickiDeo
{
    partial class NacinPorudzbine
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
            this.btn_Dostava = new System.Windows.Forms.Button();
            this.btn_Licno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Način porudžbine:";
            // 
            // btn_Dostava
            // 
            this.btn_Dostava.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Dostava.Location = new System.Drawing.Point(137, 124);
            this.btn_Dostava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Dostava.Name = "btn_Dostava";
            this.btn_Dostava.Size = new System.Drawing.Size(94, 54);
            this.btn_Dostava.TabIndex = 4;
            this.btn_Dostava.Text = "Dostava";
            this.btn_Dostava.UseVisualStyleBackColor = true;
            this.btn_Dostava.Click += new System.EventHandler(this.btn_Dostava_Click);
            // 
            // btn_Licno
            // 
            this.btn_Licno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Licno.Location = new System.Drawing.Point(39, 124);
            this.btn_Licno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Licno.Name = "btn_Licno";
            this.btn_Licno.Size = new System.Drawing.Size(93, 54);
            this.btn_Licno.TabIndex = 5;
            this.btn_Licno.Text = "Lično";
            this.btn_Licno.UseVisualStyleBackColor = true;
            // 
            // NacinPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 249);
            this.Controls.Add(this.btn_Licno);
            this.Controls.Add(this.btn_Dostava);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NacinPorudzbine";
            this.Text = "NacinPorudzbine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NacinPorudzbine_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Dostava;
        private System.Windows.Forms.Button btn_Licno;
    }
}