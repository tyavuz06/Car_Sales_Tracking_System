using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnGiris_Click(object sender, EventArgs e)
        {
            
            string kullanici = "etimur";
            string sifre = "timur8283";
            if (txtKullaniciSifre.Text == sifre && txtKullaniciAdi.Text == kullanici)
            {
                Form9 f9 = new Form9();
                f9.ShowDialog();
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifresi Hatalı");
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKullaniciSifre.Focus();
            txtKullaniciAdi.Text = "etimur";
            
        }
    }
}
