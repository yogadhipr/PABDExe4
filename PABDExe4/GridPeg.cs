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
    public partial class GridPeg : Form
    {
        public GridPeg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenPeg().Show();
            this.Close();
        }

        private void GridPeg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pABDExe2_PERPUSDataSet2.pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.pABDExe2_PERPUSDataSet2.pegawai);

        }
    }
}
