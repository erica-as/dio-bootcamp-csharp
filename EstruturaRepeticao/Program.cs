using System;
using EstruturaRepeticao.estruturas;

namespace EstruturaRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            EstruturaFor estrutura = new EstruturaFor();

            Console.WriteLine("FOR");
            estrutura.Contador();

            Console.WriteLine("---------");

            Console.WriteLine("WHILE");
            estrutura.WhileContador();

            Console.WriteLine("---------");

            Console.WriteLine("DO WHILE");
            estrutura.DoWhileContador();

            Console.WriteLine("---------");

            Console.WriteLine("MENU INTERATIVO");
            MenuInterativo menu = new MenuInterativo();
            menu.Menu();

        }
    }
}
