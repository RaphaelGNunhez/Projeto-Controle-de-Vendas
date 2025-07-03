using Projeto_Controle_de_Vendas.br.com.projeto.dao;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    public partial class Frmpagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();
        DateTime dataAtual;

        public Frmpagamentos(Cliente cliente, DataTable carrinho, DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frmpagamentos_Load(object sender, EventArgs e)
        {
            txtTroco.Text  = "0,00";
            txtDinheiro.Text = "0,00";
            txtCartao.Text = "0,00";
        }
        //Botão finalizar venda
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal vDinheiro, vCartao, troco, totalpago, total;
                int qtd_estoque, qtd_comprada, qtd_atualizada;

                ProdutoDAO daoProduto = new ProdutoDAO();

                vDinheiro = decimal.Parse(txtDinheiro.Text);
                vCartao = decimal.Parse(txtCartao.Text);
                total = decimal.Parse(txtTotal.Text);

                totalpago = vDinheiro + vCartao;

                if(totalpago >= total)
                {
                    troco = totalpago - total;
                    Vendas venda = new Vendas();
                    venda.clienteId = cliente.cod;
                    venda.dataVenda = dataAtual;
                    venda.totalVendas = total;
                    venda.obs = txtObs.Text;

                    VendasDAO vdao = new VendasDAO();
                    txtTroco.Text = troco.ToString();
                    vdao.cadastrarVenda(venda);

                    foreach(DataRow linha in carrinho.Rows)
                    {
                        ItemVenda item = new ItemVenda();
                        item.vendaId = vdao.retornarIdUltimaVenda();
                        item.produtoId = int.Parse(linha["Código"].ToString());
                        item.qtd = int.Parse(linha["Qtd"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        //Baixa no estoque
                        qtd_estoque = daoProduto.retornaEstoqueAtual(item.produtoId);
                        qtd_comprada = item.qtd;
                        qtd_atualizada = qtd_estoque - qtd_comprada;
                        daoProduto.baixaEstoque(item.produtoId, qtd_estoque);

                        ItemVendaDAO itemdao = new ItemVendaDAO();
                        itemdao.cadastrarItem(item);
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");

                    this.Dispose();

                    new Frmvendas().ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("O total pago é menor que o valor total da venda!");
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro: " + erro);
            }
        }
    }
}
