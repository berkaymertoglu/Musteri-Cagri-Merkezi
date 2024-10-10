namespace VTYSProje
{
    partial class Asistan
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
            this.label1 = new System.Windows.Forms.Label();
            this.labAsistan = new System.Windows.Forms.Label();
            this.AsistanID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CagriListesiMenusu = new System.Windows.Forms.ToolStripMenuItem();
            this.AylikPrimleriMenusu = new System.Windows.Forms.ToolStripMenuItem();
            this.PrimItirazlariMenusu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYeniCagri = new System.Windows.Forms.Button();
            this.labBanaGelenCagrilar = new System.Windows.Forms.Label();
            this.btnAsistanExit = new System.Windows.Forms.Button();
            this.cagriListesi = new System.Windows.Forms.DataGridView();
            this.primItirazlari = new System.Windows.Forms.DataGridView();
            this.btnItirazEkle = new System.Windows.Forms.Button();
            this.aylikPrimListesi = new System.Windows.Forms.DataGridView();
            this.aylikPrimListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vTYSProjeDataSet4 = new VTYSProje.VTYSProjeDataSet4();
            this.aylikPrimListesiTableAdapter = new VTYSProje.VTYSProjeDataSet4TableAdapters.AylikPrimListesiTableAdapter();
            this.vTYSProjeDataSet5 = new VTYSProje.VTYSProjeDataSet5();
            this.aylikPrimListesiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aylikPrimListesiTableAdapter1 = new VTYSProje.VTYSProjeDataSet5TableAdapters.AylikPrimListesiTableAdapter();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aylıkPrimToplamıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itirazHakkıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cagriListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primItirazlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikPrimListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikPrimListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikPrimListesiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asistan Girişi Yapıldı";
            // 
            // labAsistan
            // 
            this.labAsistan.AutoSize = true;
            this.labAsistan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labAsistan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labAsistan.Location = new System.Drawing.Point(22, 78);
            this.labAsistan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAsistan.Name = "labAsistan";
            this.labAsistan.Size = new System.Drawing.Size(2, 27);
            this.labAsistan.TabIndex = 1;
            // 
            // AsistanID
            // 
            this.AsistanID.AutoSize = true;
            this.AsistanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AsistanID.Location = new System.Drawing.Point(23, 117);
            this.AsistanID.Name = "AsistanID";
            this.AsistanID.Size = new System.Drawing.Size(2, 27);
            this.AsistanID.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CagriListesiMenusu,
            this.AylikPrimleriMenusu,
            this.PrimItirazlariMenusu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1604, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CagriListesiMenusu
            // 
            this.CagriListesiMenusu.Name = "CagriListesiMenusu";
            this.CagriListesiMenusu.Size = new System.Drawing.Size(300, 36);
            this.CagriListesiMenusu.Text = "MÜŞTERİ ÇAĞRI LİSTESİ";
            this.CagriListesiMenusu.Click += new System.EventHandler(this.CagriListesiMenusu_Click);
            // 
            // AylikPrimleriMenusu
            // 
            this.AylikPrimleriMenusu.Name = "AylikPrimleriMenusu";
            this.AylikPrimleriMenusu.Size = new System.Drawing.Size(251, 36);
            this.AylikPrimleriMenusu.Text = "AYLIK PRİM LİSTESİ";
            this.AylikPrimleriMenusu.Click += new System.EventHandler(this.AylikPrimleriMenusu_Click);
            // 
            // PrimItirazlariMenusu
            // 
            this.PrimItirazlariMenusu.Name = "PrimItirazlariMenusu";
            this.PrimItirazlariMenusu.Size = new System.Drawing.Size(229, 36);
            this.PrimItirazlariMenusu.Text = "PRİM İTİRAZLARI";
            this.PrimItirazlariMenusu.Click += new System.EventHandler(this.PrimItirazlariMenusu_Click);
            // 
            // btnYeniCagri
            // 
            this.btnYeniCagri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniCagri.Location = new System.Drawing.Point(587, 147);
            this.btnYeniCagri.Name = "btnYeniCagri";
            this.btnYeniCagri.Size = new System.Drawing.Size(170, 46);
            this.btnYeniCagri.TabIndex = 5;
            this.btnYeniCagri.Text = "YENİ ÇAĞRI";
            this.btnYeniCagri.UseVisualStyleBackColor = true;
            this.btnYeniCagri.Click += new System.EventHandler(this.button1_Click);
            // 
            // labBanaGelenCagrilar
            // 
            this.labBanaGelenCagrilar.AutoSize = true;
            this.labBanaGelenCagrilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBanaGelenCagrilar.Location = new System.Drawing.Point(39, 168);
            this.labBanaGelenCagrilar.Name = "labBanaGelenCagrilar";
            this.labBanaGelenCagrilar.Size = new System.Drawing.Size(188, 25);
            this.labBanaGelenCagrilar.TabIndex = 6;
            this.labBanaGelenCagrilar.Text = "Bana Gelen Çağrılar";
            this.labBanaGelenCagrilar.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAsistanExit
            // 
            this.btnAsistanExit.Location = new System.Drawing.Point(1169, 727);
            this.btnAsistanExit.Name = "btnAsistanExit";
            this.btnAsistanExit.Size = new System.Drawing.Size(98, 47);
            this.btnAsistanExit.TabIndex = 7;
            this.btnAsistanExit.Text = "ÇIKIŞ";
            this.btnAsistanExit.UseVisualStyleBackColor = true;
            this.btnAsistanExit.Click += new System.EventHandler(this.btnAsistanExit_Click);
            // 
            // cagriListesi
            // 
            this.cagriListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cagriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cagriListesi.Location = new System.Drawing.Point(33, 211);
            this.cagriListesi.Name = "cagriListesi";
            this.cagriListesi.RowHeadersWidth = 51;
            this.cagriListesi.Size = new System.Drawing.Size(1527, 482);
            this.cagriListesi.TabIndex = 4;
            this.cagriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cagriListesi_CellContentClick);
            // 
            // primItirazlari
            // 
            this.primItirazlari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.primItirazlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primItirazlari.Location = new System.Drawing.Point(33, 220);
            this.primItirazlari.Name = "primItirazlari";
            this.primItirazlari.RowHeadersWidth = 51;
            this.primItirazlari.RowTemplate.Height = 24;
            this.primItirazlari.Size = new System.Drawing.Size(1527, 473);
            this.primItirazlari.TabIndex = 8;
            this.primItirazlari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.primItirazlari_CellContentClick);
            // 
            // btnItirazEkle
            // 
            this.btnItirazEkle.Location = new System.Drawing.Point(817, 147);
            this.btnItirazEkle.Name = "btnItirazEkle";
            this.btnItirazEkle.Size = new System.Drawing.Size(138, 46);
            this.btnItirazEkle.TabIndex = 9;
            this.btnItirazEkle.Text = "İtiraz Ekle";
            this.btnItirazEkle.UseVisualStyleBackColor = true;
            this.btnItirazEkle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aylikPrimListesi
            // 
            this.aylikPrimListesi.AutoGenerateColumns = false;
            this.aylikPrimListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aylikPrimListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aylikPrimListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ayDataGridViewTextBoxColumn,
            this.aylıkPrimToplamıDataGridViewTextBoxColumn,
            this.itirazHakkıDataGridViewTextBoxColumn});
            this.aylikPrimListesi.DataSource = this.aylikPrimListesiBindingSource1;
            this.aylikPrimListesi.Location = new System.Drawing.Point(33, 220);
            this.aylikPrimListesi.Name = "aylikPrimListesi";
            this.aylikPrimListesi.RowHeadersWidth = 51;
            this.aylikPrimListesi.RowTemplate.Height = 24;
            this.aylikPrimListesi.Size = new System.Drawing.Size(1527, 473);
            this.aylikPrimListesi.TabIndex = 10;
            this.aylikPrimListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aylikPrimListesi_CellContentClick);
            this.aylikPrimListesi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.aylikPrimListesi_CellFormatting);
            // 
            // aylikPrimListesiBindingSource
            // 
            this.aylikPrimListesiBindingSource.DataMember = "AylikPrimListesi";
            this.aylikPrimListesiBindingSource.DataSource = this.vTYSProjeDataSet4;
            // 
            // vTYSProjeDataSet4
            // 
            this.vTYSProjeDataSet4.DataSetName = "VTYSProjeDataSet4";
            this.vTYSProjeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aylikPrimListesiTableAdapter
            // 
            this.aylikPrimListesiTableAdapter.ClearBeforeFill = true;
            // 
            // vTYSProjeDataSet5
            // 
            this.vTYSProjeDataSet5.DataSetName = "VTYSProjeDataSet5";
            this.vTYSProjeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aylikPrimListesiBindingSource1
            // 
            this.aylikPrimListesiBindingSource1.DataMember = "AylikPrimListesi";
            this.aylikPrimListesiBindingSource1.DataSource = this.vTYSProjeDataSet5;
            // 
            // aylikPrimListesiTableAdapter1
            // 
            this.aylikPrimListesiTableAdapter1.ClearBeforeFill = true;
            // 
            // ayDataGridViewTextBoxColumn
            // 
            this.ayDataGridViewTextBoxColumn.DataPropertyName = "Ay";
            this.ayDataGridViewTextBoxColumn.HeaderText = "Ay";
            this.ayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ayDataGridViewTextBoxColumn.Name = "ayDataGridViewTextBoxColumn";
            // 
            // aylıkPrimToplamıDataGridViewTextBoxColumn
            // 
            this.aylıkPrimToplamıDataGridViewTextBoxColumn.DataPropertyName = "Aylık Prim Toplamı";
            this.aylıkPrimToplamıDataGridViewTextBoxColumn.HeaderText = "Aylık Prim Toplamı";
            this.aylıkPrimToplamıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aylıkPrimToplamıDataGridViewTextBoxColumn.Name = "aylıkPrimToplamıDataGridViewTextBoxColumn";
            this.aylıkPrimToplamıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itirazHakkıDataGridViewTextBoxColumn
            // 
            this.itirazHakkıDataGridViewTextBoxColumn.DataPropertyName = "İtiraz Hakkı";
            this.itirazHakkıDataGridViewTextBoxColumn.HeaderText = "İtiraz Hakkı";
            this.itirazHakkıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itirazHakkıDataGridViewTextBoxColumn.Name = "itirazHakkıDataGridViewTextBoxColumn";
            this.itirazHakkıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Asistan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.aylikPrimListesi);
            this.Controls.Add(this.btnItirazEkle);
            this.Controls.Add(this.primItirazlari);
            this.Controls.Add(this.btnAsistanExit);
            this.Controls.Add(this.labBanaGelenCagrilar);
            this.Controls.Add(this.btnYeniCagri);
            this.Controls.Add(this.cagriListesi);
            this.Controls.Add(this.AsistanID);
            this.Controls.Add(this.labAsistan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Asistan";
            this.Text = "Asistan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Asistan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cagriListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primItirazlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikPrimListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikPrimListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTYSProjeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aylikPrimListesiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labAsistan;
        private System.Windows.Forms.Label AsistanID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CagriListesiMenusu;
        private System.Windows.Forms.ToolStripMenuItem AylikPrimleriMenusu;
        private System.Windows.Forms.ToolStripMenuItem PrimItirazlariMenusu;
        private System.Windows.Forms.Button btnYeniCagri;
        private System.Windows.Forms.Label labBanaGelenCagrilar;
        private System.Windows.Forms.Button btnAsistanExit;
        private System.Windows.Forms.DataGridView cagriListesi;
        private System.Windows.Forms.DataGridView primItirazlari;
        private System.Windows.Forms.Button btnItirazEkle;
        private System.Windows.Forms.DataGridView aylikPrimListesi;
        private VTYSProjeDataSet4 vTYSProjeDataSet4;
        private System.Windows.Forms.BindingSource aylikPrimListesiBindingSource;
        private VTYSProjeDataSet4TableAdapters.AylikPrimListesiTableAdapter aylikPrimListesiTableAdapter;
        private VTYSProjeDataSet5 vTYSProjeDataSet5;
        private System.Windows.Forms.BindingSource aylikPrimListesiBindingSource1;
        private VTYSProjeDataSet5TableAdapters.AylikPrimListesiTableAdapter aylikPrimListesiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aylıkPrimToplamıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itirazHakkıDataGridViewTextBoxColumn;
    }
}
