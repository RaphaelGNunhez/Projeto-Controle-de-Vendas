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
    public partial class Frmvendas : Form
    {
        #region Variaveis e Chamadas
        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();
        Produto p = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        int qtd;
        decimal preco;
        decimal subtotal, total;

        DataTable carrinho = new DataTable();
        #endregion

        public Frmvendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            tabelaProdutos.DataSource = carrinho;


        }

        private void Frmvendas_Load(object sender, EventArgs e)
        {
            //Pegando a data a atual
            txtData.Text = DateTime.Now.ToShortDateString();
        }
        //Botão adicionar item
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtQtd.Text);
                preco = decimal.Parse(txtPreco.Text);

                subtotal = qtd * preco;

                total += subtotal;

                carrinho.Rows.Add(int.Parse(txtCodigo.Text), txtDesc.Text, qtd, preco, subtotal);

                txtTotal.Text = total.ToString();

                txtCodigo.Clear();
                txtDesc.Clear();
                txtQtd.Clear();
                txtPreco.Clear();

                txtCodigo.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite o código do produto!");
            }
        }
        //Botão remover item
        private void btnRemover_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tabelaProdutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;

            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho com sucesso!");
        }
        // Apertar enter para aparecer cliente
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) {
                cliente = cdao.retornaClientePorCpf(txtCpf.Text);
                if(cliente != null)
                {
                    txtNome.Text = cliente.nome;
                } else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
                
            }
        }
        //Botão pagamentos
        private void btnPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Parse(txtData.Text);
            Frmpagamentos tela = new Frmpagamentos(cliente, carrinho, dataAtual);

            tela.txtTotal.Text = total.ToString();
            tela.ShowDialog();
        }

        // Apertar enter para aparecer produto
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                p = pdao.retornaProdutoPorCodigo(int.Parse(txtCodigo.Text));

                if(p != null)
                {
                    txtDesc.Text = p.desc;
                    txtPreco.Text = p.preco.ToString();
                } else
                {
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                }
                

            }
        }
    }
}
