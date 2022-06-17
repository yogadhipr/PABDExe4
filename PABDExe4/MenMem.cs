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
    public partial class MenMem : Form
    {
        public MenMem()
        {
            InitializeComponent();
        }

        private void mnBinMem_Click(object sender, EventArgs e)
        {
            new BinMem().Show();
            this.Hide();
        }

        private void mnMem_Click(object sender, EventArgs e)
        {
            new GridMem().Show(); 
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenUt().Show();
            this.Close();
        }
    }
}
