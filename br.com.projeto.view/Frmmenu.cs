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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmvendas tela = new Frmvendas();
            tela.ShowDialog();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frmmenu_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuCadastroCliente_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            tela.ShowDialog();

        }

        private void menuConsultaCliente_Click(object sender, EventArgs e)
        {
            Frmclientes tela = new Frmclientes();
            tela.tabClientes.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroFuncionario_Click(object sender, EventArgs e)
        {
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.ShowDialog();
        }

        private void menuConsultaFuncionario_Click(object sender, EventArgs e)
        {
            Frmfuncionarios tela = new Frmfuncionarios();
            tela.tabFuncionario.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuCadastroFornecedor_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.ShowDialog();
        }

        private void menuConsultaFornecedor_Click(object sender, EventArgs e)
        {
            Frmfornecedores tela = new Frmfornecedores();
            tela.tabFornecedor.SelectedTab = tela.tabPage4;
            tela.ShowDialog();
        }

        private void menuCadastroProduto_Click(object sender, EventArgs e)
        {
            Frmprodutos tela = new Frmprodutos();
            tela.ShowDialog();
        }

        private void menuConsultaProduto_Click(object sender, EventArgs e)
        {
            Frmprodutos tela = new Frmprodutos();
            tela.tabProdutos.SelectedTab = tela.tabPage2;
            tela.ShowDialog();
        }

        private void menuHistoricoVenda_Click(object sender, EventArgs e)
        {
            Frmhistorico tela = new Frmhistorico();
            tela.ShowDialog();
        }

        private void menuTrocar_Click(object sender, EventArgs e)
        {
            Frmlogin tela = new Frmlogin();
            tela.Show();
            this.Dispose();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja Sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if( result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
