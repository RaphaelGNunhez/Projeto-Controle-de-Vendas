using Projeto_Controle_de_Vendas.br.com.projeto.dao;
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
    public partial class Frmdetalhes : Form
    {
        int venda_id;
        public Frmdetalhes(int idvenda)
        {
            venda_id = idvenda;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dtFim_ValueChanged(object sender, EventArgs e)
        {
                    }

        private void gpConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmdetalhes_Load(object sender, EventArgs e)
        {
            ItemVendaDAO dao = new ItemVendaDAO();
            tabelaDetalhes.DataSource = dao.listarItensPorVenda(venda_id);
        }
    }
}
