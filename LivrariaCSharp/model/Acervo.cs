using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaCSharp.model
{
    class Acervo
    {
        public int id { get; set; }
        public int id_editora { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public int ano { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
        public int tipo { get; set; }

        public Acervo()
        {
        }
        public Acervo(int id, int id_editora, string titulo, string autor, int ano, double preco, int quantidade, int tipo)
        {
            this.id = id;
            this.id_editora = id_editora;
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
            this.preco = preco;
            this.quantidade = quantidade;
            this.tipo = tipo;
        }
        public override string ToString()
        {
            return this.titulo;
        }
    }
}
