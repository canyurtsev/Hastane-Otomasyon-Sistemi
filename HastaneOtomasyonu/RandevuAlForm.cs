using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class RandevuAlForm : Form
    {
        public RandevuAlForm()
        {
            InitializeComponent();
        }

        private void RandevuAlForm_Load(object sender, EventArgs e)
        {
            HastalarıGetir();
            DoktorlarıGetir();
        }

        private void HastalarıGetir()
        {
            DataTable dt = Db.Listele("SELECT HastaId, Ad + ' ' + Soyad AS AdSoyad FROM Hastalar");
            cmbHasta.DataSource = dt;
            cmbHasta.DisplayMember = "AdSoyad";
            cmbHasta.ValueMember = "HastaId";
        }

        private void DoktorlarıGetir()
        {
            DataTable dt = Db.Listele("SELECT DoktorId, Ad + ' ' + Soyad + ' - ' + Brans AS DoktorBilgi FROM Doktorlar");
            cmbDoktor.DataSource = dt;
            cmbDoktor.DisplayMember = "DoktorBilgi";
            cmbDoktor.ValueMember = "DoktorId";
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbHasta.SelectedValue == null || cmbDoktor.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen hasta ve doktor seçiniz.");
                    return;
                }

                string sorgu = "INSERT INTO Randevular (HastaId, DoktorId, RandevuTarihi, Sikayet) VALUES (@hastaId, @doktorId, @tarih, @sikayet)";
                SqlParameter[] p = {
                    new SqlParameter("@hastaId", cmbHasta.SelectedValue),
                    new SqlParameter("@doktorId", cmbDoktor.SelectedValue),
                    new SqlParameter("@tarih", dtpRandevuTarihi.Value),
                    new SqlParameter("@sikayet", txtSikayet.Text)
                };

                Db.KomutCalistir(sorgu, p);
                MessageBox.Show("Randevu başarıyla oluşturuldu.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
