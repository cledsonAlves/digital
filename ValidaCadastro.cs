using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/* Classe responsável por validar os dados passados pelo usuario 
 * para depois realizar o cadastro no banco */


namespace $safeprojectname$
{
    public class ValidaCadastro
    {
        private Conexao conexão;


        //Método valida e Cadastra usuario 
        public String cadastraUsuario(Usuario usuario)
        {
            /* Valido os dados do usuario  para o banco cadastrar*/
            if (validaNome(usuario.Nome) == false)
            {
                return "Nome não pode conter espaço em branco!";
            }
            else if (validaNome(usuario.Sobrenome) == false)
            {
                return "Sobrenome não pode conter espaço em banco!";
            }
            else if (validaEmail(usuario.Email) == false)
            {
                return "E-mail informado é invalido!";
            }
            else if (validaSenha(usuario.Senha, usuario.ConfSenha)== false)
            {
                return "A senhas informadas não conferem!";
            }
            else
            {
                //  abre uma conexão com o banco
                conexão = new Conexao();

                // verifica se o e-mail existe 
                //  if (conexao.verificaEmail(usuario.Email)== false{}

                //  Envia o usuario para realizar o cadastro no banco .
                if (conexão.cadastraUsuario(usuario))
                {
                    //  envia um email de confirmação de cadastro para o usuario
                    //enviaEmail(usuario.Email);
                    return "usuario cadastrado com sucesso";
                }

                return "Não foi possível cadastrar usuario no banco";
            }

        }



        //Método valida e-mail
        public bool validaEmail(String email)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método valida senha
        public bool validaSenha(String senha, String confSenha)
        {
            if (senha.Length >= 6)
            {
                if (senha.Equals(confSenha))
                {
                    return true;
                }
            }
            return false;

        }
        //  Método valida nome ( * Campos em branco )
        public bool validaNome(String nome)
        {
            for (int i = 0; i < nome.Length; i++)
                if (Char.IsWhiteSpace(nome, i))
                {
                    return false;
                }
            return true;

        }

    }
}