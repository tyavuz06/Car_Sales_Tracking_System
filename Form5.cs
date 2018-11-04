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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            connect.Open();
        }
        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbCommand command2 = new OleDbCommand();
        OleDbDataReader dr;
        private void Form5_Load(object sender, EventArgs e)
        {
            yukle();
           
        }
        void yukle()
        {
            this.musteriBilgiTableAdapter.Fill(this.aracTakipDataSet1.MusteriBilgi);
            lstIsim.Items.Clear();
            command.Connection = connect;
            command.CommandText = "select * from MusteriBilgi";
            dr = command.ExecuteReader();
            while (dr.Read())
            {
                lstIsim.Items.Add(dr["musteri_adsoyad"]);
            }
            dr.Close();
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstIsim.SelectedIndex >= 0)
            {
                string aranan = lstIsim.SelectedItem.ToString();
                command2.Connection = connect;
                command2.CommandText = "delete * from MusteriBilgi where musteri_adsoyad='" + aranan + "'";
                command2.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi");
                yukle();
            }
            else
                MessageBox.Show("Listeden Kişi Seçiniz.");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();
        }
    }
}
