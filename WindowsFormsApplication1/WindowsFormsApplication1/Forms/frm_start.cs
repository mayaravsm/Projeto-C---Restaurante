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
    public partial class frm_start : Form
    {
        public frm_start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frm_cliente cliente = new frm_cliente();
            cliente.ShowDialog();
			this.Close();
		}

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

		private void settings_Click(object sender, EventArgs e)
		{
			frm_funcLogin fun = new frm_funcLogin();
			fun.ShowDialog();
			this.Close();
		}
	}
}
