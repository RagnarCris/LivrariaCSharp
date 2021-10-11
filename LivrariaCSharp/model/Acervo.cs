using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaCSharp.model
{
    public class Acervo
    {
        public int Id { get; set; }
        public int Id_editora { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public int Tipo { get; set; }

        public Acervo()
        {
        }
        public Acervo(int id, int id_editora, string titulo, string autor, int ano, double preco, int quantidade, int tipo)
        {
            this.Id = id;
            this.Id_editora = id_editora;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Ano = ano;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.Tipo = tipo;
        }
        public override string ToString()
        {
            return this.Titulo;
        }
    }
}
