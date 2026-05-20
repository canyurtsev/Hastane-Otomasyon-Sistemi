namespace HastaneOtomasyonu
{
    partial class Form1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.btnHastaListele = new System.Windows.Forms.Button();
            this.btnDoktorListele = new System.Windows.Forms.Button();
            this.btnRandevuListele = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBaslik.Location = new System.Drawing.Point(0, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(600, 50);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "Hastane Otomasyonu";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHastaEkle.Location = new System.Drawing.Point(50, 100);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(130, 60);
            this.btnHastaEkle.TabIndex = 0;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDoktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoktorEkle.Location = new System.Drawing.Point(235, 100);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(130, 60);
            this.btnDoktorEkle.TabIndex = 1;
            this.btnDoktorEkle.Text = "Doktor Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = false;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuAl.Location = new System.Drawing.Point(420, 100);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(130, 60);
            this.btnRandevuAl.TabIndex = 2;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // btnHastaListele
            // 
            this.btnHastaListele.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHastaListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaListele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHastaListele.Location = new System.Drawing.Point(50, 200);
            this.btnHastaListele.Name = "btnHastaListele";
            this.btnHastaListele.Size = new System.Drawing.Size(130, 60);
            this.btnHastaListele.TabIndex = 3;
            this.btnHastaListele.Text = "Hasta Listele";
            this.btnHastaListele.UseVisualStyleBackColor = false;
            this.btnHastaListele.Click += new System.EventHandler(this.btnHastaListele_Click);
            // 
            // btnDoktorListele
            // 
            this.btnDoktorListele.BackColor = System.Drawing.Color.AliceBlue;
            this.btnDoktorListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorListele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDoktorListele.Location = new System.Drawing.Point(235, 200);
            this.btnDoktorListele.Name = "btnDoktorListele";
            this.btnDoktorListele.Size = new System.Drawing.Size(130, 60);
            this.btnDoktorListele.TabIndex = 4;
            this.btnDoktorListele.Text = "Doktor Listele";
            this.btnDoktorListele.UseVisualStyleBackColor = false;
            this.btnDoktorListele.Click += new System.EventHandler(this.btnDoktorListele_Click);
            // 
            // btnRandevuListele
            // 
            this.btnRandevuListele.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRandevuListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuListele.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuListele.Location = new System.Drawing.Point(420, 200);
            this.btnRandevuListele.Name = "btnRandevuListele";
            this.btnRandevuListele.Size = new System.Drawing.Size(130, 60);
            this.btnRandevuListele.TabIndex = 5;
            this.btnRandevuListele.Text = "Randevu Listele";
            this.btnRandevuListele.UseVisualStyleBackColor = false;
            this.btnRandevuListele.Click += new System.EventHandler(this.btnRandevuListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnRandevuListele);
            this.Controls.Add(this.btnDoktorListele);
            this.Controls.Add(this.btnHastaListele);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.btnHastaEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu - Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Button btnHastaListele;
        private System.Windows.Forms.Button btnDoktorListele;
        private System.Windows.Forms.Button btnRandevuListele;
        private System.Windows.Forms.Label lblBaslik;
    }
}