using System;
using sintaxe_tipo_de_dados.Models;

namespace sintaxe_tipo_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoaFisica = new Pessoa();
            
            pessoaFisica.Nome = "Érica";
            pessoaFisica.Idade = 21;

            pessoaFisica.Apresentacao();

            //Date Time é a principal váriavel para se trbalhar com datas 
            DateTime dataAtual = DateTime.Now.AddDays(5);
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH/mm"));

        }
    }
}
