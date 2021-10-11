using LivrariaCSharp.model;
using MySql.Data.MySqlClient;
using System;

using System.Collections.Generic;

namespace LivrariaCSharp.controller
{
    public class AcervoDAO
    {
        private MySqlConnection con;
        private MySqlCommand cmd;

        public AcervoDAO()
        {
            this.con = Conexao.Conectar();
        }

        public int inserir(Acervo p)
        {
            try
            {
                string sql = "INSERT INTO acervo(Id_editora, Titulo," + "Autor, Ano, Preco,Quantidade,Tipo) VALUES(@p1, @p2," + "@p3, @p4, @p5, @p6, @p7);";

                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", p.Id_editora);
                cmd.Parameters.AddWithValue("@p1", p.Titulo);
                cmd.Parameters.AddWithValue("@p1", p.Autor);
                cmd.Parameters.AddWithValue("@p1", p.Ano);
                cmd.Parameters.AddWithValue("@p1", p.Preco);
                cmd.Parameters.AddWithValue("@p1", p.Quantidade);
                cmd.Parameters.AddWithValue("@p1", p.Tipo);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return (int)cmd.LastInsertedId;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
                return -1;
            }
            finally
            {
                Conexao.Desconectar(con);
            }
        }
        public int atualizar(Acervo p)
        {
            try
            {

                string sql = "UPDATE produto SET Id_editora = @p1, Titulo = @p2," + "Autor = @p3, Ano = @p4, Preco = @p5, Quantidade = @p6, Tipo = @p7 WHERE id = @p8;";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", p.Id_editora);
                cmd.Parameters.AddWithValue("@p2", p.Titulo);
                cmd.Parameters.AddWithValue("@p3", p.Autor);
                cmd.Parameters.AddWithValue("@p4", p.Ano);
                cmd.Parameters.AddWithValue("@p5", p.Preco);
                cmd.Parameters.AddWithValue("@p6", p.Quantidade);
                cmd.Parameters.AddWithValue("@p7", p.Tipo);
                cmd.Parameters.AddWithValue("@p8", p.Id);
                return cmd.ExecuteNonQuery() >0 ? p.Id : -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
                return -1;
            }
            finally
            {
                Conexao.Desconectar(con);
            }
        }
        public int deletar(Acervo p)
        {
            try
            {
                string sql = "DELETE from acervo WHERE id = @p1;";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", p.Id);
                return cmd.ExecuteNonQuery() >0 ? p.Id : -1;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
                return -1;
            }
            finally
            {
                Conexao.Desconectar(con);
            }
        }
        public List<Acervo> listar()
        {
            try
            {

                string sql = "SELECT* FROM produto ORDER BY id";
                cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Acervo> lista = new List<Acervo>();
                while (dr.Read())
                {
                    Acervo p = new Acervo();
                    p.Id = dr.GetInt32("id");
                    p.Id_editora = dr.GetInt32("id_categoria");
                    p.Titulo = dr.GetString("Titulo");
                    p.Autor = dr.GetString("Autor");
                    p.Ano = dr.GetInt32("Ano");
                    p.Preco = dr.GetDouble("Preco");
                    p.Quantidade = dr.GetInt32("Quantidade");
                    p.Tipo = dr.GetInt32("Tipo");

                }
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " + e.Message);
                return null;
            }
            finally { Conexao.Desconectar(con); }
        }
        public List<Acervo> pesquisarPorNome(string Titulo)
        {
            try
            {
                string sql = "SELECT* FROM acervo WHERE Titulo like @p1 ORDER BY Titulo";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", "%"+Titulo+"%");
                MySqlDataReader dr = cmd.ExecuteReader();
                List<Acervo> lista = new List<Acervo>();
                while (dr.Read())
                {
                    Acervo p = new Acervo();
                    p.Id = dr.GetInt32("id");
                    p.Id_editora = dr.GetInt32("id_categoria");
                    p.Titulo = dr.GetString("Titulo");
                    p.Autor = dr.GetString("Autor");
                    p.Ano = dr.GetInt32("Ano");
                    p.Preco = dr.GetDouble("Preco");
                    p.Quantidade = dr.GetInt32("Quantidade");
                    p.Tipo = dr.GetInt32("Tipo");
                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO: " +e.Message);
                return null;
            }
            finally { Conexao.Desconectar(con); }
        }

    }
}