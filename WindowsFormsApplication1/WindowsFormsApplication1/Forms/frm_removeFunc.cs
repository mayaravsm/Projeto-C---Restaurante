using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class frm_removeFunc : Form
    {
        DAO dao = new DAO();

        public frm_removeFunc()
        {
            InitializeComponent();
        }

        private void frm_removeFunc_Load(object sender, EventArgs e)
        {
            grid_removeF.DataSource = dao.listar_func();
            
        }

        private void grid_removeF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dao.remover_func(int.Parse(grid_removeF.CurrentRow.Cells[0].Value.ToString()));
            grid_removeF.DataSource = dao.listar_func();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_admLogado back = new frm_admLogado();
            back.ShowDialog();
        }
    }
}
