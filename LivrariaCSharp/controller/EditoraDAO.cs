using LivrariaCSharp.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
namespace LivrariaCSharp.controller
{
    public class EditoraDAO
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        public EditoraDAO()
        {
            this.con = Conexao.Conectar();
        }

        public List<Editora> listar()
        {
            try
            {
                string sql = "SELECT* FROM editora ORDER BY id";
                cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                List<Editora> lista = new
                List<Editora>();
                while (dr.Read())
                {
                    Editora cat = new Editora();
                    cat.Id = dr.GetInt32("id");
                    cat.Nome = dr.GetString("nome");
                    lista.Add(cat);
                }
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " +e.Message);
                return null;
            }
            finally
            {
                Conexao.Desconectar(con);
            }
        }
    }
}