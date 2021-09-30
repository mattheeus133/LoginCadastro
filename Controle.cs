using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCadastro
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha) 
        {
            LoginDal loginDalComandos = new LoginDal();
            tem = loginDalComandos.verificarLogin(login, senha);
            if (!loginDalComandos.mensagem.Equals("")) 
            {
                this.mensagem = loginDalComandos.mensagem; 
                // metodo para saber se ouve algum erro no codigo
            }
            return tem;
        }

        public String cadastrar(String nome, String senha, String confSenha) 
        {
            return mensagem;
        }
    }
}
