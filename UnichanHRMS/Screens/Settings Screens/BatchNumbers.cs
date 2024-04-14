using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnichanHRMS.Screens.Settings_Screens
{
    public partial class BatchNumbers : Form
    {
        Database database = new Database();
        public BatchNumbers()
        {
            InitializeComponent();
        }

        private void BatchNumbers_Load(object sender, EventArgs e)
        {
            database.fillBatchTable(ref dgvBatchList);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new NewBatch(ref dgvBatchList).ShowDialog();
        }
    }
}
