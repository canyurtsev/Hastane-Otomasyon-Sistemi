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
    public partial class DoktorEkleForm : Form
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "INSERT INTO Doktorlar (Ad, Soyad, Brans, Telefon) VALUES (@ad, @soyad, @brans, @tel)";
                SqlParameter[] p = {
                    new SqlParameter("@ad", txtAd.Text),
                    new SqlParameter("@soyad", txtSoyad.Text),
                    new SqlParameter("@brans", txtBrans.Text),
                    new SqlParameter("@tel", txtTelefon.Text)
                };

                Db.KomutCalistir(sorgu, p);
                MessageBox.Show("Doktor başarıyla eklendi.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
