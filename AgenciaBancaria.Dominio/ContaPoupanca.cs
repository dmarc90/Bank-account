using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Cliente cliente): base(cliente) // Herda do construtor Cliente
        {
            // 0,30%
            PercentualRendimento = 0.003M; // O M como sufixo define que o valor é decimal.
        }

        public decimal PercentualRendimento { get; private set; }

    }
}
