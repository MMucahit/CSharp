using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnİslem_Click(object sender, EventArgs e)
        {
            int sayı1;
            int sayı2;
            int sonuc;

            if (cbxToplama.Checked == false && cbxCıkarma.Checked == false && cbxCarpma.Checked == false && cbxBolme.Checked == false)
            {
                MessageBox.Show("Lütfen işlem seçiniz.");

            }


            if (tbxSayı1.Text == "" || tbxSayı2.Text == "" )
            {
                MessageBox.Show("Lütfen sayıları giriniz.");
            }

            else
            {

                if (cbxToplama.Checked == true)
                {
                    try
                    {
                        sayı1 = Convert.ToInt32(tbxSayı1.Text);
                        sayı2 = Convert.ToInt32(tbxSayı2.Text);
                        sonuc = sayı1 + sayı2;
                        lblSonuc.Text = sonuc.ToString();
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Lütfen sadece sayı giriniz.");
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }

                    cbxToplama.Checked = false;
                    cbxBolme.Enabled = true;
                    cbxCarpma.Enabled = true;
                    cbxCıkarma.Enabled = true;
                }

                if (cbxCıkarma.Checked == true)
                {
                    try
                    {
                        sayı1 = Convert.ToInt32(tbxSayı1.Text);
                        sayı2 = Convert.ToInt32(tbxSayı2.Text);
                        sonuc = sayı1 - sayı2;
                        lblSonuc.Text = sonuc.ToString();
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen sadece sayı giriniz.");
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }

                    cbxCıkarma.Checked = false;
                    cbxBolme.Enabled = true;
                    cbxCarpma.Enabled = true;
                    cbxToplama.Enabled = true;
                }

                if (cbxCarpma.Checked == true)
                {
                    try
                    {
                        sayı1 = Convert.ToInt32(tbxSayı1.Text);
                        sayı2 = Convert.ToInt32(tbxSayı2.Text);
                        sonuc = sayı1 * sayı2;
                        lblSonuc.Text = sonuc.ToString();
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen sadece sayı giriniz.");
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }
                    cbxCarpma.Checked = false;
                    cbxBolme.Enabled = true;
                    cbxToplama.Enabled = true;
                    cbxCıkarma.Enabled = true;
                }

                if (cbxBolme.Checked == true)
                {
                    try
                    {
                        sayı1 = Convert.ToInt32(tbxSayı1.Text);
                        sayı2 = Convert.ToInt32(tbxSayı2.Text);
                        sonuc = sayı1 / sayı2;
                        lblSonuc.Text = sonuc.ToString();
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen sadece sayı giriniz.");
                        tbxSayı1.Text = "";
                        tbxSayı2.Text = "";
                    }
                    cbxBolme.Checked = false;
                    cbxToplama.Enabled = true;
                    cbxCarpma.Enabled = true;
                    cbxCıkarma.Enabled = true;
                }
            }
            

        }

        private void cbxToplama_CheckedChanged(object sender, EventArgs e)
        {
            cbxBolme.Enabled = false;
            cbxCarpma.Enabled = false;
            cbxCıkarma.Enabled = false;
        }

        private void cbxCıkarma_CheckedChanged(object sender, EventArgs e)
        {
            cbxBolme.Enabled = false;
            cbxCarpma.Enabled = false;
            cbxToplama.Enabled = false;
        }

        private void cbxCarpma_CheckedChanged(object sender, EventArgs e)
        {
            cbxBolme.Enabled = false;
            cbxToplama.Enabled = false;
            cbxCıkarma.Enabled = false;
        }

        private void cbxBolme_CheckedChanged(object sender, EventArgs e)
        {
            cbxToplama.Enabled = false;
            cbxCarpma.Enabled = false;
            cbxCıkarma.Enabled = false;
        }
    }
}
