using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstruturaRepeticao.estrutura
{
    public class EstruturaFor
    {
        public void Contador()
        {
            int numero = 10;

            //O for cria uma estrutura de repetição
            //È necessario a inicialização de um contador, a codição a ser executada e o incremento/decremento
            for(int contador = 0; contador <= 10; contador++) 
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }

        public void WhileContador() 
        {
            int numero = 5;
            int contador = 0;

            //O while pecorre o bloco de codigo e é executado enquanto a condição for true e temos que declara a variavel antes do laço 
            // e declarar o incremento/decremento.
            while(contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++;
            }
        }

        public void DoWhileContador()
        {
            int soma = 0, numero = 0;

            //O Do While executa o bloco de código uma vez, antes de verificar se a condição é verdadeira 
            do 
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                soma += numero;
            } 
            while(numero != 0);

            Console.WriteLine($"Total da soma dos números digitados é: {soma}");
        }
    }
}