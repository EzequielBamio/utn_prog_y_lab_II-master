using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_WindowsForms
{
    public partial class frmTesting : Form
    {
        public frmTesting()
        {
            InitializeComponent();
        }

        private void btnTesting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void frmTesting_Load(object sender, EventArgs e)
        {

        }
    }
}
