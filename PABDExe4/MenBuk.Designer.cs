namespace PABDExe4
{
    partial class MenBuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenBuk));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnBinBuku = new System.Windows.Forms.Button();
            this.mnBuku = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menu Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Binding Navigation Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Buku";
            // 
            // mnBinBuku
            // 
            this.mnBinBuku.BackColor = System.Drawing.Color.Transparent;
            this.mnBinBuku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnBinBuku.BackgroundImage")));
            this.mnBinBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnBinBuku.Location = new System.Drawing.Point(494, 192);
            this.mnBinBuku.Name = "mnBinBuku";
            this.mnBinBuku.Size = new System.Drawing.Size(122, 110);
            this.mnBinBuku.TabIndex = 11;
            this.mnBinBuku.UseVisualStyleBackColor = false;
            this.mnBinBuku.Click += new System.EventHandler(this.mnBinBuku_Click);
            // 
            // mnBuku
            // 
            this.mnBuku.BackColor = System.Drawing.Color.Transparent;
            this.mnBuku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnBuku.BackgroundImage")));
            this.mnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnBuku.Image = ((System.Drawing.Image)(resources.GetObject("mnBuku.Image")));
            this.mnBuku.Location = new System.Drawing.Point(122, 185);
            this.mnBuku.Name = "mnBuku";
            this.mnBuku.Size = new System.Drawing.Size(128, 124);
            this.mnBuku.TabIndex = 10;
            this.mnBuku.UseVisualStyleBackColor = false;
            this.mnBuku.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MenBuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnBinBuku);
            this.Controls.Add(this.mnBuku);
            this.Name = "MenBuk";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mnBinBuku;
        private System.Windows.Forms.Button mnBuku;
        private System.Windows.Forms.Button button1;
    }
}