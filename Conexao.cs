using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace $safeprojectname$

    /* Classe Responsável pela conexão com o banco de dados */
{
    public class Conexao
    {
        private SqlConnection Conection;
        private DataSet DSet;
        string conec = "Data Source=LOCALHOST;Initial Catalog=$safeprojectname$;User ID=Cledson;Password=151185;Language=Portuguese";


        // abro a conexão no  construtor e os métodos ficam encarregados de fecha-la .
        public Conexao()
        {
            Conection = new SqlConnection(conec);
            try
            {
                //abre a conexao
                Conection.Open();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }



        //  Cadastra usuário no banco 
        public bool cadastraUsuario(Usuario usuario)
        {
            // Verifica se a conexão esta aberta
            if (Conection.State == ConnectionState.Open)
            {

                Criptografia c = new Criptografia();
                String senha = c.AcertaSenha(usuario.Senha);
                //Query SQL
                SqlCommand command = new SqlCommand("INSERT INTO usuario (email,nome,sobrenome,senha)" +
                "VALUES('" + usuario.Email + "','" + usuario.Nome + "','" + usuario.Sobrenome + "','" + senha + "')", Conection);
                //Executa a Query SQL
                command.ExecuteNonQuery();
                // Fecha a conexão
                Conection.Close();
                return true;
            }
            else
            {
                return  false;
            }
        }


    }

}
