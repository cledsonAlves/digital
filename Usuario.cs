using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/**
 *   Classe usuario para armazenar os dados do novo usuario 
 * **/
namespace $safeprojectname$
{
    public class Usuario
    {
        private String nome;
        private String sobrenome;
        private String email;
        private String senha;
        private String confSenha;


        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public String ConfSenha
        {
            get { return confSenha; }
            set { confSenha = value; }
        }
    }
        
}