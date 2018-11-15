using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

		private void btn_pr_Click(object sender, EventArgs e)
		{
		}

		private void btn_beb_Click(object sender, EventArgs e)
		{
		}

		private void btn_sob_Click(object sender, EventArgs e)
		{
		}
	}
}
