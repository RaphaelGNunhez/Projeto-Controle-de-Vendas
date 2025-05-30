using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_de_Vendas.br.com.projeto.connection
{
    public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdVendas"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
