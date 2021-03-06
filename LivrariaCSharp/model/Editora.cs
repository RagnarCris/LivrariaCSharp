using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaCSharp.model
{
    public class Editora
    {
        private int id;
        private string nome;
        public Editora()
        {
        }
        public Editora(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
