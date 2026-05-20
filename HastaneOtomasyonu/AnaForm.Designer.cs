namespace HastaneOtomasyonu
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnHastaListele = new System.Windows.Forms.Button();
            this.btnDoktorListele = new System.Windows.Forms.Button();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.Location = new System.Drawing.Point(50, 50);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(120, 70);
            this.btnHastaEkle.TabIndex = 0;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = true;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Location = new System.Drawing.Point(190, 50);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(120, 70);
            this.btnDoktorEkle.TabIndex = 1;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(330, 50);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(120, 70);
            this.btnRandevuAl.TabIndex = 2;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnHastaListele
            // 
            this.btnHastaListele.Location = new System.Drawing.Point(50, 140);
            this.btnHastaListele.Name = "btnHastaListele";
            this.btnHastaListele.Size = new System.Drawing.Size(120, 70);
            this.btnHastaListele.TabIndex = 3;
            this.btnHastaListele.Text = "Hasta Listele";
            this.btnHastaListele.UseVisualStyleBackColor = true;
            this.btnHastaListele.Click += new System.EventHandler(this.btnHastaListele_Click);
            // 
            // btnDoktorListele
            // 
            this.btnDoktorListele.Location = new System.Drawing.Point(190, 140);
            this.btnDoktorListele.Name = "btnDoktorListele";
            this.btnDoktorListele.Size = new System.Drawing.Size(120, 70);
            this.btnDoktorListele.TabIndex = 4;
            this.btnDoktorListele.Text = "Doktor Listele";
            this.btnDoktorListele.UseVisualStyleBackColor = true;
            this.btnDoktorListele.Click += new System.EventHandler(this.btnDoktorListele_Click);
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.Location = new System.Drawing.Point(330, 140);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(120, 70);
            this.btnRandevuListele.TabIndex = 5;
            this.btnRandevuListele.Text = "Randevu Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = true;
            this.btnRandevuListele.Click += new System.EventHandler(this.btnRandevuListele_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(512, 271);
            this.Controls.Add(this.btnRandevuListele);
            this.Controls.Add(this.btnDoktorListele);
            this.Controls.Add(this.btnHastaListele);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.btnHastaEkle);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Button btnHastaListele;
        private System.Windows.Forms.Button btnDoktorListele;
        private System.Windows.Forms.Button btnRandevuListele;
    }
}
