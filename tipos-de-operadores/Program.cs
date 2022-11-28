using System;
using tipos_de_operadores.operadores;

namespace tipos_de_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            OperadoresAtribuicao operadoresAtribuicao = new OperadoresAtribuicao();

            Console.WriteLine("Operadores de Atribuicao: ");
            operadoresAtribuicao.ConverterTiposvariaveis();
            operadoresAtribuicao.CastImplicito();
            operadoresAtribuicao.ConversaoSegura();
            Console.WriteLine("-------------");
        }
    }
}
