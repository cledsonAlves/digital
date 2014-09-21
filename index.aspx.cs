using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace $safeprojectname$
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          
        }

        protected void enviar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            String s = usuario.Nome;
            //  Setando o novo usuario ...
            usuario.Nome = Request.Form["nome"];
            usuario.Sobrenome = Request.Form["sobrenome"];
            usuario.Email = Request.Form["email"];
            usuario.Senha = Request.Form["senha"];
            usuario.ConfSenha = Request.Form["confSenha"];

     
        }
    }
}