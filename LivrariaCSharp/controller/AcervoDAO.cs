using LivrariaCSharp.model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
                string sql = "INSERT INTO acervo (id_editora, titulo, autor, ano, preco, quantidade, tipo) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7);";

                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", p.Id_editora);
                cmd.Parameters.AddWithValue("@p2", p.Titulo);
                cmd.Parameters.AddWithValue("@p3", p.Autor);
                cmd.Parameters.AddWithValue("@p4", p.Ano);
                cmd.Parameters.AddWithValue("@p5", p.Preco);
                cmd.Parameters.AddWithValue("@p6", p.Quantidade);
                cmd.Parameters.AddWithValue("@p7", p.Tipo);

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

                string sql = "UPDATE acervo SET id_editora = @p1, titulo = @p2, autor = @p3, ano = @p4, preco = @p5, quantidade = @p6, tipo = @p7 WHERE id = @p8;";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", p.Id_editora);
                cmd.Parameters.AddWithValue("@p2", p.Titulo);
                cmd.Parameters.AddWithValue("@p3", p.Autor);
                cmd.Parameters.AddWithValue("@p4", p.Ano);
                cmd.Parameters.AddWithValue("@p5", p.Preco);
                cmd.Parameters.AddWithValue("@p6", p.Quantidade);
                cmd.Parameters.AddWithValue("@p7", p.Tipo);
                cmd.Parameters.AddWithValue("@p8", p.Id);
                return cmd.ExecuteNonQuery() > 0 ? p.Id : -1;
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
                return cmd.ExecuteNonQuery() > 0 ? p.Id : -1;
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

                string sql = "SELECT * FROM acervo ORDER BY id";
                cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                //List<Acervo> lista = new List<Acervo>();
                var lista = new List<Acervo>();
                while (dr.Read())
                {
                    Acervo p = new Acervo();
                    p.Id = dr.GetInt32("id");
                    p.Id_editora = dr.GetInt32("id_editora");
                    p.Titulo = dr.GetString("titulo");
                    p.Autor = dr.GetString("autor");
                    p.Ano = dr.GetInt32("ano");
                    p.Preco = dr.GetDouble("preco");
                    p.Quantidade = dr.GetInt32("quantidade");
                    p.Tipo = dr.GetInt32("tipo");
                    lista.Add(p);
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
        public List<Acervo> pesquisarPorTitulo(string titulo)
        {
            try
            {
                //string sql = "SELECT * FROM acervo WHERE titulo LIKE '%" + titulo + "%' ORDER BY titulo";
                string sql = "SELECT * FROM acervo WHERE titulo LIKE @p1 ORDER BY titulo";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p1", "%"+titulo+"%");
                MySqlDataReader dr = cmd.ExecuteReader();
                var lista = new List<Acervo>();
                
                while (dr.Read())
                {
                    Acervo p = new Acervo();
                    p.Id = dr.GetInt32("id");
                    p.Id_editora = dr.GetInt32("id_editora");
                    p.Titulo = dr.GetString("titulo");
                    p.Autor = dr.GetString("autor");
                    p.Ano = dr.GetInt32("ano");
                    p.Preco = dr.GetDouble("preco");
                    p.Quantidade = dr.GetInt32("quantidade");
                    p.Tipo = dr.GetInt32("tipo");
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