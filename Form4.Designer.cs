namespace AracTakip
{
    partial class Form4
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
            this.lstIsim = new System.Windows.Forms.ListBox();
            this.btnIslem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hacimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beygirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esletirmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTakipDataSet2 = new AracTakip.AracTakipDataSet2();
            this.esletirmeTableAdapter = new AracTakip.AracTakipDataSet2TableAdapters.EsletirmeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esletirmeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstIsim
            // 
            this.lstIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstIsim.FormattingEnabled = true;
            this.lstIsim.ItemHeight = 20;
            this.lstIsim.Location = new System.Drawing.Point(128, 29);
            this.lstIsim.Name = "lstIsim";
            this.lstIsim.Size = new System.Drawing.Size(211, 284);
            this.lstIsim.TabIndex = 1;
            this.lstIsim.SelectedIndexChanged += new System.EventHandler(this.lstIsim_SelectedIndexChanged);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(443, 29);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(105, 44);
            this.btnIslem.TabIndex = 2;
            this.btnIslem.Text = "Seçili İşlemi Onayla";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eşleştirme Bilgileri:";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(443, 92);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(105, 44);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.donanimDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.vitesDataGridViewTextBoxColumn,
            this.yakitDataGridViewTextBoxColumn,
            this.hacimDataGridViewTextBoxColumn,
            this.beygirDataGridViewTextBoxColumn,
            this.renkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.esletirmeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 174);
            this.dataGridView1.TabIndex = 6;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // donanimDataGridViewTextBoxColumn
            // 
            this.donanimDataGridViewTextBoxColumn.DataPropertyName = "donanim";
            this.donanimDataGridViewTextBoxColumn.HeaderText = "donanim";
            this.donanimDataGridViewTextBoxColumn.Name = "donanimDataGridViewTextBoxColumn";
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "yil";
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            // 
            // vitesDataGridViewTextBoxColumn
            // 
            this.vitesDataGridViewTextBoxColumn.DataPropertyName = "vites";
            this.vitesDataGridViewTextBoxColumn.HeaderText = "vites";
            this.vitesDataGridViewTextBoxColumn.Name = "vitesDataGridViewTextBoxColumn";
            // 
            // yakitDataGridViewTextBoxColumn
            // 
            this.yakitDataGridViewTextBoxColumn.DataPropertyName = "yakit";
            this.yakitDataGridViewTextBoxColumn.HeaderText = "yakit";
            this.yakitDataGridViewTextBoxColumn.Name = "yakitDataGridViewTextBoxColumn";
            // 
            // hacimDataGridViewTextBoxColumn
            // 
            this.hacimDataGridViewTextBoxColumn.DataPropertyName = "hacim";
            this.hacimDataGridViewTextBoxColumn.HeaderText = "hacim";
            this.hacimDataGridViewTextBoxColumn.Name = "hacimDataGridViewTextBoxColumn";
            // 
            // beygirDataGridViewTextBoxColumn
            // 
            this.beygirDataGridViewTextBoxColumn.DataPropertyName = "beygir";
            this.beygirDataGridViewTextBoxColumn.HeaderText = "beygir";
            this.beygirDataGridViewTextBoxColumn.Name = "beygirDataGridViewTextBoxColumn";
            // 
            // renkDataGridViewTextBoxColumn
            // 
            this.renkDataGridViewTextBoxColumn.DataPropertyName = "renk";
            this.renkDataGridViewTextBoxColumn.HeaderText = "renk";
            this.renkDataGridViewTextBoxColumn.Name = "renkDataGridViewTextBoxColumn";
            // 
            // esletirmeBindingSource
            // 
            this.esletirmeBindingSource.DataMember = "Esletirme";
            this.esletirmeBindingSource.DataSource = this.aracTakipDataSet2;
            // 
            // aracTakipDataSet2
            // 
            this.aracTakipDataSet2.DataSetName = "AracTakipDataSet2";
            this.aracTakipDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // esletirmeTableAdapter
            // 
            this.esletirmeTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracTakip.Properties.Resources.volkswagen_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(977, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.lstIsim);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Satış";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esletirmeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIsim;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AracTakipDataSet2 aracTakipDataSet2;
        private System.Windows.Forms.BindingSource esletirmeBindingSource;
        private AracTakipDataSet2TableAdapters.EsletirmeTableAdapter esletirmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donanimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hacimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beygirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkDataGridViewTextBoxColumn;

    }
}