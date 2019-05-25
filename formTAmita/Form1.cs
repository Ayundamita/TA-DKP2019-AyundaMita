using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace formTAmita
{
    public partial class Form1 : Form
    {

    

        public Form1()
        {
            
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RESET_Click(object sender, EventArgs e)
        {
            BIAYA.Text = String.Empty;
            BIAYA1.Text = String.Empty;
            PAJAK.Text = String.Empty;
            PAJAK1.Text = String.Empty;
            ASURANSI0.Text = String.Empty;
            ASURANSI1.Text = String.Empty;
            BIAYATOTAL1.Text = String.Empty;
            BIAYATOTAL.Text = String.Empty;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void HITUNG_Click(object sender, EventArgs e)
        {
            
            try
            {
                BIAYA.Text = String.Empty;
                BIAYA1.Text = String.Empty;
                PAJAK.Text = String.Empty;
                PAJAK1.Text = String.Empty;
                ASURANSI0.Text = String.Empty;
                ASURANSI1.Text = String.Empty;
                BIAYATOTAL.Text = String.Empty;
                BIAYATOTAL1.Text = String.Empty;
                decimal jarak = Convert.ToDecimal(textBox1.Text);
                decimal berat = Convert.ToDecimal(textBox2.Text);
                decimal totala = 0;
                decimal totalb = 0;
                decimal bayar = 0;
                int pilihan;
                hargapaket hargap = new hargapaket();

                pilihan = comboBox1.SelectedIndex;

                if (comboBox1.SelectedIndex == 0)
                {
                    hargap.setharga(6000);

                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    hargap.setharga(9000);

                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    hargap.setharga(11000);

                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    hargap.setharga(15000);

                }
                else
                {
                    error_form error = new error_form();
                    error.Show();
                }

                totala = (jarak / 10 + berat) * hargap.getharga();
                BIAYA.Text = "BIAYA PENGIRIMAN MURNI";
                BIAYA1.Text = "Rp. " + totala;

                decimal pajak = totala / 50;

                PAJAK.Text = "PAJAK";
                PAJAK1.Text = "Rp. " + pajak;

                totalb = totala + pajak;

                decimal asuransi = totala / 10;

                if (Asuransi.Checked)
                {
                    bayar = totalb + asuransi;
                    ASURANSI0.Text = "ASURANSI";
                    ASURANSI1.Text = "Rp. " + asuransi;
                }
                else
                {
                    bayar = totalb;
                }

                BIAYATOTAL.Text = "BIAYA PENGIRIMAN TOTAL";
                BIAYATOTAL1.Text = "Rp. " + bayar;

            }
            catch
            {
                error1 Error1 = new error1();
                Error1.Show();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Asuransi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Anda yakin akan keluar?", "Paket Mitul", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void KETENTUAN_Click(object sender, EventArgs e)
        {
            ketentuan aboutus = new ketentuan();
            aboutus.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
