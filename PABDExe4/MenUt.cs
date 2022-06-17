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
    public partial class MenUt : Form
    {
        public MenUt()
        {
            InitializeComponent();
        }

        private void btPeg_Click(object sender, EventArgs e)
        {
            new MenPeg().Show();
            this.Hide();
        }

        private void btBuku_Click(object sender, EventArgs e)
        {
            new MenBuk().Show();
            this.Hide();
        }

        private void btMem_Click(object sender, EventArgs e)
        {
            new MenMem().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
