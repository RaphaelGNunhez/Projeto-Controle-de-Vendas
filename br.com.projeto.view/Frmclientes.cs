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
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            tabelaCliente.DataSource = dao.ListarClientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
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

            ClienteDAO dao = new ClienteDAO();
            dao.cadastarCliente(obj);
            tabelaCliente.DataSource = dao.ListarClientes();
            new Helpers().limparTela(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.cod = int.Parse(txtCodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);
            tabelaCliente.DataSource = dao.ListarClientes();
            new Helpers().limparTela(this);
        }

        private void tabelaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtTelefone.Text = tabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtCelular.Text = tabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtCep.Text = tabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = tabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = tabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtComp.Text = tabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = tabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtCidade.Text = tabelaCliente.CurrentRow.Cells[12].Value.ToString();
            cbUf.Text = tabelaCliente.CurrentRow.Cells[13].Value.ToString();


            tabClientes.SelectedTab = tabPage1;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
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

            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);
            tabelaCliente.DataSource = dao.ListarClientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String nome = txtPesquisa.Text;

            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.buscarClientePorNome(nome);

            if(tabelaCliente.Rows.Count == 0)
            {
                tabelaCliente.DataSource = dao.ListarClientes();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            String nome = "%" + txtPesquisa.Text + "%";
            
            ClienteDAO dao = new ClienteDAO();

            tabelaCliente.DataSource = dao.listarClientePorNome(nome);

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

    }
}
