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
    public class ProdutoDAO
    {
        private MySqlConnection conn;
        public ProdutoDAO()
        {
            this.conn = new ConnectionFactory().getConnection();
        }

        #region CadastrarProduto
        public void cadastrarProduto(Produto obj)
        {
            try
            {
                String sql = @"INSERT INTO tb_produtos (descricao,preco,qtd_estoque,for_id)
                                values (@descricao, @preco, @qtd, @for_id)";

                MySqlCommand adicionar = new MySqlCommand(sql, conn);
                adicionar.Parameters.AddWithValue("@descricao", obj.desc);
                adicionar.Parameters.AddWithValue("@preco", obj.preco);
                adicionar.Parameters.AddWithValue("@qtd", obj.qtdEstoque);
                adicionar.Parameters.AddWithValue("@for_id", obj.for_id);

                conn.Open();
                adicionar.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conn.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region excluirProduto
        public void excluirProduto(Produto obj)
        {
            try
            {
                string sql = @"delete from tb_produtos where id=@id";

                MySqlCommand excluir = new MySqlCommand(sql, conn);
                excluir.Parameters.AddWithValue("@id", obj.id);

                conn.Open();
                excluir.ExecuteNonQuery();

                MessageBox.Show("Produto removido com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }
        }
        #endregion

        #region alterarProduto
        public void alterarProduto(Produto obj)
        {
            try
            {
                string sql = @"UPDATE tb_produtos SET descricao=@descricao, preco=@preco, qtd_estoque=@qtd,
                                for_id=@for_id WHERE id=@id";

                MySqlCommand alterar = new MySqlCommand(sql, conn);
                alterar.Parameters.AddWithValue("@descricao", obj.desc);
                alterar.Parameters.AddWithValue("@preco", obj.preco);
                alterar.Parameters.AddWithValue("@qtd", obj.qtdEstoque);
                alterar.Parameters.AddWithValue("@for_id", obj.for_id);
                alterar.Parameters.AddWithValue("@id", obj.id);

                conn.Open();
                alterar.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }
        }
        #endregion

        #region listarProdutos
        public DataTable listarProdutos()
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                String sql = @"select p.id as 'Código',
		                        p.descricao as 'Descrição',
		                        p.preco as 'Preço',
		                        p.qtd_estoque as 'Quantidade Estoque',
                                f.nome as 'Fornecedor' from tb_produtos as p
                                join tb_fornecedores as f on (p.for_id = f.id);";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelaproduto);
                conn.Close();

                return tabelaproduto;
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Houve um erro ao atualizar os dados!" + erro);
                return null;
            }
        }
        #endregion

        #region buscarProdutoPorDesc
        public DataTable buscarProdutoPorDesc(string desc)
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = "select *from tb_produtos where descricao=@desc ";

                MySqlCommand buscar = new MySqlCommand(sql, conn);
                buscar.Parameters.AddWithValue("@desc", desc);

                conn.Open();
                buscar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(buscar);
                da.Fill(tabelaproduto);

                conn.Close();
                return tabelaproduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region listarProdutoPorDesc
        public DataTable listarProdutoPorDesc(string desc)
        {
            try
            {
                DataTable tabelaproduto = new DataTable();
                string sql = "select *from tb_produtos where descricao like @desc ";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@desc", desc);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelaproduto);

                conn.Close();
                return tabelaproduto;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region retornaProdutoPorCodigo
        public Produto retornaProdutoPorCodigo(int id)
        {
            try
            {
                string sql = @"select * from tb_produtos where id = @id";

                MySqlCommand retornar = new MySqlCommand(sql, conn);
                retornar.Parameters.AddWithValue("@id", id);

                conn.Open();

                MySqlDataReader rs = retornar.ExecuteReader();
                if (rs.Read())
                {
                    Produto p = new Produto();
                    p.id = rs.GetInt32("id");
                    p.desc = rs.GetString("descricao");
                    p.preco = rs.GetDecimal("preco");
                    conn.Close();
                    return p;
                } else {
                    conn.Close();
                    return null;
                    MessageBox.Show("Nenhum produto encontrado com esse código!");
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!");
                conn.Close();
                return null;
            }
        }
        #endregion

        #region baixaEstoque
        public void baixaEstoque(int idProduto, int qtdEstoque)
        {
            try
            {
                string sql = @"update tb_produtos set qtd_estoque= @qtd where id = @id";

                MySqlCommand baixa = new MySqlCommand(sql, conn);

                baixa.Parameters.AddWithValue("@qtd", qtdEstoque);
                baixa.Parameters.AddWithValue("@id", idProduto);

                conn.Open();

                baixa.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
                conn.Close();
            }
        }
        #endregion

        #region retornaEstoqueAtual
        public int retornaEstoqueAtual(int idProduto)
        {
            try
            {
                string sql = @"select qtd_estoque from tb_produtos where id= @id";
                int qtd_estoque = 0;

                MySqlCommand retorna = new MySqlCommand(sql, conn);
                retorna.Parameters.AddWithValue("@id", idProduto);

                conn.Open();

                MySqlDataReader rs = retorna.ExecuteReader();
                if (rs.Read())
                {
                    qtd_estoque = rs.GetInt32("qtd_estoque");
                    conn.Close();
                }

                return qtd_estoque;
                
                
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro: " + erro);
                conn.Close();
                return 0;
            }
        }
        #endregion
    }
}

