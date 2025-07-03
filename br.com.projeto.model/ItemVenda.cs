using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_de_Vendas.br.com.projeto.model
{
    public class ItemVenda
    {
        public int id{ get; set; }
        public int vendaId { get; set; }
        public int produtoId { get; set; }
        public int qtd { get; set; }
        public decimal subtotal { get; set; }
    }
}
