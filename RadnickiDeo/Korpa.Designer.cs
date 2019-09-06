namespace RadnickiDeo
{
    partial class Korpa
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
            this.components = new System.ComponentModel.Container();
            this.txt_ListaPorudzbina = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_BrojPorudzbine = new System.Windows.Forms.TextBox();
            this.btn_Nazad2 = new System.Windows.Forms.Button();
            this.btn_Izbrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ListaPorudzbina
            // 
            this.txt_ListaPorudzbina.Location = new System.Drawing.Point(31, 46);
            this.txt_ListaPorudzbina.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ListaPorudzbina.Multiline = true;
            this.txt_ListaPorudzbina.Name = "txt_ListaPorudzbina";
            this.txt_ListaPorudzbina.Size = new System.Drawing.Size(166, 284);
            this.txt_ListaPorudzbina.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_BrojPorudzbine
            // 
            this.txt_BrojPorudzbine.Location = new System.Drawing.Point(286, 63);
            this.txt_BrojPorudzbine.Margin = new System.Windows.Forms.Padding(2);
            this.txt_BrojPorudzbine.Multiline = true;
            this.txt_BrojPorudzbine.Name = "txt_BrojPorudzbine";
            this.txt_BrojPorudzbine.Size = new System.Drawing.Size(30, 26);
            this.txt_BrojPorudzbine.TabIndex = 2;
            // 
            // btn_Nazad2
            // 
            this.btn_Nazad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Nazad2.Location = new System.Drawing.Point(262, 145);
            this.btn_Nazad2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Nazad2.Name = "btn_Nazad2";
            this.btn_Nazad2.Size = new System.Drawing.Size(84, 48);
            this.btn_Nazad2.TabIndex = 3;
            this.btn_Nazad2.Text = "Nazad";
            this.btn_Nazad2.UseVisualStyleBackColor = true;
            this.btn_Nazad2.Click += new System.EventHandler(this.btn_Nazad2_Click);
            // 
            // btn_Izbrisi
            // 
            this.btn_Izbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Izbrisi.Location = new System.Drawing.Point(262, 233);
            this.btn_Izbrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Izbrisi.Name = "btn_Izbrisi";
            this.btn_Izbrisi.Size = new System.Drawing.Size(84, 48);
            this.btn_Izbrisi.TabIndex = 4;
            this.btn_Izbrisi.Text = "Izbriši";
            this.btn_Izbrisi.UseVisualStyleBackColor = true;
            this.btn_Izbrisi.Click += new System.EventHandler(this.btn_Izbrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lista porudžbina";
            // 
            // Korpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Izbrisi);
            this.Controls.Add(this.btn_Nazad2);
            this.Controls.Add(this.txt_BrojPorudzbine);
            this.Controls.Add(this.txt_ListaPorudzbina);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Korpa";
            this.Text = "Korpa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Korpa_FormClosed);
            this.Load += new System.EventHandler(this.Korpa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ListaPorudzbina;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_BrojPorudzbine;
        private System.Windows.Forms.Button btn_Nazad2;
        private System.Windows.Forms.Button btn_Izbrisi;
        private System.Windows.Forms.Label label1;
    }
}