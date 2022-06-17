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
    public partial class BinMem : Form
    {
        public BinMem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenMem().Show();
            this.Close();
        }

        private void BinMem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pABDExe2_PERPUSDataSet1.member_perpus' table. You can move, or remove it, as needed.
            this.member_perpusTableAdapter.Fill(this.pABDExe2_PERPUSDataSet1.member_perpus);

        }

        private void btMemAdd_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            btMemSv.Enabled = true;

            tbMemID.Enabled = true;
            tbMemNama.Enabled = true;
            tbMemAlmt.Enabled = true;
            tbMemPek.Enabled = true;

            tbMemID.Text = "";
            tbMemNama.Text = "";
            tbMemPek.Text = "";
            tbMemAlmt.Text = "";

            int ctr, len;
            string codeval;
            dt = pABDExe2_PERPUSDataSet1.Tables["member_perpus"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            Code = dr["id_member"].ToString();

            codeval = Code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 0) && (ctr < 9))
            {
                ctr = ctr + 1;
                tbMemID.Text = "M00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                tbMemID.Text = "M0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                tbMemID.Text = "M" + ctr;
            }
            btMemAdd.Enabled = false;
        }

        private void btMemSv_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            dt = pABDExe2_PERPUSDataSet1.Tables["member_perpus"];
            dr = dt.NewRow();

            dr[0] = tbMemID.Text;
            dr[1] = tbMemNama.Text;
            dr[2] = tbMemPek.Text;
            dr[3] = tbMemAlmt.Text;

            dt.Rows.Add(dr);

            member_perpusTableAdapter.Update(pABDExe2_PERPUSDataSet1);
            tbMemID.Text = System.Convert.ToString(dr[0]);
            tbMemNama.Enabled = false;
            tbMemPek.Enabled = false;
            tbMemAlmt.Enabled = false;

            this.member_perpusTableAdapter.Fill(this.pABDExe2_PERPUSDataSet1.member_perpus);

            btMemAdd.Enabled = true;
            btMemSv.Enabled = false;
        }

        private void btMemDel_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            Code = tbMemID.Text;
            dr = pABDExe2_PERPUSDataSet1.Tables["member_perpus"].Rows.Find(Code);
            dr.Delete();
            member_perpusTableAdapter.Update(pABDExe2_PERPUSDataSet1);
        }
    }
}
