using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    internal class ClienteVip
    {
        public double descontos;
        public double cashback;

    public double calcularDesconto(double valorInicial, double valorComDesconto)
        {
            valorComDesconto = valorInicial * (this.desconto / 100);
            return valorComDesconto;
        }

        public void exibirDesconto()
        {
            Console.WriteLine("seu cashback é:{0} ", this.desconto);
        }

        public double calcularCashback(double valorCompra, double valorComCashback)
        {
            valorComCashback = valorCompra * (this.cashback / 100);
            return valorComCashback;
        }

        public void exibirCashback()
        {
            Console.WriteLine("Seu cashback é: ", this.cashback);
        }
            
        }
}
