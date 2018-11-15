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
	public partial class frm_funcLogin : Form
	{

		Funcionario Func = new Funcionario();


		public frm_funcLogin()
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

		private void btn_Login_Click(object sender, EventArgs e)
		{
			Func.acess(txb_cpffun.Text, txb_CodFun.Text);
			if (Func.verify)
			{
                frm_admLogado adm = new frm_admLogado();
				adm.ShowDialog();
				this.Close();
			}


			else
			{
				MessageBox.Show("Usuario não encontrado");
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

        private void frm_funcLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_start back = new frm_start();
            back.ShowDialog();
            this.Close();
        }
    }
}
