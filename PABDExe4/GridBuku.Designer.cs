namespace PABDExe4
{
    partial class GridBuku
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
            this.dgBuku = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pABDExe2_PERPUSDataSet = new PABDExe4.PABDExe2_PERPUSDataSet();
            this.bukuperpusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buku_perpusTableAdapter = new PABDExe4.PABDExe2_PERPUSDataSetTableAdapters.buku_perpusTableAdapter();
            this.idbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judulbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlbukuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuperpusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBuku
            // 
            this.dgBuku.AutoGenerateColumns = false;
            this.dgBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbukuDataGridViewTextBoxColumn,
            this.judulbukuDataGridViewTextBoxColumn,
            this.jenisbukuDataGridViewTextBoxColumn,
            this.jmlbukuDataGridViewTextBoxColumn});
            this.dgBuku.DataSource = this.bukuperpusBindingSource;
            this.dgBuku.Location = new System.Drawing.Point(12, 87);
            this.dgBuku.Name = "dgBuku";
            this.dgBuku.RowHeadersWidth = 51;
            this.dgBuku.RowTemplate.Height = 24;
            this.dgBuku.Size = new System.Drawing.Size(776, 319);
            this.dgBuku.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 49);
            this.label1.TabIndex = 20;
            this.label1.Text = "Data Buku";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pABDExe2_PERPUSDataSet
            // 
            this.pABDExe2_PERPUSDataSet.DataSetName = "PABDExe2_PERPUSDataSet";
            this.pABDExe2_PERPUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bukuperpusBindingSource
            // 
            this.bukuperpusBindingSource.DataMember = "buku_perpus";
            this.bukuperpusBindingSource.DataSource = this.pABDExe2_PERPUSDataSet;
            // 
            // buku_perpusTableAdapter
            // 
            this.buku_perpusTableAdapter.ClearBeforeFill = true;
            // 
            // idbukuDataGridViewTextBoxColumn
            // 
            this.idbukuDataGridViewTextBoxColumn.DataPropertyName = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.HeaderText = "id_buku";
            this.idbukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbukuDataGridViewTextBoxColumn.Name = "idbukuDataGridViewTextBoxColumn";
            this.idbukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // judulbukuDataGridViewTextBoxColumn
            // 
            this.judulbukuDataGridViewTextBoxColumn.DataPropertyName = "judul_buku";
            this.judulbukuDataGridViewTextBoxColumn.HeaderText = "judul_buku";
            this.judulbukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.judulbukuDataGridViewTextBoxColumn.Name = "judulbukuDataGridViewTextBoxColumn";
            this.judulbukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisbukuDataGridViewTextBoxColumn
            // 
            this.jenisbukuDataGridViewTextBoxColumn.DataPropertyName = "jenis_buku";
            this.jenisbukuDataGridViewTextBoxColumn.HeaderText = "jenis_buku";
            this.jenisbukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisbukuDataGridViewTextBoxColumn.Name = "jenisbukuDataGridViewTextBoxColumn";
            this.jenisbukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // jmlbukuDataGridViewTextBoxColumn
            // 
            this.jmlbukuDataGridViewTextBoxColumn.DataPropertyName = "jml_buku";
            this.jmlbukuDataGridViewTextBoxColumn.HeaderText = "jml_buku";
            this.jmlbukuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jmlbukuDataGridViewTextBoxColumn.Name = "jmlbukuDataGridViewTextBoxColumn";
            this.jmlbukuDataGridViewTextBoxColumn.Width = 125;
            // 
            // GridBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgBuku);
            this.Controls.Add(this.label1);
            this.Name = "GridBuku";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.GridBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuperpusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private PABDExe2_PERPUSDataSet pABDExe2_PERPUSDataSet;
        private System.Windows.Forms.BindingSource bukuperpusBindingSource;
        private PABDExe2_PERPUSDataSetTableAdapters.buku_perpusTableAdapter buku_perpusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisbukuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlbukuDataGridViewTextBoxColumn;
    }
}