using System;
using PropriedadesMetodosConstrutores.Models;

namespace PropriedadesMetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Camilla";
            pessoa.Idade = 21;

            pessoa.Apresentar();
        }
    }
}
