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
    public partial class BinPeg : Form
    {
        public BinPeg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenPeg().Show();
            this.Close();
        }

        private void btPegAdd_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            btPegSv.Enabled = true;

            tbPegID.Enabled = true;
            tbPegNama.Enabled = true;
            tbPegAlmt.Enabled = true;
            cbPegJab.Enabled = true;

            tbPegID.Text = "";
            tbPegNama.Text = "";
            cbPegJab.Text = "";
            tbPegAlmt.Text = "";

            int ctr, len;
            string codeval;
            dt = pABDExe2_PERPUSDataSet2.Tables["pegawai"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            Code = dr["id_pegawai"].ToString();

            codeval = Code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 0) && (ctr < 9))
            {
                ctr = ctr + 1;
                tbPegID.Text = "E00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                tbPegID.Text = "E0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                tbPegID.Text = "E" + ctr;
            }
            btPegAdd.Enabled = false;
        }

        private void BinPeg_Load(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string code;

            // TODO: This line of code loads data into the 'pABDExe2_PERPUSDataSet2.pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.pABDExe2_PERPUSDataSet2.pegawai);

            tbPegID.Enabled = false;
            tbPegNama.Enabled = false;
            cbPegJab.Enabled = false;
            tbPegAlmt.Enabled = false;

            cbPegJab.Items.Add("CEO");
            cbPegJab.Items.Add("Manager");
            cbPegJab.Items.Add("Kepala Bidang");
            cbPegJab.Items.Add("Supervisor");
            
            btPegSv.Enabled = false;

        }

        private void btPegSv_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            dt = pABDExe2_PERPUSDataSet2.Tables["pegawai"];
            dr = dt.NewRow();

            dr[0] = tbPegID.Text;
            dr[1] = tbPegNama.Text;
            dr[2] = cbPegJab.SelectedItem;
            dr[3] = tbPegAlmt.Text;

            dt.Rows.Add(dr);

            pegawaiTableAdapter.Update(pABDExe2_PERPUSDataSet2);
            tbPegID.Text = System.Convert.ToString(dr[0]);            
            tbPegNama.Enabled = false;
            cbPegJab.Enabled = false;
            tbPegAlmt.Enabled = false;

            this.pegawaiTableAdapter.Fill(this.pABDExe2_PERPUSDataSet2.pegawai);

            btPegAdd.Enabled = true;
            btPegSv.Enabled = false;
        }

        private void btPegDel_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            Code = tbPegID.Text;
            dr = pABDExe2_PERPUSDataSet2.Tables["pegawai"].Rows.Find(Code);
            dr.Delete();
            pegawaiTableAdapter.Update(pABDExe2_PERPUSDataSet2);
        }
    }
}
