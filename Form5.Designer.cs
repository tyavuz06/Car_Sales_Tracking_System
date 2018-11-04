namespace AracTakip
{
    partial class Form5
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstIsim = new System.Windows.Forms.ListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(495, 60);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 28;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(381, 60);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 27;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstIsim
            // 
            this.lstIsim.FormattingEnabled = true;
            this.lstIsim.Location = new System.Drawing.Point(58, 60);
            this.lstIsim.Name = "lstIsim";
            this.lstIsim.Size = new System.Drawing.Size(256, 290);
            this.lstIsim.TabIndex = 34;
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
            this.dataGridView1.Location = new System.Drawing.Point(58, 387);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 188);
            this.dataGridView1.TabIndex = 35;
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracTakip.Properties.Resources.volkswagen_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(926, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstIsim);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSil);
            this.DoubleBuffered = true;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Sil";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstIsim;
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
    }
}