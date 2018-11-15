using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DAO
    {
        public MySqlConnection mConn;

        public MySqlDataAdapter mAdapter;

        public DataSet mDataSet;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        public string sql;
        public int codCar;
        public bool verify = false;

        public DAO()
        {
            mConn = new MySqlConnection("server=localhost; database=restaurante; uid=root; password=vertrigo; SslMode=none");
            try
            {
                //abre a conexao
                mConn.Open();
            }

            catch (System.Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }//fim DAO


        public void cad_cliente(string cpf, string nome, string mesa)
        //cadastra o cliente
        {
            if (mConn.State == ConnectionState.Open)
            { }
            else
            {
                mConn.Open();
            }
            try
            {
                String sql = "insert into cliente(cpf_cliente, nome_cliente, mesa_cliente) values (@cpf,@nome,@mesa)";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@mesa", mesa);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
        }

        public void cad_funcionario(string cpf, string nome, int cargo, string senha)
        // cadastra o funcionário
        {
            if (mConn.State == ConnectionState.Open)
            { }
            else
            {
                mConn.Open();
            }
            try
            {
                String sql = "insert into funcionario(cod_func, cpf_func, nome_func, cod_cargo, senha_func) values (null, @cpf,@nome,@cargo, @senha)";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cargo", cargo);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
        }

        public bool Login_funcionario(string cpf, string senha)
        // checa o login dos funcionários
        {

            if (mConn.State == ConnectionState.Open)
            { }
            else
            {
                mConn.Open();
            }
            try
            {
                String sql = "Select * from funcionario where cpf_func = @cpf and senha_func = @senha";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();

                cmd.BeginExecuteReader();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    verify = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
            return verify;
        }

        public void Add_Prato(string nome, int valor, int tipo, string descricao)
        {
            if (mConn.State == ConnectionState.Open)
            { }
            else
            {
                mConn.Open();
            }
            try
            {
                String sql = "insert into pratos(nome_pr, valor_pr, cod_tp, desc_pr) values (@nome,@valor,@tipo, @descricao)";

                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }
        }

        public DataTable listar_pratos()
        {
            try
            {
                String sql = "SELECT * FROM pratos";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                mAdapter = new MySqlDataAdapter();
                mAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void remover_prato(int id)
        {
            if (mConn.State == ConnectionState.Open)
            { }
            else
            {
                mConn.Open();
            }
            try
            {
                var result = MessageBox.Show("Deseja remover este prato", "Remover Prato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    String sql = "delete from pratos WHERE cod_pr = @id ";
                    MySqlCommand cmd = new MySqlCommand(sql, mConn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prato removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Prato não removido", "Remoção cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //mConn.Close();
            }

        }


        public DataTable listar_func()
        {
            try
            {
                String sql = "SELECT * FROM funcionario";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                mAdapter = new MySqlDataAdapter();
                mAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                mAdapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void remover_func(int id)
        {
            if (mConn.State == ConnectionState.Open)
            { }
            else
            {
                mConn.Open();
            }
            try
            {
                var result = MessageBox.Show("Deseja remover este funcionário?", "Remover Funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    String sql = "delete from pratos WHERE cod_func = @id ";
                    MySqlCommand cmd = new MySqlCommand(sql, mConn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário removido.");
                }
                else
                {
                    MessageBox.Show("Funcionário não removido", "Remoção cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //mConn.Close();
            }
        }

        public String a;

        public String getA()
        {
            return a;

        }
        public int verifcarCargo(string cpf)
        {

            if (mConn.State == ConnectionState.Open)
            { }
            else
            {
                mConn.Open();
            }
            try
            {
                String sql = "select cod_cargo from funcionario where cpf_func = @cpf;";
                MySqlCommand cmd = new MySqlCommand(sql, mConn);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    a = dr['cod_cargo'].ToString();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                mConn.Close();
            }
            return codCar;
        }

    }
}