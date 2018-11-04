using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AracTakip
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            connect.Open();
            
        }
        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbCommand command = new OleDbCommand();
        void yukle()
        {
            this.aracDonanimTableAdapter.Fill(this.aracTakipDataSet4.AracDonanim);
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            command.Connection = connect;
            command.CommandText = "insert into AracDonanim(arac_donanim) values ('" + txtDonanim.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapılmıştır.");
            txtDonanim.Text = "";
            txtDonanim.Focus();
            yukle();
        }
    }
}
