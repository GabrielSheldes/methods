using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    internal class Pessoa
    {
        protected string nome; //propriedade
        public string Nome //Propriedae
        {
            get

            { return nome; }

            set
            {
                nome = value;
            }

        }
        protected string email;
        public string Email
        {
            get { return email; }

            set
            { email = value;}
        }
        public virtual void cadastrar()
        {
            Console.WriteLine("Digite seu nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu Email: ");
            this.Email = Console.ReadLine();
        }
    }
}
