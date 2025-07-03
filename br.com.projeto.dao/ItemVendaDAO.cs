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
    public class ItemVendaDAO
    {
        private MySqlConnection conn;
        public ItemVendaDAO()
        {
            this.conn = new ConnectionFactory().getConnection();
        }

        #region cadastrarItem
        public void cadastrarItem(ItemVenda obj)
        {
            try
            {
                string sql = @"insert into tb_itensvendas ( venda_id, produto_id, qtd, subtotal)
                                        values (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand cadastrar = new MySqlCommand(sql, conn);
                cadastrar.Parameters.AddWithValue("@venda_id", obj.vendaId);
                cadastrar.Parameters.AddWithValue("@produto_id", obj.produtoId);
                cadastrar.Parameters.AddWithValue("@qtd", obj.qtd);
                cadastrar.Parameters.AddWithValue("@subtotal", obj.subtotal);

                conn.Open();
                cadastrar.ExecuteNonQuery();

                //MessageBox.Show("Item cadastrado com sucesso!");

                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
                conn.Close();
            }
        }
        #endregion

        #region listarItensPorVenda
        public DataTable listarItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabelaItens = new DataTable();
                string sql = @"select i.id as 'Código',
                                p.descricao as 'Descricao',
                                i.qtd as 'Quantidade',
                                p.preco as 'Preço',
                                i.subtotal as 'SubTotal'
                                from tb_itensvendas as i join tb_produtos as p on (i.produto_id = p.id)
                                where venda_id = @vendaid;";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@vendaid", venda_id);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelaItens);

                return tabelaItens;

                conn.Close();


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
                return null;
                conn.Close();
            }
        }
        #endregion
    }
}
