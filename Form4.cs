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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            connect.Open();
        }
        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbDataReader dr;
        OleDbDataReader dr4;
        private void Form4_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            this.esletirmeTableAdapter.Fill(this.aracTakipDataSet2.Esletirme);
            lstIsim.Items.Clear();
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connect;
            command2.CommandText = "select * from Esletirme";
            dr = command2.ExecuteReader();
            while (dr.Read())
            {
                lstIsim.Items.Add(dr["adsoyad"]);
            }
            OleDbDataAdapter adaptor = new OleDbDataAdapter("select * from Esletirme", connect);
            DataSet ds = new DataSet();
            ds.Clear();
            adaptor.Fill(ds, "Esletirme");
            dataGridView1.DataSource = ds.Tables["Esletirme"];
            adaptor.Dispose();
            dr.Close();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (lstIsim.SelectedIndex>=0)
            {
                string aranan = lstIsim.SelectedItem.ToString();
                OleDbCommand command7 = new OleDbCommand();
                command7.Connection = connect;
                command7.CommandText = "select * from Esletirme where adsoyad='"+aranan+"'";
                dr4 = command7.ExecuteReader();
                while (dr4.Read())
                {
                    string yil = dr4["yil"].ToString();
                    string model = dr4["model"].ToString();
                    string donanim = dr4["donanim"].ToString();
                    string hacim = dr4["hacim"].ToString();
                    string beygir = dr4["beygir"].ToString();
                    string motor = dr4["yakit"].ToString();
                    string vites = dr4["vites"].ToString();

                    OleDbCommand command6 = new OleDbCommand();
                    command6.Connection = connect;
                    command6.CommandText = "delete * from AracTakip where arac_yil='" + yil + "' AND arac_model='" + model + "' AND arac_tip='" + donanim + "' AND arac_hacim='"+hacim+"' AND arac_beygir='" + beygir + "' AND arac_vites='" + vites + "' AND arac_yakit='"+motor+"'";
                    command6.ExecuteNonQuery();
                }
                dr4.Close();
                string sorgu = "delete * from Esletirme where adsoyad='" + aranan + "'";
                OleDbCommand command = new OleDbCommand(sorgu, connect);
                command.ExecuteNonQuery();
                OleDbCommand command5 = new OleDbCommand();
                command5.Connection = connect;
                command5.CommandText = "delete * from MusteriBilgi where musteri_adsoyad='" + aranan + "'";
                command5.ExecuteNonQuery();
                load();
            }
            else
                MessageBox.Show("Listeden İsim Seçiniz");
            
            
        }

        private void lstIsim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIsim.SelectedIndex>=0)
            {
                string aranan = lstIsim.SelectedItem.ToString();
                OleDbDataAdapter adaptor = new OleDbDataAdapter("select * from Esletirme where adsoyad='" + aranan + "'", connect);
                DataSet ds = new DataSet();
                ds.Clear();
                adaptor.Fill(ds, "Esletirme");
                dataGridView1.DataSource = ds.Tables["Esletirme"];
                adaptor.Dispose();
            }
            else
                MessageBox.Show("Kişi Seçiniz...");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();
        }
    }
}
