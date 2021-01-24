using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 7, 8, 6, 3, 4, 2, 0 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                lbxEkran2.Items.Add(sayilar[i]);
            }
        }

        string[] sehir = new string[5];
        int sayac = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehir[sayac] = tbxSehirAdı.Text;
            sayac++;
            tbxSehirAdı.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehir.Length; i++)
            {
                lbxEkran.Items.Add(sehir[i]);
            }
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 7, 8, 6, 3, 4, 2, 0 };
            Array.Sort(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                lbxEkran1.Items.Add(sayilar[i]);
            }
        }
    }
}
