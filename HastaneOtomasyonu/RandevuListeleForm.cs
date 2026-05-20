using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class RandevuListeleForm : Form
    {
        public RandevuListeleForm()
        {
            InitializeComponent();
        }

        private void RandevuListeleForm_Load(object sender, EventArgs e)
        {
            string sorgu = @"
                SELECT 
                    H.Ad AS [Hasta Adı], 
                    H.Soyad AS [Hasta Soyadı], 
                    D.Ad AS [Doktor Adı], 
                    D.Soyad AS [Doktor Soyadı], 
                    D.Brans AS [Branş], 
                    R.RandevuTarihi AS [Randevu Tarihi], 
                    R.Sikayet AS [Şikayet]
                FROM Randevular R
                JOIN Hastalar H ON R.HastaId = H.HastaId
                JOIN Doktorlar D ON R.DoktorId = D.DoktorId";
            
            dataGridView1.DataSource = Db.Listele(sorgu);
        }
    }
}
