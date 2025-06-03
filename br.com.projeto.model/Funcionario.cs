using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_de_Vendas.br.com.projeto.model
{
    public class Funcionario : Cliente
    {
        public String senha{ get; set; }
        public String cargo{ get; set; }
        public String nivel_acesso { get; set; }
    }
}
