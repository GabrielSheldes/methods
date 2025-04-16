using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    internal class Cliente :Pessoa
    {
        protected int id;

        public override void cadastrar()
        {
            base.cadastrar();
            Console.WriteLine("digite id do cliente: ");
            this.id = int.Parse(Console.ReadLine());
        }
    }
}
