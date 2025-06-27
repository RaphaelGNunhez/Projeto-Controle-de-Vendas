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
    public class VendasDAO
    {
        private MySqlConnection conn;
        public VendasDAO()
        {
            this.conn = new ConnectionFactory().getConnection();
        }

        #region cadastrarVenda
        public void cadastrarVenda(Vendas obj)
        {
            try
            {
                string sql = @"insert into tb_vendas (cliente_id, data_venda, total_venda, observacoes) 
                                values ( @cliente_id, @data_venda, @total_venda, @obs)";

                MySqlCommand cadastrar = new MySqlCommand(sql, conn);
                cadastrar.Parameters.AddWithValue("@cliente_id", obj.clienteId);
                cadastrar.Parameters.AddWithValue("@data_venda", obj.dataVenda);
                cadastrar.Parameters.AddWithValue("@total_venda", obj.totalVendas);
                cadastrar.Parameters.AddWithValue("@obs", obj.obs);

                conn.Open();
                cadastrar.ExecuteNonQuery();
                conn.Close();
                //MessageBox.Show("Venda Cadastrada com sucesso!");
                
            }
            catch (Exception erro)
            {
                conn.Close();
                MessageBox.Show("Aconteceu um erro: " + erro);
                
            }
        }
        #endregion

        #region retornarIdUltimaVenda
        public int retornarIdUltimaVenda()
        {
            try
            {
                int idvenda = 0;
                string sql = @"select max(id) id from tb_vendas";

                MySqlCommand retornar = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader rs = retornar.ExecuteReader();

                if (rs.Read())
                {
                    idvenda = rs.GetInt32("id");
                }

                conn.Close();
                return idvenda;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro); ;
                conn.Close();
                return 0;
            }
        }
        #endregion

        #region listarVendasPorPeriodo
        public DataTable listarVendasPorPeriodo(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"select  v.id as 'Código', v.data_venda as 'Data da venda',
                                c.nome as 'Cliente', v.total_venda as 'Total', v.observacoes as 'Obs' from tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)
                                        where v.data_venda between @datainicio and @datafim";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@datainicio", dataInicio);
                listar.Parameters.AddWithValue("@datafim", dataFim);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelaHistorico);

                return tabelaHistorico;

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

        #region listarVendas
        public DataTable listarVendas()
        {
            try
            {
                DataTable tabelaHistorico = new DataTable();
                string sql = @"select  v.id as 'Código',
                                v.data_venda as 'Data da venda',
                                c.nome as 'Cliente',
                                v.total_venda as 'Total',
                                v.observacoes as 'Obs'
                                from tb_vendas as v join tb_clientes as c on (v.cliente_id = c.id)";

                MySqlCommand listar = new MySqlCommand(sql, conn);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelaHistorico);

                conn.Close();
                return tabelaHistorico;
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
                conn.Close();
                return null;
            }
        }
        #endregion
    }
}
