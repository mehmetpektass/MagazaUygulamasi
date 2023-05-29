namespace EntityUygulaması_Mağaza
{
    partial class FormAnaMenu
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
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnÜrünler = new System.Windows.Forms.Button();
            this.Btnİstatistikler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategori
            // 
            this.BtnKategori.Location = new System.Drawing.Point(22, 49);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(175, 125);
            this.BtnKategori.TabIndex = 0;
            this.BtnKategori.Text = "KATEGORİ İŞLEMLERİ";
            this.BtnKategori.UseVisualStyleBackColor = true;
            this.BtnKategori.Click += new System.EventHandler(this.BtnKategori_Click);
            // 
            // BtnÜrünler
            // 
            this.BtnÜrünler.Location = new System.Drawing.Point(203, 49);
            this.BtnÜrünler.Name = "BtnÜrünler";
            this.BtnÜrünler.Size = new System.Drawing.Size(175, 125);
            this.BtnÜrünler.TabIndex = 1;
            this.BtnÜrünler.Text = "ÜRÜN İŞLEMLERİ";
            this.BtnÜrünler.UseVisualStyleBackColor = true;
            this.BtnÜrünler.Click += new System.EventHandler(this.BtnÜrünler_Click);
            // 
            // Btnİstatistikler
            // 
            this.Btnİstatistikler.Location = new System.Drawing.Point(384, 49);
            this.Btnİstatistikler.Name = "Btnİstatistikler";
            this.Btnİstatistikler.Size = new System.Drawing.Size(175, 125);
            this.Btnİstatistikler.TabIndex = 1;
            this.Btnİstatistikler.Text = "İSTATİSTİKLER";
            this.Btnİstatistikler.UseVisualStyleBackColor = true;
            this.Btnİstatistikler.Click += new System.EventHandler(this.Btnİstatistikler_Click);
            // 
            // FormAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(597, 203);
            this.Controls.Add(this.Btnİstatistikler);
            this.Controls.Add(this.BtnÜrünler);
            this.Controls.Add(this.BtnKategori);
            this.MaximizeBox = false;
            this.Name = "FormAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü Formu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategori;
        private System.Windows.Forms.Button BtnÜrünler;
        private System.Windows.Forms.Button Btnİstatistikler;
    }
}