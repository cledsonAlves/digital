using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

using System.IO;

/**
 * Ultilizando algoritimo simples para criptografia em  MD5
 * */


namespace $safeprojectname$
{

    public class Criptografia
    {

        public  string AcertaSenha(string _senha)
        {
            StringBuilder senha = new StringBuilder();

            MD5 md5 = MD5.Create();
            byte[] entrada = Encoding.ASCII.GetBytes(_senha);
            byte[] hash = md5.ComputeHash(entrada);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                senha.Append(hash[i].ToString("X2"));
            }
            return senha.ToString();
        }


    }


}