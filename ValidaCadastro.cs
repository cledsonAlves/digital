using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace $safeprojectname$
{
    public class ValidaCadastro
    {

        // Método valida cadastro
        public void valida(Usuario usuario)
        {
        }

        //Método valida e-mail
        public bool validaEmail(String strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}