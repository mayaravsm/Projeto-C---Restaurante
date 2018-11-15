using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
	class Pratocs
	{
		public string nome;
		public double valor;
		public int tipo;
		public string descricao;

		public void Add_Prato(string nome, int valor, string tipo, string descricao)
		{
            DAO dao = new DAO();

            if (tipo == "Comida")
            {
                this.tipo = 1;
            }else if (tipo == "Bebida")
            {
                this.tipo = 2;
            }else if(tipo == "Sobremesa")
            {
                this.tipo = 3;
            }
       
			dao.Add_Prato(nome, valor, this.tipo, descricao);
		}

        public void rem_Prato()
		{

		}
	}
}
