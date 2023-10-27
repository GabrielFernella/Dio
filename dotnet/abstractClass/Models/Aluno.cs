using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstractClass.Models
{
    public class Aluno: Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o Aluno {Nome} e tenho nota: {Nota}");
        }

    }
}