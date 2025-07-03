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
    public class FornecedorDAO
    {
        private MySqlConnection conn;
        public FornecedorDAO()
        {
            this.conn = new ConnectionFactory().getConnection();
        }
        #region cadastrarFornecedor
        public void cadastarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"insert into tb_fornecedores(nome, cnpj, email, telefone, celular, endereco,
                                numero, complemento, bairro, cidade, estado, cep) values (@nome, @cnpj, @email, @telefone, @celular,
                                    @endereco, @numero, @complemento, @bairro, @cidade, @estado, @cep)";

                MySqlCommand cadastar = new MySqlCommand(sql, conn);
                cadastar.Parameters.AddWithValue("@nome", obj.nome);
                cadastar.Parameters.AddWithValue("@cnpj", obj.cnpj);
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

        #region excluirFornecedor
        public void excluirFornecedor(Cliente obj)
        {
            try
            {
                string sql = @"delete from tb_fornecedores where id=@id";

                MySqlCommand excluir = new MySqlCommand(sql, conn);
                excluir.Parameters.AddWithValue("@id", obj.cod);

                conn.Open();
                excluir.ExecuteNonQuery();

                MessageBox.Show("Fornecedor removido com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }
        }
        #endregion

        #region alterarFornecedor
        public void alterarFornecedor(Fornecedor obj)
        {
            try
            {
                string sql = @"UPDATE tb_fornecedores SET nome=@nome , cnpj=@cnpj, email=@email, telefone=@telefone,
                                celular=@celular , endereco=@endereco , numero=@numero, complemento=@complemento,
                                    bairro=@bairro, cidade=@cidade, estado=@estado, cep=@cep WHERE id=@id";

                MySqlCommand cadastar = new MySqlCommand(sql, conn);
                cadastar.Parameters.AddWithValue("@nome", obj.nome);
                cadastar.Parameters.AddWithValue("@cnpj", obj.cnpj);
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

                MessageBox.Show("Fornecedor alterado com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }
        }
        #endregion

        #region listarFornecedor
        public DataTable ListarFornecedor()
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = "select *from tb_fornecedores";

                MySqlCommand listar = new MySqlCommand(sql, conn);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelaFornecedor);

                conn.Close();
                return tabelaFornecedor;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region buscarFornecedorPorNome
        public DataTable buscarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelaFornecedor = new DataTable();
                string sql = "select *from tb_fornecedores where nome=@nome ";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@nome", nome);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelaFornecedor);

                conn.Close();
                return tabelaFornecedor;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region listarFornecedorPorNome
        public DataTable listarFornecedorPorNome(string nome)
        {
            try
            {
                DataTable tabelafornecedor = new DataTable();
                string sql = "select *from tb_fornecedores where nome like @nome ";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@nome", nome);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelafornecedor);

                conn.Close();
                return tabelafornecedor;

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
