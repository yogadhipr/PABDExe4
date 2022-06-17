using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABDExe4
{
    public partial class MenBuk : Form
    {
        public MenBuk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GridBuku().Show();
            this.Hide();
        }

        private void mnBinBuku_Click(object sender, EventArgs e)
        {
            new BinBuk().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new MenUt().Show();
            this.Close();
        }
    }
}
