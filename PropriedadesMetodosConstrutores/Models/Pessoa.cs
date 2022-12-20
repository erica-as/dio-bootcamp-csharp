using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        public string _nome;
        public int MyProperty { get; set; }

        public string Nome 
        { 
            get
            {
                return _nome.ToUpper();
            }
            
            set
            {
                if(value == "")
                {
                    //Exception
                    throw new ArgumentException("O nome não pode ser vazio! Tente outra vez.");
                }
                _nome = value;
            } 
        }

        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}