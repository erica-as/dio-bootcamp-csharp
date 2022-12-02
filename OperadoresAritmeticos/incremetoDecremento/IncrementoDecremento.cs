using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperadoresAritmeticos.incremetoDecremento
{
    public class IncrementoDecremento
    {
        public void Incremento()
        {
            int numero = 25;
            Console.WriteLine($"Incrementando: {++numero}");
        }

        public void Decremento()
        {
            int numero = 25;
            Console.WriteLine($"Incrementando: {--numero}");
        }
    }
}