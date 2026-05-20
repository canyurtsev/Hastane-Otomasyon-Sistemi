using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnHastaEkle_Click(object sender, EventArgs e)
    {
        HastaEkleForm form = new HastaEkleForm();
        form.Show();
    }

    private void btnDoktorEkle_Click(object sender, EventArgs e)
    {
        DoktorEkleForm form = new DoktorEkleForm();
        form.Show();
    }

    private void btnRandevuAl_Click(object sender, EventArgs e)
    {
        RandevuAlForm form = new RandevuAlForm();
        form.Show();
    }

    private void btnHastaListele_Click(object sender, EventArgs e)
    {
        HastaListeleForm form = new HastaListeleForm();
        form.Show();
    }

    private void btnDoktorListele_Click(object sender, EventArgs e)
    {
        DoktorListeleForm form = new DoktorListeleForm();
        form.Show();
    }

    private void btnRandevuListele_Click(object sender, EventArgs e)
    {
        RandevuListeleForm form = new RandevuListeleForm();
        form.Show();
    }
}
