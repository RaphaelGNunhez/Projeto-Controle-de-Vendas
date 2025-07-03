using MySql.Data.MySqlClient;
using Projeto_Controle_de_Vendas.br.com.projeto.connection;
using Projeto_Controle_de_Vendas.br.com.projeto.model;
using Projeto_Controle_de_Vendas.br.com.projeto.view;
using System;
using System.Collections.Generic;
using System.Data;
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

                MessageBox.Show("Funcionario removido com sucesso!");
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
                string sql = @"UPDATE tb_funcionarios SET nome=@nome, rg=@rg, cpf=@cpf, email=@email ,senha=@senha, cargo=@cargo, nivel_acesso=@nivel, telefone=@telefone,
                                celular=@celular , endereco=@endereco , numero=@numero, complemento=@complemento,
                                    bairro=@bairro, cidade=@cidade, estado=@estado, cep=@cep WHERE id=@id";

                MySqlCommand alterar = new MySqlCommand(sql, conn);
                alterar.Parameters.AddWithValue("@nome", obj.nome);
                alterar.Parameters.AddWithValue("@rg", obj.rg);
                alterar.Parameters.AddWithValue("@cpf", obj.cpf);
                alterar.Parameters.AddWithValue("@email", obj.email);
                alterar.Parameters.AddWithValue("@senha", obj.senha);
                alterar.Parameters.AddWithValue("@cargo", obj.cargo);
                alterar.Parameters.AddWithValue("@nivel", obj.nivel_acesso);
                alterar.Parameters.AddWithValue("@telefone", obj.telefone);
                alterar.Parameters.AddWithValue("@celular", obj.celular);
                alterar.Parameters.AddWithValue("@endereco", obj.endereco);
                alterar.Parameters.AddWithValue("@numero", obj.numero);
                alterar.Parameters.AddWithValue("@complemento", obj.complemento);
                alterar.Parameters.AddWithValue("@bairro", obj.bairro);
                alterar.Parameters.AddWithValue("@cidade", obj.cidade);
                alterar.Parameters.AddWithValue("@estado", obj.estado);
                alterar.Parameters.AddWithValue("@cep", obj.cep);
                alterar.Parameters.AddWithValue("@id", obj.cod);

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

        #region listarFuncionarios
        public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "select *from tb_funcionarios";

                MySqlCommand listar = new MySqlCommand(sql, conn);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelafuncionario);

                conn.Close();
                return tabelafuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region buscarFuncionarioPorNome
        public DataTable buscarFuncionarioPorNome(string nome)
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "select *from tb_funcionarios where nome=@nome ";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@nome", nome);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelafuncionario);

                conn.Close();
                return tabelafuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region listarFuncionariosPorNome
        public DataTable listarFuncionariosPorNome(string nome)
        {
            try
            {
                DataTable tabelafuncionario = new DataTable();
                string sql = "select *from tb_funcionarios where nome like @nome ";

                MySqlCommand listar = new MySqlCommand(sql, conn);
                listar.Parameters.AddWithValue("@nome", nome);

                conn.Open();
                listar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(listar);
                da.Fill(tabelafuncionario);

                conn.Close();
                return tabelafuncionario;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao executar o comando SQL" + erro);
                return null;
            }
        }
        #endregion

        #region efetuarLogin
        public Boolean efetuarLogin(string email, string senha)
        {
            try
            {
                string sql = "select * from tb_funcionarios where email = @email and senha = @senha";

                MySqlCommand logar = new MySqlCommand(sql,conn);
                logar.Parameters.AddWithValue("@email", email);
                logar.Parameters.AddWithValue("@senha", senha);

                conn.Open();

                MySqlDataReader reader = logar.ExecuteReader();

                if (reader.Read())
                {
                    //Login feito com sucesso

                    string nivel = reader.GetString("nivel_acesso");
                    string nome = reader.GetString("nome");
                    //MessageBox.Show("Login realizado com acesso de: " + nivel);
                    MessageBox.Show("Seja bem vindo ao sistema, " + nome);
                    Frmmenu telamenu = new Frmmenu();
                    telamenu.txtUsuario.Text = nome;

                    if (nivel.Equals("Administrador"))
                    {
                        
                        telamenu.Show();
                        conn.Close();
                    }
                    else if (nivel.Equals("Vendedor"))
                    {
                        telamenu.menuProdutos.Visible = false;
                        telamenu.menuHistoricoVenda.Visible = false;
                        telamenu.Show();
                    }

                    
                    return true;
                }
                else
                {
                    //Login falhou
                    MessageBox.Show("Email ou senha incorreto!");
                    conn.Close();
                    return false;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro: " + erro);
                conn.Close();
                return false;
            }
        }
        #endregion

    }
}
