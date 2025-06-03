using MySql.Data.MySqlClient;
using Projeto_Controle_de_Vendas.br.com.projeto.connection;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.dao
{
    public class ClienteDAO
    {
        private MySqlConnection conn;
        public ClienteDAO()
        {
            this.conn = new ConnectionFactory().getConnection();
        }

        #region cadastrarCliente
        public void cadastarCliente(Cliente obj)
        {
            try
            {
                string sql = @"insert into tb_clientes(nome, rg, cpf, email, telefone, celular, endereco,
                                numero, complemento, bairro, cidade, estado, cep) values (@nome, @rg, @cpf, @email, @telefone, @celular,
                                    @endereco, @numero, @complemento, @bairro, @cidade, @estado, @cep)";

                MySqlCommand cadastar = new MySqlCommand(sql, conn);
                cadastar.Parameters.AddWithValue("@nome", obj.nome);
                cadastar.Parameters.AddWithValue("@rg", obj.rg);
                cadastar.Parameters.AddWithValue("@cpf", obj.cpf);
                cadastar.Parameters.AddWithValue("@email", obj.email);
                cadastar.Parameters.AddWithValue("@telefone", obj.telefone);
                cadastar.Parameters.AddWithValue("@celular", obj.celular);
                cadastar.Parameters.AddWithValue("@endereco", obj.endereco);
                cadastar.Parameters.AddWithValue("@numero", obj.numero);
                cadastar.Parameters.AddWithValue("@complemento", obj.complemento);
                cadastar.Parameters.AddWithValue("@bairro", obj.bairro);
                cadastar.Parameters.AddWithValue("@cidade", obj.cidade);
                cadastar.Parameters.AddWithValue("@estado", obj.estado);
                cadastar.Parameters.AddWithValue("@cep", obj.cep);

                conn.Open();
                cadastar.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastro com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }

        }
        #endregion

        #region excluirCliente
        public void excluirCliente(Cliente obj)
        {
            try
            {
                string sql = @"delete from tb_clientes where id=@id";

                MySqlCommand excluir = new MySqlCommand(sql, conn);
                excluir.Parameters.AddWithValue("@id", obj.cod);

                conn.Open();
                excluir.ExecuteNonQuery();

                MessageBox.Show("Cliente removido com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }
        }
        #endregion

        #region alterarCliente
        public void alterarCliente(Cliente obj)
        {
            try
            {
                string sql = @"UPDATE tb_clientes SET nome=@nome , rg=@rg, cpf=@cpf, email=@email, telefone=@telefone,
                                celular=@celular , endereco=@endereco , numero=@numero, complemento=@complemento,
                                    bairro=@bairro, cidade=@cidade, estado=@estado, cep=@cep WHERE id=@id"; 

                MySqlCommand cadastar = new MySqlCommand(sql, conn);
                cadastar.Parameters.AddWithValue("@nome", obj.nome);
                cadastar.Parameters.AddWithValue("@rg", obj.rg);
                cadastar.Parameters.AddWithValue("@cpf", obj.cpf);
                cadastar.Parameters.AddWithValue("@email", obj.email);
                cadastar.Parameters.AddWithValue("@telefone", obj.telefone);
                cadastar.Parameters.AddWithValue("@celular", obj.celular);
                cadastar.Parameters.AddWithValue("@endereco", obj.endereco);
                cadastar.Parameters.AddWithValue("@numero", obj.numero);
                cadastar.Parameters.AddWithValue("@complemento", obj.complemento);
                cadastar.Parameters.AddWithValue("@bairro", obj.bairro);
                cadastar.Parameters.AddWithValue("@cidade", obj.cidade);
                cadastar.Parameters.AddWithValue("@estado", obj.estado);
                cadastar.Parameters.AddWithValue("@cep", obj.cep);
                cadastar.Parameters.AddWithValue("@id", obj.cod);

                conn.Open();
                cadastar.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }
        }
        #endregion

        #region listarCliente
        public DataTable ListarClientes()
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select *from tb_clientes";

                MySqlCommand listar = new MySqlCommand(sql, conn);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelacliente);

                conn.Close();
                return tabelacliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region buscarClientePorNome
        public DataTable buscarClientePorNome(string nome)
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select *from tb_clientes where nome=@nome ";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@nome", nome);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelacliente);

                conn.Close();
                return tabelacliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region listarClientesPorNome
        public DataTable listarClientePorNome(string nome)
        {
            try
            {
                DataTable tabelacliente = new DataTable();
                string sql = "select *from tb_clientes where nome like @nome ";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@nome", nome);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelacliente);

                conn.Close();
                return tabelacliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion
    }
}
