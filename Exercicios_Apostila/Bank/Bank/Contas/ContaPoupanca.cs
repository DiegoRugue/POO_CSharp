using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Clientes;

namespace Banco.Contas {
    class ContaPoupanca : Conta {

        public ContaPoupanca() {
            Tipo = "Conta Poupança";
        }

        public ContaPoupanca(Cliente titular) : base(titular) {
            Tipo = "Conta Poupança";
        }

        public override void Sacar(double valor) {
            base.Sacar(valor + 0.10);
        }

    }
}
