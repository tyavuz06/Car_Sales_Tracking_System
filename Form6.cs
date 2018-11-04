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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            connect.Open();
        }
        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbCommand command = new OleDbCommand();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            command.Connection = connect;
            command.CommandText = "insert into AracModel(arac_model) values ('" + txtModel.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapılmıştır.");
            txtModel.Text = "";
            yukle();
        }

        void yukle()
        {
            this.aracModelTableAdapter.Fill(this.aracTakipDataSet3.AracModel);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();
        }
    }
}
