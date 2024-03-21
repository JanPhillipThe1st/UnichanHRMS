using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnichanHRMS.Models;

namespace UnichanHRMS.Screens
{
    public partial class NewBatch : Form
    {
        Database database = new Database();
        DataGridView dgvBatchList = new DataGridView();
        Batch batch = new Batch();
        public NewBatch(ref DataGridView dgvBatchList)
        {
            InitializeComponent();
            this.dgvBatchList = dgvBatchList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            batch.batch_number = Convert.ToInt32(tbBatchNumber.Text);
            batch.applicants = Convert.ToInt32(tbApplicants.Text);
            batch.hired_applicants = Convert.ToInt32(tbHiredApplicants.Text);
            batch.hiring_date = dtpHiringdate.Value;
            if ( MessageBox.Show("Are you sure you want to add this record?","Add batch number",MessageBoxButtons.YesNo,MessageBoxIcon.Question)  == DialogResult.Yes )
            {
                database.addBatch(batch);
            }
        }

        private void AddApplicant_Load(object sender, EventArgs e)
        {
        }

        private void NewBatch_Validated(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all input?", "Clear inputs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Clear();
                    }
                    if (control is MaskedTextBox)
                    {
                        MaskedTextBox textBox = (MaskedTextBox)control;
                        textBox.Clear();
                    }
                }

            }
        }
    }
}
