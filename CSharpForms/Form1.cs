using HelloWorld;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Print(string key)
        {
            btnMerhaba.Text = key;
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNameText.Visible = false;
            lblSurNameText.Visible = false;
            lblAgeText.Visible = false;
            lblClassText.Visible = false;
            lblBranchText.Visible = false;
            lblPhoneNumberText.Visible = false;
            lblDateText.Visible = false;

            Form2 form2 = new Form2();
            form2.Show();
            Form3 form3 = new Form3();
            form3.Show();

        }


        private void btnMerhaba_Click(object sender, EventArgs e)
        {
            Print("HelloWorld");

            lblNameText.Text = tbxName.Text;
            lblSurNameText.Text = tbxSurName.Text;
            lblAgeText.Text = tbxAge.Text;
            lblClassText.Text = tbxClass.Text;
            lblBranchText.Text = cbxBranch.Text;
            lblPhoneNumberText.Text = mtbxPhoneNumber.Text;
            lblDateText.Text = mtbxDate.Text;

            lblNameText.Visible = true;
            lblSurNameText.Visible = true;
            lblAgeText.Visible = true;
            lblClassText.Visible = true;
            lblBranchText.Visible = true;
            lblPhoneNumberText.Visible = true;
            lblDateText.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbxName.Text == "" || tbxSurName.Text == "" || tbxAge.Text == "" || tbxClass.Text == "")
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.");
            }

            else
            {
                lbxEkran.Items.Add(lblNameText.Text);
                lbxEkran.Items.Add(lblSurNameText.Text);
                lbxEkran.Items.Add(lblAgeText.Text);
                lbxEkran.Items.Add(lblClassText.Text);
                lbxEkran.Items.Add(lblBranchText.Text);
                lbxEkran.Items.Add(lblPhoneNumberText.Text);
                lbxEkran.Items.Add(lblDateText.Text);
            }
        }
    }
}
