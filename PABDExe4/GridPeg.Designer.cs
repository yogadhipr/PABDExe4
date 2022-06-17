namespace PABDExe4
{
    partial class GridPeg
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
            this.dgPeg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pABDExe2_PERPUSDataSet2 = new PABDExe4.PABDExe2_PERPUSDataSet2();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiTableAdapter = new PABDExe4.PABDExe2_PERPUSDataSet2TableAdapters.pegawaiTableAdapter();
            this.idpegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatpegawaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPeg
            // 
            this.dgPeg.AutoGenerateColumns = false;
            this.dgPeg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpegawaiDataGridViewTextBoxColumn,
            this.namapegawaiDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn,
            this.alamatpegawaiDataGridViewTextBoxColumn});
            this.dgPeg.DataSource = this.pegawaiBindingSource;
            this.dgPeg.Location = new System.Drawing.Point(12, 88);
            this.dgPeg.Name = "dgPeg";
            this.dgPeg.RowHeadersWidth = 51;
            this.dgPeg.RowTemplate.Height = 24;
            this.dgPeg.Size = new System.Drawing.Size(776, 319);
            this.dgPeg.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 49);
            this.label1.TabIndex = 20;
            this.label1.Text = "Data Pegawai";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pABDExe2_PERPUSDataSet2
            // 
            this.pABDExe2_PERPUSDataSet2.DataSetName = "PABDExe2_PERPUSDataSet2";
            this.pABDExe2_PERPUSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pegawaiBindingSource
            // 
            this.pegawaiBindingSource.DataMember = "pegawai";
            this.pegawaiBindingSource.DataSource = this.pABDExe2_PERPUSDataSet2;
            // 
            // pegawaiTableAdapter
            // 
            this.pegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // idpegawaiDataGridViewTextBoxColumn
            // 
            this.idpegawaiDataGridViewTextBoxColumn.DataPropertyName = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.HeaderText = "id_pegawai";
            this.idpegawaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpegawaiDataGridViewTextBoxColumn.Name = "idpegawaiDataGridViewTextBoxColumn";
            this.idpegawaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namapegawaiDataGridViewTextBoxColumn
            // 
            this.namapegawaiDataGridViewTextBoxColumn.DataPropertyName = "nama_pegawai";
            this.namapegawaiDataGridViewTextBoxColumn.HeaderText = "nama_pegawai";
            this.namapegawaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namapegawaiDataGridViewTextBoxColumn.Name = "namapegawaiDataGridViewTextBoxColumn";
            this.namapegawaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "jabatan";
            this.jabatanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            this.jabatanDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatpegawaiDataGridViewTextBoxColumn
            // 
            this.alamatpegawaiDataGridViewTextBoxColumn.DataPropertyName = "alamat_pegawai";
            this.alamatpegawaiDataGridViewTextBoxColumn.HeaderText = "alamat_pegawai";
            this.alamatpegawaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatpegawaiDataGridViewTextBoxColumn.Name = "alamatpegawaiDataGridViewTextBoxColumn";
            this.alamatpegawaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // GridPeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgPeg);
            this.Controls.Add(this.label1);
            this.Name = "GridPeg";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GridPeg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private PABDExe2_PERPUSDataSet2 pABDExe2_PERPUSDataSet2;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private PABDExe2_PERPUSDataSet2TableAdapters.pegawaiTableAdapter pegawaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapegawaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatpegawaiDataGridViewTextBoxColumn;
    }
}