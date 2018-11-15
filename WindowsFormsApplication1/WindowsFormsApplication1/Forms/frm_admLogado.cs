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
	public partial class frm_admLogado : Form
	{

		public frm_admLogado()
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

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btn_newFood_Click(object sender, EventArgs e)
		{
			frm_AddFood newfood = new frm_AddFood();
			newfood.ShowDialog();
			this.Close();
		}

		private void btn_newFun_Click(object sender, EventArgs e)
		{
			frm_AddFuncionario addFun = new frm_AddFuncionario();
			addFun.ShowDialog();
			this.Close();
		}

        private void btn_DelFood_Click(object sender, EventArgs e)
        {
            frm_removeFood remover = new frm_removeFood();
            remover.ShowDialog();
        }

        private void btn_Dellfun_Click(object sender, EventArgs e)
        {
            
        }
    }
}
