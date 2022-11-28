using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_de_operadores.operadores
{
    public class OperadoresCondicionais
    {
        //breakpoint + f5 para iniciar + f10 para continuar
        int quantidadeEstoque = 4;
        int quantidadeCompra = 5;

        public void IfAninhado() 
        {
            if(quantidadeEstoque >= quantidadeCompra)
            {
                Console.WriteLine("Venda realizada.");
            }
            else if(quantidadeCompra == 0) 
            {
                Console.WriteLine("Venda Inválida!");
            }
            else 
            {
                Console.WriteLine("Não foi possivel realizar a compra");
            }
        }

        public void ApredendoSwitchCase()
        {
            Console.WriteLine("Digite uma letra: ");
            string letra = Console.ReadLine();

            switch (letra)
            {
                case "a":
                Console.WriteLine("É uma vogal.");
                break;
                case "e":
                Console.WriteLine("É uma vogal.");
                break;
                case "i":
                Console.WriteLine("É uma vogal.");
                break;
                case "o":
                Console.WriteLine("É uma vogal.");
                break;
                case "u":
                Console.WriteLine("É uma vogal.");
                break;
                default:
                Console.WriteLine("Não é uma vogal.");
                break;                
            }
        }
    }
}