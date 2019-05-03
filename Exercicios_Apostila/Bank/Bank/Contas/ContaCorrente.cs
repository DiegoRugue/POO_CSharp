using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Clientes;
using Banco.Tributaveis;

namespace Banco.Contas {
    class ContaCorrente : Conta, ITributavel {

        public ContaCorrente() {
            Tipo = "Conta Corrente";
        }

        public ContaCorrente(Cliente titular) : base(titular) {
            Tipo = "Conta Corrente";
        }

        public override void Sacar(double valor) {
            base.Sacar(valor + 0.05);
        }

        public override void Depositar(double valor) {
            base.Depositar(valor - 0.10);
        }

        public double CalculaTributos() {
            return this.Saldo * 0.05;
        }

    }
   
  
}
