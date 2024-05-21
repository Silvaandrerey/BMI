using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnHasilBMI_Click(object sender, EventArgs e)
        {
            double beratbadan;
            double tinggibadan;
            double hasilBMI;

            beratbadan = Convert.ToDouble(txtBeratBadan.Text);
            tinggibadan = (0.01 * Convert.ToDouble(txtTinggiBadan.Text)) * (0.01 * Convert.ToDouble(txtTinggiBadan.Text));

            hasilBMI = beratbadan / tinggibadan;

            txtHasilBMI.Text = hasilBMI.ToString();

            if (hasilBMI < 18.5)
            {
                lblKeteranganHasil.Text = " Hai " + txtNama.Text + " Berat Badan Anda Kurang";
            }
            else if (hasilBMI > 18.5 && hasilBMI <= 22.9)
            {
                lblKeteranganHasil.Text = " Hai " + txtNama.Text + " Berat Badan Anda Normal";
            }
            else if (hasilBMI > 23 && hasilBMI <= 29.9)
            {
                lblKeteranganHasil.Text = " Hai " + txtNama.Text + " Berat Badan Anda Berlebihan (kecenderung Obesitas)";
            }
            else
            {
                lblKeteranganHasil.Text = " Hai " + txtNama.Text + " Berat Badan Anda Obesitas)";
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult psn = MessageBox.Show("Ingin Menghapus Data BMI" + "?", "Hapus Data BMI", MessageBoxButtons.YesNo);
            if (psn == DialogResult.Yes)
            {
                txtNama.Text = " ";
                txtUsia.Text = " ";
                cmbJenisKelamin.Text = " ";
                txtBeratBadan.Text = " ";
                txtTinggiBadan.Text = " ";
                txtHasilBMI.Text = " ";
                lblKeteranganHasil.Text = " ";
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
