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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            connect.Open();
        }
        OleDbConnection connect = new OleDbConnection("provider=Microsoft.jet.oledb.4.0; Data Source=AracTakip.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbCommand command2 = new OleDbCommand();
        OleDbCommand command3 = new OleDbCommand();
        OleDbDataReader dr;
        OleDbDataReader dr2;
        OleDbDataReader dr3;
        private void btnSil_Click(object sender, EventArgs e)
        {
            command3.Connection = connect;
            command3.CommandText = "select * from AracTakip";
            dr3 = command3.ExecuteReader();
            while(dr3.Read())
            {
                string yil = dr3["arac_yil"].ToString();
                string model = dr3["arac_model"].ToString();
                string donanim = dr3["arac_tip"].ToString();
                string hacim = dr3["arac_hacim"].ToString();
                string beygir = dr3["arac_beygir"].ToString();
                string motor = dr3["arac_yakit"].ToString();
                string vites = dr3["arac_vites"].ToString();
                string renk = dr3["arac_renk"].ToString();

                if (yil == txtYil.Text && cmbxDonanim.SelectedItem.ToString() == donanim && model == cmbxModel.SelectedItem.ToString() && hacim == txtHacim.Text && beygir == txtBeygir.Text && motor == cmbxMotor.SelectedItem.ToString() && vites == cmbxVites.SelectedItem.ToString() && renk==txtRenk.Text)
                {
                    command.Connection = connect;
                    command.CommandText = "delete * from AracTakip where arac_yil='" + txtYil.Text + "' AND arac_model='" + cmbxModel.SelectedItem + "' AND arac_tip='" + cmbxDonanim.SelectedItem + "' AND arac_yakit='" + cmbxMotor.SelectedItem + "' AND arac_vites='" + cmbxVites.SelectedItem + "' AND arac_beygir='" + txtBeygir.Text + "' AND arac_hacim='" + txtHacim.Text + "'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi.");
                    yukle();
                    break;
                }
                else
                {
                    MessageBox.Show("Kayıt Bulunamadı. Bilgileri Kontrol Ediniz.");
                    break;
                }
            }
            dr3.Close();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            connect.Close();
            this.Close();
        }

        void yukle()
        {
            this.aracTakipTableAdapter.Fill(this.aracTakipDataSet.AracTakip);
            cmbxModel.Items.Clear();
            cmbxDonanim.Items.Clear();
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

        private void Form8_Load(object sender, EventArgs e)
        {
            yukle();
        }
    }
}
