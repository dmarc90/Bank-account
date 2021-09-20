using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Cliente cliente, decimal limite): base(cliente)
        {
            ValorTaxaManutencao = 0.5M;
            Limite = limite;
        }

        public override void Sacar(decimal valor, string senha)
        {
            if (Senha != senha)
            {
                throw new Exception("Senha inválida.");
            }

            if ((Saldo + Limite) < valor)
            {
                throw new Exception("Saldo insuficiente.");
            }

            Saldo -= valor;
        }

        public decimal Limite { get; private set; }

        public decimal ValorTaxaManutencao { get; private set; }

    }
}
