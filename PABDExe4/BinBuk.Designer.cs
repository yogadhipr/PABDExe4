namespace PABDExe4
{
    partial class BinBuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinBuk));
            this.btBukuDel = new System.Windows.Forms.Button();
            this.btBukuSv = new System.Windows.Forms.Button();
            this.btBukuAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbBukuJml = new System.Windows.Forms.TextBox();
            this.bukuperpusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pABDExe2_PERPUSDataSet = new PABDExe4.PABDExe2_PERPUSDataSet();
            this.tbBukuJud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBukuID = new System.Windows.Forms.TextBox();
            this.cbBukuJen = new System.Windows.Forms.ComboBox();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buku_perpusTableAdapter = new PABDExe4.PABDExe2_PERPUSDataSetTableAdapters.buku_perpusTableAdapter();
            this.pABDExe2_PERPUSDataSet5 = new PABDExe4.PABDExe2_PERPUSDataSet5();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bukuperpusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // btBukuDel
            // 
            this.btBukuDel.Font = new System.Drawing.Font("TLHALFTIME", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBukuDel.Location = new System.Drawing.Point(650, 311);
            this.btBukuDel.Name = "btBukuDel";
            this.btBukuDel.Size = new System.Drawing.Size(92, 41);
            this.btBukuDel.TabIndex = 15;
            this.btBukuDel.Text = "Delete";
            this.btBukuDel.UseVisualStyleBackColor = true;
            this.btBukuDel.Click += new System.EventHandler(this.btBukuDel_Click);
            // 
            // btBukuSv
            // 
            this.btBukuSv.Font = new System.Drawing.Font("TLHALFTIME", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBukuSv.Location = new System.Drawing.Point(650, 243);
            this.btBukuSv.Name = "btBukuSv";
            this.btBukuSv.Size = new System.Drawing.Size(92, 41);
            this.btBukuSv.TabIndex = 14;
            this.btBukuSv.Text = "Save";
            this.btBukuSv.UseVisualStyleBackColor = true;
            this.btBukuSv.Click += new System.EventHandler(this.btBukuSv_Click);
            // 
            // btBukuAdd
            // 
            this.btBukuAdd.Font = new System.Drawing.Font("TLHALFTIME", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBukuAdd.Location = new System.Drawing.Point(650, 179);
            this.btBukuAdd.Name = "btBukuAdd";
            this.btBukuAdd.Size = new System.Drawing.Size(92, 41);
            this.btBukuAdd.TabIndex = 12;
            this.btBukuAdd.Text = "Add";
            this.btBukuAdd.UseVisualStyleBackColor = true;
            this.btBukuAdd.Click += new System.EventHandler(this.btBukuAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 49);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data Buku";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.1982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.8018F));
            this.tableLayoutPanel1.Controls.Add(this.tbBukuJml, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbBukuJud, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbBukuID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbBukuJen, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 257);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tbBukuJml
            // 
            this.tbBukuJml.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuperpusBindingSource, "jml_buku", true));
            this.tbBukuJml.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBukuJml.Location = new System.Drawing.Point(215, 204);
            this.tbBukuJml.Name = "tbBukuJml";
            this.tbBukuJml.Size = new System.Drawing.Size(337, 41);
            this.tbBukuJml.TabIndex = 16;
            // 
            // bukuperpusBindingSource
            // 
            this.bukuperpusBindingSource.DataMember = "buku_perpus";
            this.bukuperpusBindingSource.DataSource = this.pABDExe2_PERPUSDataSet;
            // 
            // pABDExe2_PERPUSDataSet
            // 
            this.pABDExe2_PERPUSDataSet.DataSetName = "PABDExe2_PERPUSDataSet";
            this.pABDExe2_PERPUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbBukuJud
            // 
            this.tbBukuJud.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuperpusBindingSource, "judul_buku", true));
            this.tbBukuJud.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBukuJud.Location = new System.Drawing.Point(215, 71);
            this.tbBukuJud.Name = "tbBukuJud";
            this.tbBukuJud.Size = new System.Drawing.Size(337, 41);
            this.tbBukuJud.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Judul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Buku";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Jumlah";
            // 
            // tbBukuID
            // 
            this.tbBukuID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuperpusBindingSource, "id_buku", true));
            this.tbBukuID.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBukuID.Location = new System.Drawing.Point(215, 3);
            this.tbBukuID.Name = "tbBukuID";
            this.tbBukuID.Size = new System.Drawing.Size(337, 41);
            this.tbBukuID.TabIndex = 10;
            // 
            // cbBukuJen
            // 
            this.cbBukuJen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bukuperpusBindingSource, "jenis_buku", true));
            this.cbBukuJen.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBukuJen.FormattingEnabled = true;
            this.cbBukuJen.Location = new System.Drawing.Point(215, 139);
            this.cbBukuJen.Name = "cbBukuJen";
            this.cbBukuJen.Size = new System.Drawing.Size(337, 42);
            this.cbBukuJen.TabIndex = 14;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bukuperpusBindingSource;
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
            this.bindingNavigator1.TabIndex = 18;
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
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.pABDExe2_PERPUSDataSet;
            this.bindingSource1.Position = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buku_perpusTableAdapter
            // 
            this.buku_perpusTableAdapter.ClearBeforeFill = true;
            // 
            // pABDExe2_PERPUSDataSet5
            // 
            this.pABDExe2_PERPUSDataSet5.DataSetName = "PABDExe2_PERPUSDataSet5";
            this.pABDExe2_PERPUSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BinBuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBukuDel);
            this.Controls.Add(this.btBukuSv);
            this.Controls.Add(this.btBukuAdd);
            this.Name = "BinBuk";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.BinBuk_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bukuperpusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABDExe2_PERPUSDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBukuDel;
        private System.Windows.Forms.Button btBukuSv;
        private System.Windows.Forms.Button btBukuAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBukuID;
        private System.Windows.Forms.TextBox tbBukuJml;
        private System.Windows.Forms.TextBox tbBukuJud;
        private System.Windows.Forms.ComboBox cbBukuJen;
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
        private System.Windows.Forms.Button button1;
        private PABDExe2_PERPUSDataSet pABDExe2_PERPUSDataSet;
        private System.Windows.Forms.BindingSource bukuperpusBindingSource;
        private PABDExe2_PERPUSDataSetTableAdapters.buku_perpusTableAdapter buku_perpusTableAdapter;
        private PABDExe2_PERPUSDataSet5 pABDExe2_PERPUSDataSet5;
    }
}