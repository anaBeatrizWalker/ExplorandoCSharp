using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
    public class Person
    {
        //Construtores
        public Person()
        {

        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        //Encapsulamento (criando campos para armazenar as propriedades)
        private string _name;
        private int _age;

        //Propriedades
        public string Name 
        { 
            get
            {
                return _name.ToUpper();
            }
            //Body Expression: get => _name.ToUpper();

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("The name cannot be empty. Closing the program...");
                }
                _name = value;
            }
        }

        public string Surname { get; set; }

        //Propriedade somente leitura
        public string CompleteName => $"{Name} {Surname}";

        public int Age 
        { 
            //Body Expression:
            get => _age;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("The age cannot be less than zero. Closing the program..");
                }
                _age = value;
            }
        }

        //Métodos
        public void IntroduceYourself()
        {
            Console.WriteLine($"Hi! My name is {CompleteName} and I have {Age} years.");
        }
    }
}