using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayLista
{
    public class ArraysList
    {
        public void ArrayInteiro() 
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 45;
            arrayInteiros[2] = 50;

            //Pecorrendo o array com FOR
            for(int contador = 0; contador < arrayInteiros.Length; contador++)
            {
                Console.WriteLine($"{contador}° Posicao - {arrayInteiros[contador]}");
            }
        }

        public void PercorrerArray()
        {
            int[] arrayInteiros = new int[3];

            arrayInteiros[0] = 72;
            arrayInteiros[1] = 45;
            arrayInteiros[2] = 50;

            //Pecorrendo o array com FOREACH
            foreach (int valor in arrayInteiros)
            {
                Console.WriteLine(valor);
            }
        }

        public void Redimensionando()
        {
            int[] arrayInteiros = new int[3];

            //Acessando a classe para redimensionar o seu tamanho, passando como referencia o Array e acessando o tamanho do array para aumentar/multiplicar
            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
            Console.WriteLine(arrayInteiros);
        }

        public void CopiarValores()
        {
            int[] arrayInteiros = new int[3];

            int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
            Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
        }

        public void TrabalhandoComListas()
        {
            //List é uma classe do tipo string que cria uma listaString que recebe uma List
            List<string> listaString = new List<string>();

            listaString.Add("SP");
            listaString.Add("RJ");
            listaString.Add("SC");
            listaString.Add("PA");

            int contador = 0;

            foreach(string item in listaString)
            {
                Console.WriteLine($"{contador}° Posicao - {item}");
                contador++;
            }
        }
    }
}