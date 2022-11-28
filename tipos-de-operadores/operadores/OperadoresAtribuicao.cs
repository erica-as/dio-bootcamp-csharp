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
            //Convert é uma clasr r To() é um método
            Console.WriteLine(Convert.ToString(f)); 
            Console.WriteLine(Convert.ToInt32(d)); 
            Console.WriteLine(Convert.ToDouble(i));   

            string p = "155";

            Console.WriteLine(Int32.Parse(p));

            //Converte para string
            int inteiro = 6;
            string ab = inteiro.ToString();
            Console.WriteLine(ab);

        }

        public void CastImplicito()
        {
            //São tipos diferentes, mas um int cabe em um double e há uma conversão implícitamente
            int a = 5;
            double b = a;

            Console.WriteLine(b);
        }

        public void ConversaoSegura() 
        {
            string a = "15";
            int b = 0;

            int.TryParse(a, out b);

            Console.WriteLine(b);
            Console.WriteLine("Conversao realizada com sucesso!");

        }
    }
}