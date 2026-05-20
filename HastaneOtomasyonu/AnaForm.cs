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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            HastaEkleForm f = new HastaEkleForm();
            f.ShowDialog();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            DoktorEkleForm f = new DoktorEkleForm();
            f.ShowDialog();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            RandevuAlForm f = new RandevuAlForm();
            f.ShowDialog();
        }

        private void btnHastaListele_Click(object sender, EventArgs e)
        {
            HastaListeleForm f = new HastaListeleForm();
            f.ShowDialog();
        }

        private void btnDoktorListele_Click(object sender, EventArgs e)
        {
            DoktorListeleForm f = new DoktorListeleForm();
            f.ShowDialog();
        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            RandevuListeleForm f = new RandevuListeleForm();
            f.ShowDialog();
        }
    }
}
