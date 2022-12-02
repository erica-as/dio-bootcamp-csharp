using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposDeOperadores.operadores
{
    public class OperadoresLogicos
    {
        public void OperatorOr()
        {
            bool maiorDeIdade = false;
            bool possuiAutorizacaoDoResponsavel = false;

            //O operador Or(||) verifica se uma das condições é verdadeira, sendo verdadeira retorna true.
            if(maiorDeIdade || possuiAutorizacaoDoResponsavel)
            {
                Console.WriteLine("Entrada liberada!");
            }
            else
            {
                Console.WriteLine("Entrada não liberada!");
            }
        }

        public void OperatorAnd()
        {
            double mediaDeNotas = 8;
            bool possuiPresenciaMinima = true;

            //O operador And(&&) verifica se todas as condições são verdadeiras, não sendo verdadeiras retorna false.
            if(mediaDeNotas >= 7 && possuiPresenciaMinima)
            {
                Console.WriteLine("Entrada liberada!");
            }
            else
            {
                Console.WriteLine("Entrada não liberada!");
            }
        }

        public void OperatorNot()
        {
            bool afirmacao = true;

            //O operador Not(!) nega que a condição seja verdadeira, sendo verdadeira retorna false e se é false retorna verdadeiro.
            if(!afirmacao)
            {
                Console.WriteLine("A Afirmação é verdadeira.");
            }
            else 
            {
                Console.WriteLine("A afirmação não é verdadeira.");
            }
        }
    }
}