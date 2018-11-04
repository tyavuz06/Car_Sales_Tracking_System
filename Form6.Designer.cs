namespace AracTakip
{
    partial class Form6
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTakipDataSet3 = new AracTakip.AracTakipDataSet3();
            this.aracModelTableAdapter = new AracTakip.AracTakipDataSet3TableAdapters.AracModelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(195, 117);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 27;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(80, 117);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Aracın Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(170, 65);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.aracmodelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(449, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // aracmodelDataGridViewTextBoxColumn
            // 
            this.aracmodelDataGridViewTextBoxColumn.DataPropertyName = "arac_model";
            this.aracmodelDataGridViewTextBoxColumn.HeaderText = "arac_model";
            this.aracmodelDataGridViewTextBoxColumn.Name = "aracmodelDataGridViewTextBoxColumn";
            // 
            // aracModelBindingSource
            // 
            this.aracModelBindingSource.DataMember = "AracModel";
            this.aracModelBindingSource.DataSource = this.aracTakipDataSet3;
            // 
            // aracTakipDataSet3
            // 
            this.aracTakipDataSet3.DataSetName = "AracTakipDataSet3";
            this.aracTakipDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracModelTableAdapter
            // 
            this.aracModelTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracTakip.Properties.Resources.volkswagen_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(733, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAÇ MODEL KAYIT";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AracTakipDataSet3 aracTakipDataSet3;
        private System.Windows.Forms.BindingSource aracModelBindingSource;
        private AracTakipDataSet3TableAdapters.AracModelTableAdapter aracModelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracmodelDataGridViewTextBoxColumn;
    }
}