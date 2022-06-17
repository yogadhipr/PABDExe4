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
    public partial class GridBuku : Form
    {
        public GridBuku()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenBuk().Show();
            this.Close();
        }

        private void GridBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pABDExe2_PERPUSDataSet.buku_perpus' table. You can move, or remove it, as needed.
            this.buku_perpusTableAdapter.Fill(this.pABDExe2_PERPUSDataSet.buku_perpus);

        }
    }
}
