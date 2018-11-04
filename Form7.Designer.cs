namespace AracTakip
{
    partial class Form7
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
            this.txtDonanim = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracdonanimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracDonanimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTakipDataSet4 = new AracTakip.AracTakipDataSet4();
            this.aracDonanimTableAdapter = new AracTakip.AracTakipDataSet4TableAdapters.AracDonanimTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracDonanimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDonanim
            // 
            this.txtDonanim.Location = new System.Drawing.Point(307, 60);
            this.txtDonanim.Name = "txtDonanim";
            this.txtDonanim.Size = new System.Drawing.Size(100, 20);
            this.txtDonanim.TabIndex = 37;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(332, 112);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 36;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(214, 112);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 35;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Aracın Donanımı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.aracdonanimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aracDonanimBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(156, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "no";
            this.noDataGridViewTextBoxColumn.HeaderText = "no";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            // 
            // aracdonanimDataGridViewTextBoxColumn
            // 
            this.aracdonanimDataGridViewTextBoxColumn.DataPropertyName = "arac_donanim";
            this.aracdonanimDataGridViewTextBoxColumn.HeaderText = "arac_donanim";
            this.aracdonanimDataGridViewTextBoxColumn.Name = "aracdonanimDataGridViewTextBoxColumn";
            // 
            // aracDonanimBindingSource
            // 
            this.aracDonanimBindingSource.DataMember = "AracDonanim";
            this.aracDonanimBindingSource.DataSource = this.aracTakipDataSet4;
            // 
            // aracTakipDataSet4
            // 
            this.aracTakipDataSet4.DataSetName = "AracTakipDataSet4";
            this.aracTakipDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aracDonanimTableAdapter
            // 
            this.aracDonanimTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AracTakip.Properties.Resources.volkswagen_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(643, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDonanim);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAÇ DONANIM KAYIT";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracDonanimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracTakipDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonanim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AracTakipDataSet4 aracTakipDataSet4;
        private System.Windows.Forms.BindingSource aracDonanimBindingSource;
        private AracTakipDataSet4TableAdapters.AracDonanimTableAdapter aracDonanimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracdonanimDataGridViewTextBoxColumn;
    }
}