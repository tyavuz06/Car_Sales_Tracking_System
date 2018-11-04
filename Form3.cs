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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            connect.Open();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            yukle();
        }

        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbCommand command2 = new OleDbCommand();
        OleDbDataReader dr;
        OleDbDataReader dr2;
        private void button1_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();
        }
        void yukle()
        {
            this.musteriBilgiTableAdapter.Fill(this.aracTakipDataSet1.MusteriBilgi);
            command2.Connection = connect;
            command2.CommandText = "select * from AracModel";
            command.Connection = connect;
            command.CommandText = "select * from AracDonanim";
            dr2 = command.ExecuteReader();
            dr = command2.ExecuteReader();
            while (dr.Read())
            {
                cmbxModel.Items.Add(dr["arac_model"]);
            }
            while (dr2.Read())
            {
                cmbxDonanim.Items.Add(dr2["arac_donanim"]);
            }
            dr.Close();
            dr2.Close();
        }
      
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            command.Connection = connect;
            command.CommandText = "insert into MusteriBilgi(musteri_adsoyad,musteri_telno,musteri_yil,musteri_model,musteri_tip,musteri_hacim,musteri_beygir,musteri_yakit,musteri_vites,musteri_renk) values('" + txtAdSoyad.Text + "','" + txtTelNo.Text + "','" + txtYil.Text + "','" + cmbxModel.SelectedItem + "','" + cmbxDonanim.SelectedItem + "','"+txtHacim.Text+"','" + txtBeygir.Text + "','" + cmbxMotor.SelectedItem + "','" + cmbxVites.SelectedItem + "','"+txtRenk.Text+"')";
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapılmıştır.");
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtBeygir.Text = "";
            txtYil.Text = "";
            txtHacim.Text = "";
            cmbxVites.Text = "Seçiniz...";
            cmbxMotor.Text = "Seçiniz...";
            cmbxModel.Text = "Seçiniz...";
            cmbxDonanim.Text = "Seçiniz...";
            txtAdSoyad.Focus();
            yukle();
        }
    }
}
