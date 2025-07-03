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
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRg_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {

        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbUf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Ao carregar tela
        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO f_dao = new FornecedorDAO();
            cbFornecedor.DataSource = f_dao.ListarFornecedor();
            cbFornecedor.DisplayMember = "nome";
            cbFornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();
            tabelaProdutos.DataSource = dao.listarProdutos();
        }
        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.desc = txtDesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtQtd.Text);
            obj.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());

            ProdutoDAO dao = new ProdutoDAO();
            dao.cadastrarProduto(obj);
            tabelaProdutos.DataSource = dao.listarProdutos();
            new Helpers().limparTela(this);

        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }
        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.id = int.Parse(txtCodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.excluirProduto(obj);
            tabelaProdutos.DataSource = dao.listarProdutos();
            new Helpers().limparTela(this);
        }
        //Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();
            obj.desc = txtDesc.Text;
            obj.preco = decimal.Parse(txtPreco.Text);
            obj.qtdEstoque = int.Parse(txtQtd.Text);
            obj.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.id = int.Parse(txtCodigo.Text);

            ProdutoDAO dao = new ProdutoDAO();
            dao.alterarProduto(obj);
            tabelaProdutos.DataSource = dao.listarProdutos();
            new Helpers().limparTela(this);

        }
        //Clicar produto muda a página
        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtQtd.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = tabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabPage1;
        }
        //Botão Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String desc = txtPesquisa.Text;

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.buscarProdutoPorDesc(desc);

            if (tabelaProdutos.Rows.Count == 0)
            {
                tabelaProdutos.DataSource = dao.listarProdutos();
            }
        }
        //Caixa de Texto Pesquisar
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            String desc = "%" + txtPesquisa.Text + "%";

            ProdutoDAO dao = new ProdutoDAO();

            tabelaProdutos.DataSource = dao.listarProdutoPorDesc(desc);
        }
    }
}
