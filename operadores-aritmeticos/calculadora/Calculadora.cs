using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace operadores_aritmeticos.calculadora
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            //Utilizamos a classe Math e acessamos o método Pow que realiza a potencia de um número.
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            //Utilizamos a classe Math e acessamos o método Sin que realiza o calculo do radiono do Seno.
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}.");
        }

        public void Coseno(double angulo)
        {
            //Utilizamos a classe Math e acessamos o método Sin que realiza o calculo do radiono do Coseno.
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}.");
        }

        public void Tangente(double angulo)
        {
            //Utilizamos a classe Math e acessamos o método Sin que realiza o calculo do radiono do Tangente.
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 2)}.");
        }

        public void RaizQuadrada(double x)
        {
            //Utilizamos a classe Math e acessamos o método Sqrt que realiza o calculo da raiz quadrada.
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz de {x} é {raiz}");
        }
    }
}