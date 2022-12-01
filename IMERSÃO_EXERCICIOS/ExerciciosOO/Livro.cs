using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOO
{
    internal class Livro
    {
        public int N_paginas;
        public string Titulo_Livro;
        public string Autor;
        public int ISBN;
        public int Ano;
        public string Cate;
        public Livro(string Autor, string cat)
        {
            this.Autor = Autor;
            this.Cate = cat;
        }
    }
}
