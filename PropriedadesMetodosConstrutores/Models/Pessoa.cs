using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropriedadesMetodosConstrutores.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

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

        public int Idade 
        { 
            get
            {
                return _idade;
            }
            set
            {
                if(value < 0)
                {
                  throw new ArgumentException("A sua idade não pode ser negativa! Tente outra vez.");  
                }
                _idade = value;
            }
        
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}