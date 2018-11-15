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

    public partial class frm_cliente : Form
    {
        Cliente c = new Cliente();
        frm_menu go = new frm_menu();

        public frm_cliente()
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

        private void btn_nextn_Click(object sender, EventArgs e)
        {
            c.cadcliente(txt_nome.Text, txtcpf.Text);
            go.ShowDialog();

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_start back = new frm_start();
            back.ShowDialog();
        }
    }


}
