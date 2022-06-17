namespace PABDExe4
{
    partial class MenPeg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenPeg));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnBinPeg = new System.Windows.Forms.Button();
            this.mnDatPeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Binding Navigation Pegawai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Pegawai";
            // 
            // mnBinPeg
            // 
            this.mnBinPeg.BackColor = System.Drawing.Color.Transparent;
            this.mnBinPeg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnBinPeg.BackgroundImage")));
            this.mnBinPeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnBinPeg.Location = new System.Drawing.Point(500, 149);
            this.mnBinPeg.Name = "mnBinPeg";
            this.mnBinPeg.Size = new System.Drawing.Size(122, 110);
            this.mnBinPeg.TabIndex = 6;
            this.mnBinPeg.UseVisualStyleBackColor = false;
            this.mnBinPeg.Click += new System.EventHandler(this.button2_Click);
            // 
            // mnDatPeg
            // 
            this.mnDatPeg.BackColor = System.Drawing.Color.Transparent;
            this.mnDatPeg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnDatPeg.BackgroundImage")));
            this.mnDatPeg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnDatPeg.Image = ((System.Drawing.Image)(resources.GetObject("mnDatPeg.Image")));
            this.mnDatPeg.Location = new System.Drawing.Point(149, 142);
            this.mnDatPeg.Name = "mnDatPeg";
            this.mnDatPeg.Size = new System.Drawing.Size(128, 124);
            this.mnDatPeg.TabIndex = 5;
            this.mnDatPeg.UseVisualStyleBackColor = false;
            this.mnDatPeg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu Pegawai";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MenPeg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnBinPeg);
            this.Controls.Add(this.mnDatPeg);
            this.Name = "MenPeg";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mnBinPeg;
        private System.Windows.Forms.Button mnDatPeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}