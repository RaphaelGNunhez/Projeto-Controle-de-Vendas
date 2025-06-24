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
    public partial class Frmfornecedores : Form
    {
        public Frmfornecedores()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        //Pesquisar CEP
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCepFornecedor.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtEnderecoFornecedor.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtCompFornecedor.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                txtCidadeFornecedor.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbUfFornecedor.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                txtBairroFornecedor.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }
        //Botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }
        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.nome = txtNomeFornecedor.Text;
            obj.cnpj = txtCNPJ.Text;
            obj.email = txtEmailFornecedor.Text;
            obj.telefone = txtTelefoneFornecedor.Text;
            obj.cep = txtCepFornecedor.Text;
            obj.celular = txtCelularFornecedor.Text;
            obj.endereco = txtEnderecoFornecedor.Text;
            obj.numero = int.Parse(txtNumeroFornecedor.Text);
            obj.complemento = txtCompFornecedor.Text;
            obj.bairro = txtBairroFornecedor.Text;
            obj.cidade = txtCidadeFornecedor.Text;
            obj.estado = cbUfFornecedor.SelectedItem.ToString();

            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastarFornecedor(obj);
            tabelaFornecedor.DataSource = dao.ListarFornecedor();
        }
        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.cod = int.Parse(txtCodigoFornecedor.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.excluirFornecedor(obj);
            tabelaFornecedor.DataSource = dao.ListarFornecedor();
            new Helpers().limparTela(this);
        }
        //Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.nome = txtNomeFornecedor.Text;
            obj.cnpj = txtCNPJ.Text;
            obj.cep = txtCepFornecedor.Text;
            obj.telefone = txtTelefoneFornecedor.Text;
            obj.email = txtEmailFornecedor.Text;
            obj.celular = txtCelularFornecedor.Text;
            obj.endereco = txtEnderecoFornecedor.Text;
            obj.bairro = txtBairroFornecedor.Text;
            obj.cidade = txtCidadeFornecedor.Text;
            obj.estado = cbUfFornecedor.Text;
            obj.complemento = txtCompFornecedor.Text;
            obj.numero = int.Parse(txtNumeroFornecedor.Text);
            obj.cod = int.Parse(txtCodigoFornecedor.Text);

            FornecedorDAO dao = new FornecedorDAO();
            dao.alterarFornecedor(obj);
            tabelaFornecedor.DataSource = dao.ListarFornecedor();
        }
        //Botão Pesquisar
        private void button2_Click(object sender, EventArgs e)
        {
            String nome = txtPesquisarFornecedor.Text;

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedor.DataSource = dao.buscarFornecedorPorNome(nome);

            if (tabelaFornecedor.Rows.Count == 0)
            {
                tabelaFornecedor.DataSource = dao.ListarFornecedor();
            }
        }
        //Pesquisar Fornecedor por aproximação
        private void txtPesquisarFornecedor_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisarFornecedor.Text + "%";

            FornecedorDAO dao = new FornecedorDAO();

            tabelaFornecedor.DataSource = dao.listarFornecedorPorNome(nome);
        }
        //Mostrar Fornecedor Tela 1
        private void tabelaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNomeFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEmailFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtTelefoneFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCelularFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtCepFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEnderecoFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumeroFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtCompFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairroFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidadeFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbUfFornecedor.Text = tabelaFornecedor.CurrentRow.Cells[12].Value.ToString();

            tabFornecedor.SelectedTab = tabPage3;
        }
        //Listar Fornecedor ao carregar página
        private void Frmfornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            tabelaFornecedor.DataSource = dao.ListarFornecedor();
        }
    }
}
