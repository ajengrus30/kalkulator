using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjengRuswanti_Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAngka1.Clear();
            txtAngka2.Clear();
            lblHasil.Text = "";
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text))
            {
                MessageBox.Show("Bilangan 1 dan Bilangan 2 harus di isi");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtAngka1.Text);
                b = float.Parse(this.txtAngka2.Text);
                c = a + b;
                this.lblHasil.Text = c.ToString();
            }
            
        }

        private void BtnKurang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text))
            {
                MessageBox.Show("Bilangan 1 dan Bilangan 2 harus di isi");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtAngka1.Text);
                b = float.Parse(this.txtAngka2.Text);
                c = a - b;
                this.lblHasil.Text = c.ToString();
            }
        }

        private void BtnKali_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text))
            {
                MessageBox.Show("Bilangan 1 dan Bilangan 2 harus di isi");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtAngka1.Text);
                b = float.Parse(this.txtAngka2.Text);
                c = a * b;
                this.lblHasil.Text = c.ToString();
            }
        }

        private void BtnBagi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAngka1.Text) || string.IsNullOrEmpty(txtAngka2.Text))
            {
                MessageBox.Show("Bilangan 1 dan Bilangan 2 harus di isi");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.txtAngka1.Text);
                b = float.Parse(this.txtAngka2.Text);
                c = a / b;
                this.lblHasil.Text = c.ToString();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAngka1.Clear();
            txtAngka2.Clear();
            lblHasil.Text = "";
        }
    }
}
