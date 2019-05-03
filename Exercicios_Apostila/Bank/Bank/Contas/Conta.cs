using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Clientes;

namespace Banco.Contas {
    public abstract class Conta {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public string Tipo { get; protected set; }
        private static int totalDeContas = 1;

        public Conta() {
            this.Numero = totalDeContas++;
        }

        public Conta(Cliente titular) {
            this.Titular = titular;
            this.Numero = totalDeContas++;
            this.Saldo = 0;
        }

        public virtual void Depositar(double valor) {
            if (valor < 0) {
                throw new Exception("Não é possível depositar um valor negativo");
            } else if (valor == 0) {
                throw new Exception("Não é possível depositar R$0");
            } else {
                this.Saldo += valor;
            }
        }

        public virtual void Sacar(double valor) {
            if (valor > Saldo) {
                throw new Exception("Saldo insuficiente");
            } else if (valor < 0) {
                throw new Exception("Valor do saque negativo");
            } else if (valor == 0) {
                throw new Exception("Não é possível sacar R$0");
            } else {
                Saldo -= valor;
            }
        }

        public static void Transferir(double valor, Conta conta1, Conta conta2) {
            if (valor > conta1.Saldo) {
                throw new Exception("Saldo insuficiente");
            } else if (valor < 0) {
                throw new Exception("Valor da transferencia negativo");
            } else if (valor == 0) {
                throw new Exception("Não é possível transferir R$0");
            } else {
                conta1.Sacar(valor);
                conta2.Depositar(valor);
            }
        }

        public override String ToString() {
            return "Titular: " + this.Titular.Nome;
        }

        public static int ProximaConta() {
            return totalDeContas;
        }

    }
}
