
namespace Not_Kayıt_Sistemi
{
    partial class FrmÖğretmenDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnÖğrenciKaydet = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.masktxtNumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKalanSayısıSnv = new System.Windows.Forms.Label();
            this.lblGeçenSayısıSnv = new System.Windows.Forms.Label();
            this.lblOrtalamaSnv = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notKayıtDataSet = new Not_Kayıt_Sistemi.NotKayıtDataSet();
            this.tblDersTableAdapter = new Not_Kayıt_Sistemi.NotKayıtDataSetTableAdapters.TblDersTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnÖğrenciKaydet);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.masktxtNumara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // btnÖğrenciKaydet
            // 
            this.btnÖğrenciKaydet.Location = new System.Drawing.Point(175, 283);
            this.btnÖğrenciKaydet.Name = "btnÖğrenciKaydet";
            this.btnÖğrenciKaydet.Size = new System.Drawing.Size(246, 67);
            this.btnÖğrenciKaydet.TabIndex = 6;
            this.btnÖğrenciKaydet.Text = "Öğrenci Kaydet";
            this.btnÖğrenciKaydet.UseVisualStyleBackColor = true;
            this.btnÖğrenciKaydet.Click += new System.EventHandler(this.btnÖğrenciKaydet_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(175, 220);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(246, 44);
            this.txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(175, 150);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(246, 44);
            this.txtAd.TabIndex = 2;
            // 
            // masktxtNumara
            // 
            this.masktxtNumara.Location = new System.Drawing.Point(175, 77);
            this.masktxtNumara.Mask = "0000";
            this.masktxtNumara.Name = "masktxtNumara";
            this.masktxtNumara.Size = new System.Drawing.Size(246, 44);
            this.masktxtNumara.TabIndex = 1;
            this.masktxtNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSınav1);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.txtSınav3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSınav2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(496, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(154, 71);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(246, 44);
            this.txtSınav1.TabIndex = 7;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(154, 283);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(246, 67);
            this.btnGüncelle.TabIndex = 6;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(154, 220);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(246, 44);
            this.txtSınav3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sınav3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 38);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav2:";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(154, 144);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(246, 44);
            this.txtSınav2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKalanSayısıSnv);
            this.groupBox3.Controls.Add(this.lblGeçenSayısıSnv);
            this.groupBox3.Controls.Add(this.lblOrtalamaSnv);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(980, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 404);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            // 
            // lblKalanSayısıSnv
            // 
            this.lblKalanSayısıSnv.AutoSize = true;
            this.lblKalanSayısıSnv.Location = new System.Drawing.Point(272, 220);
            this.lblKalanSayısıSnv.Name = "lblKalanSayısıSnv";
            this.lblKalanSayısıSnv.Size = new System.Drawing.Size(57, 38);
            this.lblKalanSayısıSnv.TabIndex = 7;
            this.lblKalanSayısıSnv.Text = "00";
            // 
            // lblGeçenSayısıSnv
            // 
            this.lblGeçenSayısıSnv.AutoSize = true;
            this.lblGeçenSayısıSnv.Location = new System.Drawing.Point(272, 167);
            this.lblGeçenSayısıSnv.Name = "lblGeçenSayısıSnv";
            this.lblGeçenSayısıSnv.Size = new System.Drawing.Size(57, 38);
            this.lblGeçenSayısıSnv.TabIndex = 6;
            this.lblGeçenSayısıSnv.Text = "00";
            // 
            // lblOrtalamaSnv
            // 
            this.lblOrtalamaSnv.AutoSize = true;
            this.lblOrtalamaSnv.Location = new System.Drawing.Point(272, 116);
            this.lblOrtalamaSnv.Name = "lblOrtalamaSnv";
            this.lblOrtalamaSnv.Size = new System.Drawing.Size(57, 38);
            this.lblOrtalamaSnv.TabIndex = 5;
            this.lblOrtalamaSnv.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 38);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 38);
            this.label8.TabIndex = 3;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1364, 545);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIDDataGridViewTextBoxColumn,
            this.ogrNumaraDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrS1DataGridViewTextBoxColumn,
            this.ogrS2DataGridViewTextBoxColumn,
            this.ogrS3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblDersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 502);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogrIDDataGridViewTextBoxColumn
            // 
            this.ogrIDDataGridViewTextBoxColumn.DataPropertyName = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.HeaderText = "OgrID";
            this.ogrIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrIDDataGridViewTextBoxColumn.Name = "ogrIDDataGridViewTextBoxColumn";
            this.ogrIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrNumaraDataGridViewTextBoxColumn
            // 
            this.ogrNumaraDataGridViewTextBoxColumn.DataPropertyName = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.HeaderText = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrNumaraDataGridViewTextBoxColumn.Name = "ogrNumaraDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrS1DataGridViewTextBoxColumn
            // 
            this.ogrS1DataGridViewTextBoxColumn.DataPropertyName = "OgrS1";
            this.ogrS1DataGridViewTextBoxColumn.HeaderText = "OgrS1";
            this.ogrS1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrS1DataGridViewTextBoxColumn.Name = "ogrS1DataGridViewTextBoxColumn";
            // 
            // ogrS2DataGridViewTextBoxColumn
            // 
            this.ogrS2DataGridViewTextBoxColumn.DataPropertyName = "OgrS2";
            this.ogrS2DataGridViewTextBoxColumn.HeaderText = "OgrS2";
            this.ogrS2DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrS2DataGridViewTextBoxColumn.Name = "ogrS2DataGridViewTextBoxColumn";
            // 
            // ogrS3DataGridViewTextBoxColumn
            // 
            this.ogrS3DataGridViewTextBoxColumn.DataPropertyName = "OgrS3";
            this.ogrS3DataGridViewTextBoxColumn.HeaderText = "OgrS3";
            this.ogrS3DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrS3DataGridViewTextBoxColumn.Name = "ogrS3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.MinimumWidth = 10;
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // tblDersBindingSource
            // 
            this.tblDersBindingSource.DataMember = "TblDers";
            this.tblDersBindingSource.DataSource = this.notKayıtDataSet;
            // 
            // notKayıtDataSet
            // 
            this.notKayıtDataSet.DataSetName = "NotKayıtDataSet";
            this.notKayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDersTableAdapter
            // 
            this.tblDersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmÖğretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1407, 979);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmÖğretmenDetay";
            this.Text = "FrmÖğretmenDetay";
            this.Load += new System.EventHandler(this.FrmÖğretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notKayıtDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnÖğrenciKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox masktxtNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblKalanSayısıSnv;
        private System.Windows.Forms.Label lblGeçenSayısıSnv;
        private System.Windows.Forms.Label lblOrtalamaSnv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NotKayıtDataSet notKayıtDataSet;
        private System.Windows.Forms.BindingSource tblDersBindingSource;
        private NotKayıtDataSetTableAdapters.TblDersTableAdapter tblDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
    }
}