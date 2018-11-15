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
	public partial class frm_AddFuncionario : Form
	{
		Funcionario funcionario = new Funcionario();

		public frm_AddFuncionario()
		{
			InitializeComponent();
		}

		private void frm_AddFuncionario_Load(object sender, EventArgs e)
		{
			cb_cargoFun.Items.Add("Adiministrador");
			cb_cargoFun.Items.Add("Garçom");
			cb_cargoFun.Items.Add("Cozinheiro");
		}

		private void exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void cb_cargoFun_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_cargoFun.Text == "Adiministrador")
			{
				lb_codFun.Text = "A";
				txb_senhaFun.Text = "A"+txb_senhaFun.Text;
			}
			else if (cb_cargoFun.Text == "Garçom")
			{
				lb_codFun.Text = "G";
				txb_senhaFun.Text = "G" + txb_senhaFun.Text;
			}
			else if (cb_cargoFun.Text == "Cozinheiro")
			{
				lb_codFun.Text = "C";
				txb_senhaFun.Text = "C" + txb_senhaFun.Text;
			}
		}

		private void btn_addFun_Click(object sender, EventArgs e)
		{
			funcionario.add_funcionario(txb_cpfFun.Text, txb_nomeFun.Text, cb_cargoFun.Text, txb_senhaFun.Text);
			MessageBox.Show("Funcionário cadastrado!");
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
