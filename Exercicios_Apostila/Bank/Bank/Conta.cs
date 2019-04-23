using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank {
    class Conta {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta(Cliente titular, int numero, double saldo) {
            this.Titular = titular;
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public bool Sacar(double valor) {
            if (valor <= Saldo) {
                Saldo -= valor;
                return true;
            }

            return false;
        }

        public void Transferir(double valor, Conta conta) {
            if (valor <= Saldo) {
                this.Sacar(valor);
                conta.Depositar(valor);
            }
        }

    }
}
