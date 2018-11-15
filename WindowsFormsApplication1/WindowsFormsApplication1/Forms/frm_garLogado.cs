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
	public partial class frm_garLogado : Form
	{
		public frm_garLogado()
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
	}
}
