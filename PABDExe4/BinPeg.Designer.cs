namespace PABDExe4
{
    partial class BinPeg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinPeg));
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPegAlmt = new System.Windows.Forms.TextBox();
            this.tbPegNama = new System.Windows.Forms.TextBox();
            this.tbPegID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btPegAdd = new System.Windows.Forms.Button();
            this.btPegSv = new System.Windows.Forms.Button();
            this.btPegDel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cbPegJab = new System.Windows.Forms.ComboBox();
            this.pABDExe2_PERPUSDataSet2 = new PABDExe4.PABDExe2_PERPUSDataSet2();
            this.pegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pegawaiTableAdapter = new PABDExe4.PABDExe2_PERPUSDataSet2TableAdapters.pegawaiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pegawai";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.pegawaiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.1982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.8018F));
            this.tableLayoutPanel1.Controls.Add(this.tbPegNama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPegAlmt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPegID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbPegJab, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 257);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tbPegAlmt
            // 
            this.tbPegAlmt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "alamat_pegawai", true));
            this.tbPegAlmt.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPegAlmt.Location = new System.Drawing.Point(215, 204);
            this.tbPegAlmt.Name = "tbPegAlmt";
            this.tbPegAlmt.Size = new System.Drawing.Size(337, 41);
            this.tbPegAlmt.TabIndex = 14;
            // 
            // tbPegNama
            // 
            this.tbPegNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "nama_pegawai", true));
            this.tbPegNama.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPegNama.Location = new System.Drawing.Point(215, 71);
            this.tbPegNama.Name = "tbPegNama";
            this.tbPegNama.Size = new System.Drawing.Size(337, 41);
            this.tbPegNama.TabIndex = 12;
            // 
            // tbPegID
            // 
            this.tbPegID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "id_pegawai", true));
            this.tbPegID.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPegID.Location = new System.Drawing.Point(215, 3);
            this.tbPegID.Name = "tbPegID";
            this.tbPegID.Size = new System.Drawing.Size(337, 41);
            this.tbPegID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jabatan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Pegawai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alamat";
            // 
            // btPegAdd
            // 
            this.btPegAdd.Font = new System.Drawing.Font("TLHALFTIME", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPegAdd.Location = new System.Drawing.Point(661, 174);
            this.btPegAdd.Name = "btPegAdd";
            this.btPegAdd.Size = new System.Drawing.Size(92, 41);
            this.btPegAdd.TabIndex = 8;
            this.btPegAdd.Text = "Add";
            this.btPegAdd.UseVisualStyleBackColor = true;
            this.btPegAdd.Click += new System.EventHandler(this.btPegAdd_Click);
            // 
            // btPegSv
            // 
            this.btPegSv.Font = new System.Drawing.Font("TLHALFTIME", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPegSv.Location = new System.Drawing.Point(661, 239);
            this.btPegSv.Name = "btPegSv";
            this.btPegSv.Size = new System.Drawing.Size(92, 41);
            this.btPegSv.TabIndex = 10;
            this.btPegSv.Text = "Save";
            this.btPegSv.UseVisualStyleBackColor = true;
            this.btPegSv.Click += new System.EventHandler(this.btPegSv_Click);
            // 
            // btPegDel
            // 
            this.btPegDel.Font = new System.Drawing.Font("TLHALFTIME", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPegDel.Location = new System.Drawing.Point(661, 300);
            this.btPegDel.Name = "btPegDel";
            this.btPegDel.Size = new System.Drawing.Size(92, 41);
            this.btPegDel.TabIndex = 11;
            this.btPegDel.Text = "Delete";
            this.btPegDel.UseVisualStyleBackColor = true;
            this.btPegDel.Click += new System.EventHandler(this.btPegDel_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.pegawaiBindingSource;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPegJab
            // 
            this.cbPegJab.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pegawaiBindingSource, "jabatan", true));
            this.cbPegJab.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPegJab.FormattingEnabled = true;
            this.cbPegJab.Location = new System.Drawing.Point(215, 139);
            this.cbPegJab.Name = "cbPegJab";
            this.cbPegJab.Size = new System.Drawing.Size(337, 42);
            this.cbPegJab.TabIndex = 15;
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
            // BinPeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPegDel);
            this.Controls.Add(this.btPegSv);
            this.Controls.Add(this.btPegAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.label1);
            this.Name = "BinPeg";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BinPeg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pegawaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPegAdd;
        private System.Windows.Forms.Button btPegSv;
        private System.Windows.Forms.Button btPegDel;
        private System.Windows.Forms.TextBox tbPegAlmt;
        private System.Windows.Forms.TextBox tbPegNama;
        private System.Windows.Forms.TextBox tbPegID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPegJab;
        private PABDExe2_PERPUSDataSet2 pABDExe2_PERPUSDataSet2;
        private System.Windows.Forms.BindingSource pegawaiBindingSource;
        private PABDExe2_PERPUSDataSet2TableAdapters.pegawaiTableAdapter pegawaiTableAdapter;
    }
}