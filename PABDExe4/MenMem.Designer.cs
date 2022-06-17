namespace PABDExe4
{
    partial class MenMem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenMem));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnBinMem = new System.Windows.Forms.Button();
            this.mnMem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("TLHALFTIME", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "Menu Member";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Binding Navigation Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TLHALFTIME", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data Member";
            // 
            // mnBinMem
            // 
            this.mnBinMem.BackColor = System.Drawing.Color.Transparent;
            this.mnBinMem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnBinMem.BackgroundImage")));
            this.mnBinMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnBinMem.Location = new System.Drawing.Point(483, 160);
            this.mnBinMem.Name = "mnBinMem";
            this.mnBinMem.Size = new System.Drawing.Size(122, 110);
            this.mnBinMem.TabIndex = 11;
            this.mnBinMem.UseVisualStyleBackColor = false;
            this.mnBinMem.Click += new System.EventHandler(this.mnBinMem_Click);
            // 
            // mnMem
            // 
            this.mnMem.BackColor = System.Drawing.Color.Transparent;
            this.mnMem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnMem.BackgroundImage")));
            this.mnMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnMem.Image = ((System.Drawing.Image)(resources.GetObject("mnMem.Image")));
            this.mnMem.Location = new System.Drawing.Point(132, 153);
            this.mnMem.Name = "mnMem";
            this.mnMem.Size = new System.Drawing.Size(128, 124);
            this.mnMem.TabIndex = 10;
            this.mnMem.UseVisualStyleBackColor = false;
            this.mnMem.Click += new System.EventHandler(this.mnMem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Futura Md BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnBinMem);
            this.Controls.Add(this.mnMem);
            this.Name = "MenMem";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mnBinMem;
        private System.Windows.Forms.Button mnMem;
        private System.Windows.Forms.Button button1;
    }
}