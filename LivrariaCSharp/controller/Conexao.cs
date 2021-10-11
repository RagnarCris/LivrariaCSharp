using MySql.Data.MySqlClient;
using System;

namespace LivrariaCSharp.controller
{
    public class Conexao
    {
        private static string DATABASE = "livraria;";
        private static string HOST = "localhost";
        private static string USR = "root";
        private static string PWD = "";
        private static string URL = "server=" + HOST + ";UserId=" + USR + ";password=" + PWD + ";database=" + DATABASE;

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
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " +e.Message);
            }
        }
    }
}