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
    public partial class BinBuk : Form
    {
        public BinBuk()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MenBuk().Show();
            this.Close();
        }

        private void BinBuk_Load(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string code;

            // TODO: This line of code loads data into the 'pABDExe2_PERPUSDataSet.buku_perpus' table. You can move, or remove it, as needed.
            this.buku_perpusTableAdapter.Fill(this.pABDExe2_PERPUSDataSet.buku_perpus);

            tbBukuID.Enabled = false;
            tbBukuJud.Enabled = false;
            cbBukuJen.Enabled = false;
            tbBukuJml.Enabled = false;

            cbBukuJen.Items.Add("Fiksi");
            cbBukuJen.Items.Add("Non-Fiksi");

            btBukuSv.Enabled = false;

        }

        private void btBukuAdd_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            btBukuSv.Enabled = true;

            tbBukuID.Enabled = true;
            tbBukuJud.Enabled = true;
            cbBukuJen.Enabled = true;
            tbBukuJml.Enabled = true;

            tbBukuID.Text = "";
            tbBukuJud.Text = "";
            cbBukuJen.Text = "";
            tbBukuJml.Text = "";

            int ctr, len;
            string codeval;
            dt = pABDExe2_PERPUSDataSet.Tables["buku_perpus"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            Code = dr["id_buku"].ToString();

            codeval = Code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if((ctr >= 0) && (ctr < 9))
            {
                ctr = ctr + 1;
                tbBukuID.Text = "B00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                tbBukuID.Text = "B0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                tbBukuID.Text = "B" + ctr;
            }
            btBukuAdd.Enabled = false;
        }

        private void btBukuSv_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            dt = pABDExe2_PERPUSDataSet.Tables["buku_perpus"];
            dr = dt.NewRow();

            dr[0] = tbBukuID.Text;
            dr[1] = tbBukuJud.Text;
            dr[2] = cbBukuJen.SelectedItem;
            dr[3] = tbBukuJml.Text;

            dt.Rows.Add(dr);

            buku_perpusTableAdapter.Update(pABDExe2_PERPUSDataSet);
            tbBukuID.Text = System.Convert.ToString(dr[0]);
            tbBukuJud.Enabled = false;
            cbBukuJen.Enabled = false;
            tbBukuJml.Enabled = false;

            this.buku_perpusTableAdapter.Fill(this.pABDExe2_PERPUSDataSet.buku_perpus);

            btBukuAdd.Enabled = true;
            btBukuSv.Enabled = false;
        }

        private void btBukuDel_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            Code = tbBukuID.Text;
            dr = pABDExe2_PERPUSDataSet.Tables["buku_perpus"].Rows.Find(Code);
            dr.Delete();
            buku_perpusTableAdapter.Update(pABDExe2_PERPUSDataSet);
        }
    }
}
