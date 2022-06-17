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
    public partial class MenPeg : Form
    {
        public MenPeg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GridPeg().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BinPeg().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new MenUt().Show();
            this.Close();
        }
    }
}
