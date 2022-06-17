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
    public partial class GridMem : Form
    {
        public GridMem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenMem().Show();
            this.Close();
        }

        private void GridMem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pABDExe2_PERPUSDataSet1.member_perpus' table. You can move, or remove it, as needed.
            this.member_perpusTableAdapter.Fill(this.pABDExe2_PERPUSDataSet1.member_perpus);

        }
    }
}
