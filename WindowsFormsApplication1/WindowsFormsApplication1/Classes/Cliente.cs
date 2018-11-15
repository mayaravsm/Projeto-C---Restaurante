using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Cliente : Pessoa
    {
        public string mesa = "1";
        DAO cli = new DAO();
        

        public void cadcliente(string nome, string cpf)
        {
          cli.cad_cliente(cpf, nome, mesa);
        }

        public void excluir_pedido()
        {

        }

    }
}