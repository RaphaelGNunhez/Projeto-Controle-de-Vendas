using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_de_Vendas.br.com.projeto.model
{
    public class Vendas
    {
        public int id { get; set; }
        public int clienteId { get; set; }
        public DateTime dataVenda { get; set; }
        public decimal totalVendas { get; set; }
        public string obs { get; set; }
    }
}
