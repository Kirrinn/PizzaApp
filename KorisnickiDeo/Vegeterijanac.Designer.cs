namespace KorisnickiDeo
{
    partial class Vegeterijanac
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
            this.lbl_veg = new System.Windows.Forms.Label();
            this.btn_DaVegeterijanac = new System.Windows.Forms.Button();
            this.btn_NeVegeterijanac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_veg
            // 
            this.lbl_veg.AutoSize = true;
            this.lbl_veg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_veg.Location = new System.Drawing.Point(52, 74);
            this.lbl_veg.Name = "lbl_veg";
            this.lbl_veg.Size = new System.Drawing.Size(261, 29);
            this.lbl_veg.TabIndex = 0;
            this.lbl_veg.Text = "Da li ste vegeterijanac?";
            // 
            // btn_DaVegeterijanac
            // 
            this.btn_DaVegeterijanac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_DaVegeterijanac.Location = new System.Drawing.Point(57, 150);
            this.btn_DaVegeterijanac.Name = "btn_DaVegeterijanac";
            this.btn_DaVegeterijanac.Size = new System.Drawing.Size(108, 50);
            this.btn_DaVegeterijanac.TabIndex = 1;
            this.btn_DaVegeterijanac.Text = "Da";
            this.btn_DaVegeterijanac.UseVisualStyleBackColor = true;
            this.btn_DaVegeterijanac.Click += new System.EventHandler(this.btn_DaVegeterijanac_Click);
            // 
            // btn_NeVegeterijanac
            // 
            this.btn_NeVegeterijanac.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_NeVegeterijanac.Location = new System.Drawing.Point(205, 150);
            this.btn_NeVegeterijanac.Name = "btn_NeVegeterijanac";
            this.btn_NeVegeterijanac.Size = new System.Drawing.Size(108, 50);
            this.btn_NeVegeterijanac.TabIndex = 2;
            this.btn_NeVegeterijanac.Text = "Ne";
            this.btn_NeVegeterijanac.UseVisualStyleBackColor = true;
            this.btn_NeVegeterijanac.Click += new System.EventHandler(this.btn_NeVegeterijanac_Click);
            // 
            // Vegeterijanac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 290);
            this.Controls.Add(this.btn_NeVegeterijanac);
            this.Controls.Add(this.btn_DaVegeterijanac);
            this.Controls.Add(this.lbl_veg);
            this.Name = "Vegeterijanac";
            this.Text = "Vegeterijanac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_veg;
        private System.Windows.Forms.Button btn_DaVegeterijanac;
        private System.Windows.Forms.Button btn_NeVegeterijanac;
    }
}