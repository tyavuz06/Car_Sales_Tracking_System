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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            connect.Open();
        }
        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbCommand command2 = new OleDbCommand();
        OleDbDataReader dr;
        OleDbDataReader dr2;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            command.Connection = connect;
            command.CommandText="insert into AracTakip(arac_yil,arac_model,arac_tip,arac_hacim,arac_beygir,arac_yakit,arac_vites,arac_renk) values ('"+txtYil.Text+"','"+cmbxModel.SelectedItem+"','"+cmbxDonanim.SelectedItem+"','"+txtHacim.Text+"','"+txtBeygir.Text+"','"+cmbxMotor.SelectedItem+"','"+cmbxVites.SelectedItem+"','"+txtRenk.Text+"')";
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapılmıştır.");
            txtBeygir.Text = "";
            txtYil.Text = "";
            cmbxVites.Text = "Seçiniz...";
            cmbxMotor.Text = "Seçiniz...";
            cmbxModel.Text = "Seçiniz...";
            cmbxDonanim.Text = "Seçiniz...";
            txtHacim.Text = "";
            txtYil.Focus();
            yukle();
        }
        void yukle()
        {
            this.aracTakipTableAdapter.Fill(this.aracTakipDataSet.AracTakip);
            command2.Connection = connect;
            command2.CommandText = "select * from AracModel";
            command.Connection = connect;
            command.CommandText = "select * from AracDonanim";
            dr2 = command.ExecuteReader();
            dr = command2.ExecuteReader();
            while(dr.Read())
            {
                cmbxModel.Items.Add(dr["arac_model"]);
            }
            while(dr2.Read())
            {
                cmbxDonanim.Items.Add(dr2["arac_donanim"]);
            }
            dr.Close();
            dr2.Close();

        }
        
        private void btnCikis_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            yukle();
        }
    }
}
