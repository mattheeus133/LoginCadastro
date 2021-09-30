using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCadastro
{
    class LoginDal
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        public bool verificarLogin(String login, String senha) 
        /*metodo VerificarLogin vai ao banco de dados verificar se os dados corresponde
         aos digitados pelo usuario e vai retornar o valor verdadeiro ou falso*/ 
        {
            //comandos sql
            //comando que sera execultado la no banco de dados
            cmd.CommandText = "select * from nomeDaTabela where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // se foi encontrado 
                {
                    tem = true;
                }
                
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com banco de Dados";
            }
            return tem;
        }

        public String Cadastrar(String email, String senha, String confSenha)
        {
            // comandos de inserção de dados 
            return mensagem;
        }
    }
}
