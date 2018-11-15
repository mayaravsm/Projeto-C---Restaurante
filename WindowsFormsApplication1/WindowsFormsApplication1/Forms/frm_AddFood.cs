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
	public partial class frm_AddFood : Form
	{
		Pratocs prato = new Pratocs();
		public frm_AddFood()
		{
			InitializeComponent();
		}

		private void frm_AddFood_Load(object sender, EventArgs e)
		{
			cb_tipo.Items.Add("Comida");
			cb_tipo.Items.Add("Bebida");
			cb_tipo.Items.Add("Sobremesa");
		}

		private void exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			prato.Add_Prato(txb_nameFood.Text, int.Parse(txb_valor.Text), cb_tipo.Text, txb_DescFood.Text);
			MessageBox.Show("Prato cadastrado com sucesso!");
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }
    }
}
