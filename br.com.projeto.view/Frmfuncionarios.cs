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
    public partial class Frmfuncionarios : Form
    {
        public Frmfuncionarios()
        {
            InitializeComponent();
        }

        private void Frmfuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            tabelaFornecedor.DataSource = dao.ListarFuncionarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Botão Novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.cargo = cbCargo.SelectedItem.ToString();
            obj.nivel_acesso = cbNivel.SelectedItem.ToString();
            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.telefone = txtTelefone.Text;
            obj.cep = txtCep.Text;
            obj.celular = txtCelular.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComp.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUf.SelectedItem.ToString();

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastarFuncionario(obj);
            tabelaFornecedor.DataSource = dao.ListarFuncionarios();
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtComp.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                cbUf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }

        private void tabelaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        //Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.cod = int.Parse(txtCodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.excluirFuncionario(obj);
            tabelaFornecedor.DataSource = dao.ListarFuncionarios();
            new Helpers().limparTela(this);
        }
        //Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.cep = txtCep.Text;
            obj.telefone = txtTelefone.Text;
            obj.email = txtEmail.Text;
            obj.celular = txtCelular.Text;
            obj.endereco = txtEndereco.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbUf.Text;
            obj.complemento = txtComp.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.cod = int.Parse(txtCodigo.Text);
            obj.cargo = cbCargo.Text;
            obj.nivel_acesso = cbNivel.Text;
            obj.senha = txtSenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);
            tabelaFornecedor.DataSource = dao.ListarFuncionarios();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String nome = txtPesquisa.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFornecedor.DataSource = dao.buscarFuncionarioPorNome(nome);

            if (tabelaFornecedor.Rows.Count == 0)
            {
                MessageBox.Show("Funcionario não encontrado!");
                tabelaFornecedor.DataSource = dao.ListarFuncionarios();
                txtPesquisa.Clear();
            }
        }

        private void tabelaFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            cbCargo.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            cbNivel.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = tabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFornecedor.CurrentRow.Cells[12].Value.ToString();
            txtComp.Text = tabelaFornecedor.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFornecedor.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFornecedor.CurrentRow.Cells[15].Value.ToString();
            cbUf.Text = tabelaFornecedor.CurrentRow.Cells[16].Value.ToString();
            tabFuncionario.SelectedTab = tabPage1;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtPesquisa.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();

            tabelaFornecedor.DataSource = dao.listarFuncionariosPorNome(nome);
        }
    }
}
