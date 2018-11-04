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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            connect.Open();
        }
        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbCommand command2 = new OleDbCommand();
        OleDbCommand command3 = new OleDbCommand();
        OleDbCommand command4 = new OleDbCommand();
        OleDbDataReader dr;
        OleDbDataReader dr2;
        private void txtArac_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnEslestir_Click(object sender, EventArgs e)
        {
            connect.Close();
            connect.Open();
            OleDbCommand command7 = new OleDbCommand();
            command7.Connection = connect;
            command7.CommandText = "delete * from Esletirme";
            command7.ExecuteNonQuery();

            command2.Connection = connect;
            command2.CommandText = "select * from AracTakip";
            dr = command2.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                string yil = dr["arac_yil"].ToString();
                string model = dr["arac_model"].ToString();
                string donanim = dr["arac_tip"].ToString();
                string hacim = dr["arac_hacim"].ToString();
                string beygir = dr["arac_beygir"].ToString();
                string motor = dr["arac_yakit"].ToString();
                string vites = dr["arac_vites"].ToString();
                string renk = dr["arac_renk"].ToString();
                command3.Connection = connect;
                command3.CommandText = "select * from MusteriBilgi";
                dr2 = command3.ExecuteReader();
                while (dr2.Read())
                {
                    string adsoyad = dr2["musteri_adsoyad"].ToString();
                    string telno = dr2["musteri_telno"].ToString();
                    string yil2 = dr2["musteri_yil"].ToString();
                    string model2 = dr2["musteri_model"].ToString();
                    string donanim2 = dr2["musteri_tip"].ToString();
                    string hacim2 = dr2["musteri_hacim"].ToString();
                    string beygir2 = dr2["musteri_beygir"].ToString();
                    string motor2 = dr2["musteri_yakit"].ToString();
                    string vites2 = dr2["musteri_vites"].ToString();
                    string renk2 = dr2["musteri_renk"].ToString();

                    if (yil == yil2 && model == model2 && donanim == donanim2 && beygir == beygir2 && motor == motor2 && vites == vites2 && hacim == hacim2 && renk == renk2)
                    {
                        MessageBox.Show("Eşleşme Bulundu...");
                        MessageBox.Show("Müşterinin Adı: " + adsoyad + " Telefonu:" + telno);
                        sayac = +1;
                        command4.Connection = connect;
                        command4.CommandText = "insert into Esletirme(adsoyad,telefon,model,donanim,yil,vites,yakit,hacim,beygir,renk) values('" + adsoyad + "','" + telno + "','" + model2 + "','" + donanim2 + "','" + yil2 + "','" + vites2 + "','" + motor2 + "','" + hacim2 + "','" + beygir2 + "','" + renk2 + "')";
                        command4.ExecuteNonQuery();
                    }
                }

                dr2.Close();
            }
            if (sayac == 0)
                MessageBox.Show("Kayıt Bulunamadı.");
            dr.Close();

        }

        private void btnAracSatis_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btnAracListe_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void btnAracDonanimKaydet_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
