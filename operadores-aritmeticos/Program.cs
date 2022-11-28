using System;
using operadores_aritmeticos.calculadora;

namespace operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadoraBasica = new Calculadora();

            calculadoraBasica.Somar(5, 10);
            calculadoraBasica.Subtrair(10, 5);
            calculadoraBasica.Multiplicar(3, 2);
            calculadoraBasica.Dividir(50, 10);
            calculadoraBasica.Potencia(3, 3);
            calculadoraBasica.Seno(30);
            calculadoraBasica.Coseno(30);
            calculadoraBasica.Tangente(30);


        }
    }
}
