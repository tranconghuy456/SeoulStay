using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_1.Views
{
    public partial class frm_Management : Form
    {
        private int userRole = 1;
        public frm_Management()
        {
            InitializeComponent();
        }

        private void frm_Management_Load(object sender, EventArgs e)
        {
            MessageBox.Show(userRole.ToString());
        }
    }
}
