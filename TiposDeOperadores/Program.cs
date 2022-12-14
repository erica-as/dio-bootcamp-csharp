using System;
using TiposDeOperadores.operadores;

namespace TiposDeOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            OperadoresAtribuicao operadoresAtribuicao = new OperadoresAtribuicao();
            OperadoresCondicionais operadoresCondicionais = new OperadoresCondicionais();
            OperadoresLogicos operadoresLogicos = new OperadoresLogicos();

            Console.WriteLine("Operadores de Atribuicao: \n");
            operadoresAtribuicao.ConverterTiposvariaveis();
            operadoresAtribuicao.CastImplicito();
            operadoresAtribuicao.ConversaoSegura();
            Console.WriteLine("-------------");

            Console.WriteLine("Operadores Condicionais: \n");
            operadoresCondicionais.IfAninhado();
            operadoresCondicionais.ApredendoSwitchCase();

            Console.WriteLine("Operadores Lógicos: \n");
            operadoresLogicos.OperatorOr();
            operadoresLogicos.OperatorAnd();
            operadoresLogicos.OperatorNot();
        }
    }
}
