using MySql.Data.MySqlClient;
using System;

namespace LivrariaCSharp.controller
{
    public class Conexao
    {
        private static string DATABASE = "livraria;";
        private static string HOST = "localhost";
        private static string USR = "root";
        private static string SSL = "SSL Mode=none;Certificate Store Location=CurrentUser;";
        //private static string URL = "SERVER=" + HOST + ";UID=" + USR + ";PASSWORD=" + PWD + ";DATABASE=" + DATABASE; // Não funcionou
        private static string URL = "SERVER=" + HOST + ";UserId=" + USR + ";" + SSL + "DATABASE=" + DATABASE;

        public static MySqlConnection Conectar()
        {
            try
            {

                MySqlConnection con = new MySqlConnection(URL);
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " +e.Message);
                return null;
            }

        }
        public static void Desconectar(MySqlConnection con)
        {
            try
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " +e.Message);
            }
        }
    }
}