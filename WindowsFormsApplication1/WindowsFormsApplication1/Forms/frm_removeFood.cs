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
    public partial class frm_removeFood : Form
    {
        DAO dao = new DAO();

        public frm_removeFood()
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

               private void frm_removeFood_Load(object sender, EventArgs e)
        {
            
            grid_remove.DataSource = dao.listar_pratos();
        }

        private void grid_remove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dao.remover_prato(int.Parse(grid_remove.CurrentRow.Cells[0].Value.ToString()));
            grid_remove.DataSource = dao.listar_pratos();
        }
    }
}
