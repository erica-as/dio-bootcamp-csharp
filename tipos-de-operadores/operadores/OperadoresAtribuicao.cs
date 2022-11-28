using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_de_operadores.operadores
{
    public class OperadoresAtribuicao
    {
        public void ConverterTiposvariaveis() 
        {

            //Cast - Casting
            int i = 12; 
            double d = 765.12; 
            float f = 56.123F; 

            //converte um tipo em outro tipo
            Console.WriteLine(Convert.ToString(f)); 
            Console.WriteLine(Convert.ToInt32(d)); 
            Console.WriteLine(Convert.ToUInt32(f)); 
            Console.WriteLine(Convert.ToDouble(i));             
        }
    }
}