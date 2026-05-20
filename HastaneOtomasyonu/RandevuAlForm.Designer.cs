namespace HastaneOtomasyonu
{
    partial class RandevuAlForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Seçimi:";
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(170, 37);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(250, 25);
            this.cmbHasta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor Seçimi:";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(170, 87);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(250, 25);
            this.cmbDoktor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(50, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Randevu Tarihi:";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpRandevuTarihi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpRandevuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(170, 137);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(250, 25);
            this.dtpRandevuTarihi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(50, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şikayet:";
            // 
            // txtSikayet
            // 
            this.txtSikayet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSikayet.Location = new System.Drawing.Point(170, 187);
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(250, 80);
            this.txtSikayet.TabIndex = 7;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevuAl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRandevuAl.Location = new System.Drawing.Point(170, 290);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(150, 40);
            this.btnRandevuAl.TabIndex = 8;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // RandevuAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.txtSikayet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpRandevuTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RandevuAlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Randevu";
            this.Load += new System.EventHandler(this.RandevuAlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.Button btnRandevuAl;
    }
}
