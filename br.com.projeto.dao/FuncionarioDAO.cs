using MySql.Data.MySqlClient;
using Projeto_Controle_de_Vendas.br.com.projeto.connection;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Controle_de_Vendas.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conn;
        public FuncionarioDAO()
        {
            this.conn = new ConnectionFactory().getConnection();
        }

        #region cadastrarFuncionario
        public void cadastarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"insert into tb_funcionarios(nome, rg, cpf, email, telefone, celular, endereco,
                                numero, complemento, bairro, cidade, estado, cep, cargo, nivel_acesso, senha) values (@nome, @rg, @cpf, @email, @telefone, @celular,
                                    @endereco, @numero, @complemento, @bairro, @cidade, @estado, @cep, @cargo, @nivel, @senha)";

                MySqlCommand cadastar = new MySqlCommand(sql, conn);
                cadastar.Parameters.AddWithValue("@nome", obj.nome);
                cadastar.Parameters.AddWithValue("@rg", obj.rg);
                cadastar.Parameters.AddWithValue("@cpf", obj.cpf);
                cadastar.Parameters.AddWithValue("@email", obj.email);
                cadastar.Parameters.AddWithValue("@telefone", obj.telefone);
                cadastar.Parameters.AddWithValue("@celular", obj.celular);
                cadastar.Parameters.AddWithValue("@endereco", obj.endereco);
                cadastar.Parameters.AddWithValue("@numero", obj.numero);
                cadastar.Parameters.AddWithValue("@complemento", obj.complemento);
                cadastar.Parameters.AddWithValue("@bairro", obj.bairro);
                cadastar.Parameters.AddWithValue("@cidade", obj.cidade);
                cadastar.Parameters.AddWithValue("@estado", obj.estado);
                cadastar.Parameters.AddWithValue("@cep", obj.cep);
                cadastar.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                cadastar.Parameters.AddWithValue("@cargo", obj.cargo);
                cadastar.Parameters.AddWithValue("@senha", obj.senha);

                conn.Open();
                cadastar.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastro com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }

        }
        #endregion

        #region excluirFuncionario
        public void excluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"delete from tb_funcionarios where id=@id";

                MySqlCommand excluir = new MySqlCommand(sql, conn);
                excluir.Parameters.AddWithValue("@id", obj.cod);

                conn.Open();
                excluir.ExecuteNonQuery();

                MessageBox.Show("Cliente removido com sucesso!");
                conn.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!" + erro);
            }
        }
        #endregion

        #region alterarFuncionario
        public void alterarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"UPDATE tb_funcionarios SET nome@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone,
                                celular=@celular , endereco=@endereco , numero=@numero, complemento=@complemento,
                                    bairro=@bairro, cidade=@cidade, estado=@estado, cep=@cep, senha=@senha, nivel_acesso=@nivel, cargo=@cargo WHERE id=@id";

                MySqlCommand alterar = new MySqlCommand(sql, conn);
                alterar.Parameters.AddWithValue("@nome", obj.nome);
                alterar.Parameters.AddWithValue("@rg", obj.rg);
                alterar.Parameters.AddWithValue("@cpf", obj.cpf);
                alterar.Parameters.AddWithValue("@email", obj.email);
                alterar.Parameters.AddWithValue("@telefone", obj.telefone);
                alterar.Parameters.AddWithValue("@celular", obj.celular);
                alterar.Parameters.AddWithValue("@endereco", obj.endereco);
                alterar.Parameters.AddWithValue("@numero", obj.numero);
                alterar.Parameters.AddWithValue("@complemento", obj.complemento);
                alterar.Parameters.AddWithValue("@bairro", obj.bairro);
                alterar.Parameters.AddWithValue("@cidade", obj.cidade);
                alterar.Parameters.AddWithValue("@estado", obj.estado);
                alterar.Parameters.AddWithValue("@cep", obj.cep);
                alterar.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                alterar.Parameters.AddWithValue("@cargo", obj.cargo);
                alterar.Parameters.AddWithValue("@senha", obj.senha);

                conn.Open();
                alterar.ExecuteNonQuery();

                MessageBox.Show("Mudanças feitas com sucesso!");
                conn.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu algum erro!" + erro);
            }
        }
        #endregion



    }
}
