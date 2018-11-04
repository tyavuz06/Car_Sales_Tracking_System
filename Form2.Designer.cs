namespace AracTakip
{
    partial class Form2
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
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtBeygir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.cmbxMotor = new System.Windows.Forms.ComboBox();
            this.cmbxVites = new System.Windows.Forms.ComboBox();
            this.cmbxModel = new System.Windows.Forms.ComboBox();
            this.cmbxDonanim = new System.Windows.Forms.ComboBox();
            this.txtHacim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayitnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracyilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aractipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arachacimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracbeygirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracyakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracvitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracrenkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTakipDataSet = new AracTakip.AracTakipDataSet();
            this.aracTakipTableAdapter = new AracTakip.AracTakipDataSetTableAdapters.AracTakipTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(234, 71);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 0;
            // 
            // txtBeygir
            // 
            this.txtBeygir.Location = new System.Drawing.Point(234, 214);
            this.txtBeygir.Name = "txtBeygir";
            this.txtBeygir.Size = new System.Drawing.Size(100, 20);
            this.txtBeygir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aracın Yılı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aracın Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aracın Donanım:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aracın Beygir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aracın Yakıt Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aracın Vitesi:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 363);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(259, 363);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // cmbxMotor
            // 
            this.cmbxMotor.FormattingEnabled = true;
            this.cmbxMotor.Items.AddRange(new object[] {
            "Benzin",
            "Benzin & LPG",
            "Dizel",
            "Hybrid"});
            this.cmbxMotor.Location = new System.Drawing.Point(236, 249);
            this.cmbxMotor.Name = "cmbxMotor";
            this.cmbxMotor.Size = new System.Drawing.Size(100, 21);
            this.cmbxMotor.TabIndex = 14;
            this.cmbxMotor.Text = "Seçiniz...";
            // 
            // cmbxVites
            // 
            this.cmbxVites.FormattingEnabled = true;
            this.cmbxVites.Items.AddRange(new object[] {
            "Manuel",
            "Yarı Otomatik",
            "Otomatik"});
            this.cmbxVites.Location = new System.Drawing.Point(236, 288);
            this.cmbxVites.Name = "cmbxVites";
            this.cmbxVites.Size = new System.Drawing.Size(100, 21);
            this.cmbxVites.TabIndex = 15;
            this.cmbxVites.Text = "Seçiniz...";
            // 
            // cmbxModel
            // 
            this.cmbxModel.FormattingEnabled = true;
            this.cmbxModel.Location = new System.Drawing.Point(234, 109);
            this.cmbxModel.Name = "cmbxModel";
            this.cmbxModel.Size = new System.Drawing.Size(100, 21);
            this.cmbxModel.TabIndex = 16;
            this.cmbxModel.Text = "Seçiniz...";
            // 
            // cmbxDonanim
            // 
            this.cmbxDonanim.FormattingEnabled = true;
            this.cmbxDonanim.Location = new System.Drawing.Point(234, 147);
            this.cmbxDonanim.Name = "cmbxDonanim";
            this.cmbxDonanim.Size = new System.Drawing.Size(100, 21);
            this.cmbxDonanim.TabIndex = 17;
            this.cmbxDonanim.Text = "Seçiniz...";
            // 
            // txtHacim
            // 
            this.txtHacim.Location = new System.Drawing.Point(234, 183);
            this.txtHacim.Name = "txtHacim";
            this.txtHacim.Size = new System.Drawing.Size(100, 20);
            this.txtHacim.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Aracın Motor Hacmi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kayitnoDataGridViewTextBoxColumn,
            this.aracyilDataGridViewTextBoxColumn,
            this.aracmodelDataGridViewTextBoxColumn,
            this.aractipDataGridViewTextBoxColumn,
            this.arachacimDataGridViewTextBoxColumn,
            this.aracbeygirDataGridViewTextBoxColumn,
            this.aracyakitDataGridViewTextBoxColumn,
            this.aracvitesDataGridViewTextBoxColumn,
            this.aracrenkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracTakipBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 222);
            this.dataGridView1.TabIndex = 21;
            // 
            // kayitnoDataGridViewTextBoxColumn
            // 
            this.kayitnoDataGridViewTextBoxColumn.DataPropertyName = "kayit_no";
            this.kayitnoDataGridViewTextBoxColumn.HeaderText = "kayit_no";
            this.kayitnoDataGridViewTextBoxColumn.Name = "kayitnoDataGridViewTextBoxColumn";
            // 
            // aracyilDataGridViewTextBoxColumn
            // 
            this.aracyilDataGridViewTextBoxColumn.DataPropertyName = "arac_yil";
            this.aracyilDataGridViewTextBoxColumn.HeaderText = "arac_yil";
            this.aracyilDataGridViewTextBoxColumn.Name = "aracyilDataGridViewTextBoxColumn";
            // 
            // aracmodelDataGridViewTextBoxColumn
            // 
            this.aracmodelDataGridViewTextBoxColumn.DataPropertyName = "arac_model";
            this.aracmodelDataGridViewTextBoxColumn.HeaderText = "arac_model";
            this.aracmodelDataGridViewTextBoxColumn.Name = "aracmodelDataGridViewTextBoxColumn";
            // 
            // aractipDataGridViewTextBoxColumn
            // 
            this.aractipDataGridViewTextBoxColumn.DataPropertyName = "arac_tip";
            this.aractipDataGridViewTextBoxColumn.HeaderText = "arac_tip";
            this.aractipDataGridViewTextBoxColumn.Name = "aractipDataGridViewTextBoxColumn";
            // 
            // arachacimDataGridViewTextBoxColumn
            // 
            this.arachacimDataGridViewTextBoxColumn.DataPropertyName = "arac_hacim";
            this.arachacimDataGridViewTextBoxColumn.HeaderText = "arac_hacim";
            this.arachacimDataGridViewTextBoxColumn.Name = "arachacimDataGridViewTextBoxColumn";
            // 
            // aracbeygirDataGridViewTextBoxColumn
            // 
            this.aracbeygirDataGridViewTextBoxColumn.DataPropertyName = "arac_beygir";
            this.aracbeygirDataGridViewTextBoxColumn.HeaderText = "arac_beygir";
            this.aracbeygirDataGridViewTextBoxColumn.Name = "aracbeygirDataGridViewTextBoxColumn";
            // 
            // aracyakitDataGridViewTextBoxColumn
            // 
            this.aracyakitDataGridViewTextBoxColumn.DataPropertyName = "arac_yakit";
            this.aracyakitDataGridViewTextBoxColumn.HeaderText = "arac_yakit";
            this.aracyakitDataGridViewTextBoxColumn.Name = "aracyakitDataGridViewTextBoxColumn";
            // 
            // aracvitesDataGridViewTextBoxColumn
            // 
            this.aracvitesDataGridViewTextBoxColumn.DataPropertyName = "arac_vites";
            this.aracvitesDataGridViewTextBoxColumn.HeaderText = "arac_vites";
            this.aracvitesDataGridViewTextBoxColumn.Name = "aracvitesDataGridViewTextBoxColumn";
            // 
            // aracrenkDataGridViewTextBoxColumn
            // 
            this.aracrenkDataGridViewTextBoxColumn.DataPropertyName = "arac_renk";
            this.aracrenkDataGridViewTextBoxColumn.HeaderText = "arac_renk";
            this.aracrenkDataGridViewTextBoxColumn.Name = "aracrenkDataGridViewTextBoxColumn";
            // 
            // aracTakipBindingSource
            // 
            this.aracTakipBindingSource.DataMember = "AracTakip";
            this.aracTakipBindingSource.DataSource = this.aracTakipDataSet;
            // 
            // aracTakipDataSet
            // 
            this.aracTakipDataSet.DataSetName = "AracTakipDataSet";
            this.aracTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracTakipTableAdapter
            // 
            this.aracTakipTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Aracın Rengi:";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(234, 326);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 23;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracTakip.Properties.Resources.volkswagen_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(957, 654);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHacim);
            this.Controls.Add(this.cmbxDonanim);
            this.Controls.Add(this.cmbxModel);
            this.Controls.Add(this.cmbxVites);
            this.Controls.Add(this.cmbxMotor);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBeygir);
            this.Controls.Add(this.txtYil);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listesi";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtBeygir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ComboBox cmbxMotor;
        private System.Windows.Forms.ComboBox cmbxVites;
        private System.Windows.Forms.ComboBox cmbxModel;
        private System.Windows.Forms.ComboBox cmbxDonanim;
        private System.Windows.Forms.TextBox txtHacim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AracTakipDataSet aracTakipDataSet;
        private System.Windows.Forms.BindingSource aracTakipBindingSource;
        private AracTakipDataSetTableAdapters.AracTakipTableAdapter aracTakipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracyilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aractipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arachacimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracbeygirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracyakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracvitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracrenkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRenk;
    }
}