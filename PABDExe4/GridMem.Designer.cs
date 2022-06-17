namespace PABDExe4
{
    partial class GridMem
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
            this.dgMem = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pABDExe2_PERPUSDataSet = new PABDExe4.PABDExe2_PERPUSDataSet();
            this.pABDExe2PERPUSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pABDExe2_PERPUSDataSet1 = new PABDExe4.PABDExe2_PERPUSDataSet1();
            this.memberperpusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.member_perpusTableAdapter = new PABDExe4.PABDExe2_PERPUSDataSet1TableAdapters.member_perpusTableAdapter();
            this.idmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pekerjaanmemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2PERPUSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberperpusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 49);
            this.label1.TabIndex = 18;
            this.label1.Text = "Data Member";
            // 
            // dgMem
            // 
            this.dgMem.AutoGenerateColumns = false;
            this.dgMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmemberDataGridViewTextBoxColumn,
            this.namamemberDataGridViewTextBoxColumn,
            this.alamatmemberDataGridViewTextBoxColumn,
            this.pekerjaanmemberDataGridViewTextBoxColumn});
            this.dgMem.DataSource = this.memberperpusBindingSource;
            this.dgMem.Location = new System.Drawing.Point(12, 86);
            this.dgMem.Name = "dgMem";
            this.dgMem.RowHeadersWidth = 51;
            this.dgMem.RowTemplate.Height = 24;
            this.dgMem.Size = new System.Drawing.Size(776, 319);
            this.dgMem.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pABDExe2_PERPUSDataSet
            // 
            this.pABDExe2_PERPUSDataSet.DataSetName = "PABDExe2_PERPUSDataSet";
            this.pABDExe2_PERPUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pABDExe2PERPUSDataSetBindingSource
            // 
            this.pABDExe2PERPUSDataSetBindingSource.DataSource = this.pABDExe2_PERPUSDataSet;
            this.pABDExe2PERPUSDataSetBindingSource.Position = 0;
            // 
            // pABDExe2_PERPUSDataSet1
            // 
            this.pABDExe2_PERPUSDataSet1.DataSetName = "PABDExe2_PERPUSDataSet1";
            this.pABDExe2_PERPUSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberperpusBindingSource
            // 
            this.memberperpusBindingSource.DataMember = "member_perpus";
            this.memberperpusBindingSource.DataSource = this.pABDExe2_PERPUSDataSet1;
            // 
            // member_perpusTableAdapter
            // 
            this.member_perpusTableAdapter.ClearBeforeFill = true;
            // 
            // idmemberDataGridViewTextBoxColumn
            // 
            this.idmemberDataGridViewTextBoxColumn.DataPropertyName = "id_member";
            this.idmemberDataGridViewTextBoxColumn.HeaderText = "id_member";
            this.idmemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmemberDataGridViewTextBoxColumn.Name = "idmemberDataGridViewTextBoxColumn";
            this.idmemberDataGridViewTextBoxColumn.Width = 125;
            // 
            // namamemberDataGridViewTextBoxColumn
            // 
            this.namamemberDataGridViewTextBoxColumn.DataPropertyName = "nama_member";
            this.namamemberDataGridViewTextBoxColumn.HeaderText = "nama_member";
            this.namamemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namamemberDataGridViewTextBoxColumn.Name = "namamemberDataGridViewTextBoxColumn";
            this.namamemberDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatmemberDataGridViewTextBoxColumn
            // 
            this.alamatmemberDataGridViewTextBoxColumn.DataPropertyName = "alamat_member";
            this.alamatmemberDataGridViewTextBoxColumn.HeaderText = "alamat_member";
            this.alamatmemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatmemberDataGridViewTextBoxColumn.Name = "alamatmemberDataGridViewTextBoxColumn";
            this.alamatmemberDataGridViewTextBoxColumn.Width = 125;
            // 
            // pekerjaanmemberDataGridViewTextBoxColumn
            // 
            this.pekerjaanmemberDataGridViewTextBoxColumn.DataPropertyName = "pekerjaan_member";
            this.pekerjaanmemberDataGridViewTextBoxColumn.HeaderText = "pekerjaan_member";
            this.pekerjaanmemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pekerjaanmemberDataGridViewTextBoxColumn.Name = "pekerjaanmemberDataGridViewTextBoxColumn";
            this.pekerjaanmemberDataGridViewTextBoxColumn.Width = 125;
            // 
            // GridMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgMem);
            this.Controls.Add(this.label1);
            this.Name = "GridMem";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GridMem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2PERPUSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberperpusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgMem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource pABDExe2PERPUSDataSetBindingSource;
        private PABDExe2_PERPUSDataSet pABDExe2_PERPUSDataSet;
        private PABDExe2_PERPUSDataSet1 pABDExe2_PERPUSDataSet1;
        private System.Windows.Forms.BindingSource memberperpusBindingSource;
        private PABDExe2_PERPUSDataSet1TableAdapters.member_perpusTableAdapter member_perpusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatmemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pekerjaanmemberDataGridViewTextBoxColumn;
    }
}