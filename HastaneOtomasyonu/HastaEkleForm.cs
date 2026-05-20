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
    public partial class HastaEkleForm : Form
    {
        public HastaEkleForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO Hastalar (TCKimlik, Ad, Soyad, Telefon, Adres, DogumTarihi) VALUES (@tc, @ad, @soyad, @tel, @adres, @dogum)";
                SqlParameter[] p = {
                    new SqlParameter("@tc", txtTC.Text),
                    new SqlParameter("@ad", txtAd.Text),
                    new SqlParameter("@soyad", txtSoyad.Text),
                    new SqlParameter("@tel", txtTelefon.Text),
                    new SqlParameter("@adres", txtAdres.Text),
                    new SqlParameter("@dogum", dtpDogumTarihi.Value)
                };

                Db.KomutCalistir(sorgu, p);
                MessageBox.Show("Hasta başarıyla eklendi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
