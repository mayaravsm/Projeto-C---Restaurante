using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	class Funcionario: Pessoa
	{
		DAO dao = new DAO();
		public bool verify;
        int cargo;

		public bool acess(string cpf, string senha)
		{
			verify = dao.Login_funcionario(cpf, senha);

			if(verify == true)
			{
                dao.verifcarCargo(cpf);
                cargo = int.Parse(dao.getA());

                if (cargo == 1)
                {
                    frm_admLogado log = new frm_admLogado();
                    log.ShowDialog();

                }else if (cargo == 2)
                {
                    frm_garLogado log = new frm_garLogado();
                    log.ShowDialog();
                }
                else if (cargo == 3)
                {
                    /*frm_cozLogado log = new frm_cozLogado();
                    log.ShowDialog();*/
                }
            }
            else
            {
                
            }
			return verify;
		}

		public void add_funcionario(string cpf, string nome, string cargo, string senha)
		{
			if (cargo == "Adiministrador")
			{
				this.cargo = 1;
			}else if(cargo == "Garçom")
			{
				this.cargo = 2;
			}else if(cargo == "Cozinheiro")
			{
				this.cargo = 3;
			}

			dao.cad_funcionario(cpf, nome, this.cargo, senha);
		}
	}
}
