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

        }
        public int atualizar(Acervo p)
        {

        }
        public int deletar(Acervo p)
        {

        }
        public List<Acervo> listar()
        {

        }
        public List<Acervo> pesquisarPorNome(string nome)
        {

        }

    }
}