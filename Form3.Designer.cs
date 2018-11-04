namespace AracTakip
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtBeygir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbxDonanim = new System.Windows.Forms.ComboBox();
            this.cmbxModel = new System.Windows.Forms.ComboBox();
            this.cmbxVites = new System.Windows.Forms.ComboBox();
            this.cmbxMotor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHacim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriadsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteritelnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriyilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterimodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteritipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterihacimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteribeygirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriyakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterivitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterirenkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTakipDataSet1 = new AracTakip.AracTakipDataSet1();
            this.musteriBilgiTableAdapter = new AracTakip.AracTakipDataSet1TableAdapters.MusteriBilgiTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(206, 57);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(206, 96);
            this.txtTelNo.MaxLength = 11;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelNo.TabIndex = 1;
            // 
            // txtBeygir
            // 
            this.txtBeygir.Location = new System.Drawing.Point(206, 278);
            this.txtBeygir.Name = "txtBeygir";
            this.txtBeygir.Size = new System.Drawing.Size(100, 20);
            this.txtBeygir.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Aracın Vitesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "AracınYakıt Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Aracın Beygir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Aracın Donanım:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Aracın Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Aracın Yılı:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(206, 131);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Telefon Numarası:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Adı Soyadı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(116, 425);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbxDonanim
            // 
            this.cmbxDonanim.FormattingEnabled = true;
            this.cmbxDonanim.Location = new System.Drawing.Point(206, 205);
            this.cmbxDonanim.Name = "cmbxDonanim";
            this.cmbxDonanim.Size = new System.Drawing.Size(100, 21);
            this.cmbxDonanim.TabIndex = 38;
            this.cmbxDonanim.Text = "Seçiniz...";
            // 
            // cmbxModel
            // 
            this.cmbxModel.FormattingEnabled = true;
            this.cmbxModel.Location = new System.Drawing.Point(206, 167);
            this.cmbxModel.Name = "cmbxModel";
            this.cmbxModel.Size = new System.Drawing.Size(100, 21);
            this.cmbxModel.TabIndex = 37;
            this.cmbxModel.Text = "Seçiniz...";
            // 
            // cmbxVites
            // 
            this.cmbxVites.FormattingEnabled = true;
            this.cmbxVites.Items.AddRange(new object[] {
            "Manuel",
            "Yarı Otomatik",
            "Otomatik"});
            this.cmbxVites.Location = new System.Drawing.Point(206, 354);
            this.cmbxVites.Name = "cmbxVites";
            this.cmbxVites.Size = new System.Drawing.Size(100, 21);
            this.cmbxVites.TabIndex = 36;
            this.cmbxVites.Text = "Seçiniz...";
            // 
            // cmbxMotor
            // 
            this.cmbxMotor.FormattingEnabled = true;
            this.cmbxMotor.Items.AddRange(new object[] {
            "Benzin",
            "Benzin & LPG",
            "Dizel",
            "Hybrid"});
            this.cmbxMotor.Location = new System.Drawing.Point(206, 316);
            this.cmbxMotor.Name = "cmbxMotor";
            this.cmbxMotor.Size = new System.Drawing.Size(100, 21);
            this.cmbxMotor.TabIndex = 35;
            this.cmbxMotor.Text = "Seçiniz...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Aracın Motor Hacmi:";
            // 
            // txtHacim
            // 
            this.txtHacim.Location = new System.Drawing.Point(206, 241);
            this.txtHacim.Name = "txtHacim";
            this.txtHacim.Size = new System.Drawing.Size(100, 20);
            this.txtHacim.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.musteriadsoyadDataGridViewTextBoxColumn,
            this.musteritelnoDataGridViewTextBoxColumn,
            this.musteriyilDataGridViewTextBoxColumn,
            this.musterimodelDataGridViewTextBoxColumn,
            this.musteritipDataGridViewTextBoxColumn,
            this.musterihacimDataGridViewTextBoxColumn,
            this.musteribeygirDataGridViewTextBoxColumn,
            this.musteriyakitDataGridViewTextBoxColumn,
            this.musterivitesDataGridViewTextBoxColumn,
            this.musterirenkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(545, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 391);
            this.dataGridView1.TabIndex = 46;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // musteriadsoyadDataGridViewTextBoxColumn
            // 
            this.musteriadsoyadDataGridViewTextBoxColumn.DataPropertyName = "musteri_adsoyad";
            this.musteriadsoyadDataGridViewTextBoxColumn.HeaderText = "musteri_adsoyad";
            this.musteriadsoyadDataGridViewTextBoxColumn.Name = "musteriadsoyadDataGridViewTextBoxColumn";
            // 
            // musteritelnoDataGridViewTextBoxColumn
            // 
            this.musteritelnoDataGridViewTextBoxColumn.DataPropertyName = "musteri_telno";
            this.musteritelnoDataGridViewTextBoxColumn.HeaderText = "musteri_telno";
            this.musteritelnoDataGridViewTextBoxColumn.Name = "musteritelnoDataGridViewTextBoxColumn";
            // 
            // musteriyilDataGridViewTextBoxColumn
            // 
            this.musteriyilDataGridViewTextBoxColumn.DataPropertyName = "musteri_yil";
            this.musteriyilDataGridViewTextBoxColumn.HeaderText = "musteri_yil";
            this.musteriyilDataGridViewTextBoxColumn.Name = "musteriyilDataGridViewTextBoxColumn";
            // 
            // musterimodelDataGridViewTextBoxColumn
            // 
            this.musterimodelDataGridViewTextBoxColumn.DataPropertyName = "musteri_model";
            this.musterimodelDataGridViewTextBoxColumn.HeaderText = "musteri_model";
            this.musterimodelDataGridViewTextBoxColumn.Name = "musterimodelDataGridViewTextBoxColumn";
            // 
            // musteritipDataGridViewTextBoxColumn
            // 
            this.musteritipDataGridViewTextBoxColumn.DataPropertyName = "musteri_tip";
            this.musteritipDataGridViewTextBoxColumn.HeaderText = "musteri_tip";
            this.musteritipDataGridViewTextBoxColumn.Name = "musteritipDataGridViewTextBoxColumn";
            // 
            // musterihacimDataGridViewTextBoxColumn
            // 
            this.musterihacimDataGridViewTextBoxColumn.DataPropertyName = "musteri_hacim";
            this.musterihacimDataGridViewTextBoxColumn.HeaderText = "musteri_hacim";
            this.musterihacimDataGridViewTextBoxColumn.Name = "musterihacimDataGridViewTextBoxColumn";
            // 
            // musteribeygirDataGridViewTextBoxColumn
            // 
            this.musteribeygirDataGridViewTextBoxColumn.DataPropertyName = "musteri_beygir";
            this.musteribeygirDataGridViewTextBoxColumn.HeaderText = "musteri_beygir";
            this.musteribeygirDataGridViewTextBoxColumn.Name = "musteribeygirDataGridViewTextBoxColumn";
            // 
            // musteriyakitDataGridViewTextBoxColumn
            // 
            this.musteriyakitDataGridViewTextBoxColumn.DataPropertyName = "musteri_yakit";
            this.musteriyakitDataGridViewTextBoxColumn.HeaderText = "musteri_yakit";
            this.musteriyakitDataGridViewTextBoxColumn.Name = "musteriyakitDataGridViewTextBoxColumn";
            // 
            // musterivitesDataGridViewTextBoxColumn
            // 
            this.musterivitesDataGridViewTextBoxColumn.DataPropertyName = "musteri_vites";
            this.musterivitesDataGridViewTextBoxColumn.HeaderText = "musteri_vites";
            this.musterivitesDataGridViewTextBoxColumn.Name = "musterivitesDataGridViewTextBoxColumn";
            // 
            // musterirenkDataGridViewTextBoxColumn
            // 
            this.musterirenkDataGridViewTextBoxColumn.DataPropertyName = "musteri_renk";
            this.musterirenkDataGridViewTextBoxColumn.HeaderText = "musteri_renk";
            this.musterirenkDataGridViewTextBoxColumn.Name = "musterirenkDataGridViewTextBoxColumn";
            // 
            // musteriBilgiBindingSource
            // 
            this.musteriBilgiBindingSource.DataMember = "MusteriBilgi";
            this.musteriBilgiBindingSource.DataSource = this.aracTakipDataSet1;
            // 
            // aracTakipDataSet1
            // 
            this.aracTakipDataSet1.DataSetName = "AracTakipDataSet1";
            this.aracTakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBilgiTableAdapter
            // 
            this.musteriBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Aracın Rengi:";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(206, 389);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 48;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracTakip.Properties.Resources.volkswagen_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(883, 467);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtHacim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbxDonanim);
            this.Controls.Add(this.cmbxModel);
            this.Controls.Add(this.cmbxVites);
            this.Controls.Add(this.cmbxMotor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBeygir);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAdSoyad);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Talep";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtBeygir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbxDonanim;
        private System.Windows.Forms.ComboBox cmbxModel;
        private System.Windows.Forms.ComboBox cmbxVites;
        private System.Windows.Forms.ComboBox cmbxMotor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHacim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AracTakipDataSet1 aracTakipDataSet1;
        private System.Windows.Forms.BindingSource musteriBilgiBindingSource;
        private AracTakipDataSet1TableAdapters.MusteriBilgiTableAdapter musteriBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriadsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteritelnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriyilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterimodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteritipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterihacimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteribeygirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriyakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterivitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterirenkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRenk;

    }
}