using System;
using tipos_de_operadores.operadores;

namespace tipos_de_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            OperadoresAtribuicao operadoresAtribuicao = new OperadoresAtribuicao();
            OperadoresCondicionais operadoresCondicionais = new OperadoresCondicionais();

            Console.WriteLine("Operadores de Atribuicao: \n");
            operadoresAtribuicao.ConverterTiposvariaveis();
            operadoresAtribuicao.CastImplicito();
            operadoresAtribuicao.ConversaoSegura();
            Console.WriteLine("-------------");

            Console.WriteLine("Operadores Condicionais: \n");
            operadoresCondicionais.IfAninhado();
            operadoresCondicionais.ApredendoSwitchCase();

        }
    }
}
