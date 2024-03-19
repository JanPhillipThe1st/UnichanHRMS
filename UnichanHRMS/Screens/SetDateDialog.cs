using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnichanHRMS.Screens
{
    public partial class SetDateDialog : Form
    {
        DateTime value = DateTime.MinValue;
        public delegate void CallBackFunction(DateTime f_i_d);
        CallBackFunction callback;
        public SetDateDialog( DateTime value, CallBackFunction callback)
        {
            InitializeComponent();
            this.value= value;
            this.callback = callback;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetDateDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            value = dtpApplicationDate.Value;
            callback(value);
            this.Close();
        }
    }
}
