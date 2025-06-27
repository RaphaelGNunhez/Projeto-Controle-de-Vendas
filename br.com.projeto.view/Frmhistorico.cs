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
    public partial class Frmhistorico : Form
    {
        public Frmhistorico()
        {
            InitializeComponent();
        }

        private void Frmhistorico_Load(object sender, EventArgs e)
        {
            VendasDAO dao = new VendasDAO();

            tabelaHistorico.DataSource = dao.listarVendas();
            tabelaHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void gpConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DateTime dataInicio, dataFim;

            dataInicio = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            dataFim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd"));

            VendasDAO dao = new VendasDAO();

            tabelaHistorico.DataSource = dao.listarVendasPorPeriodo(dataInicio, dataFim);
        }

        private void tabelaHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idvenda = int.Parse(tabelaHistorico.CurrentRow.Cells[0].Value.ToString());
            Frmdetalhes tela = new Frmdetalhes(idvenda);

            DateTime dataVenda = Convert.ToDateTime(tabelaHistorico.CurrentRow.Cells[1].Value.ToString());
            tela.txtCliente.Text = tabelaHistorico.CurrentRow.Cells[2].Value.ToString();
            tela.txtTotal.Text = tabelaHistorico.CurrentRow.Cells[3].Value.ToString();
            tela.txtObs.Text = tabelaHistorico.CurrentRow.Cells[4].Value.ToString();
            tela.txtData.Text = dataVenda.ToString("dd/MM/yyyy");



            tela.ShowDialog();
        }
    }
}
