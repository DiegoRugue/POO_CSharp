using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Apostila {
    class Conta {
        public string titular;
        public int numero;
        public double saldo;
        public int idade;

        public void Depositar(double valor) {
            this.saldo += valor;
        }

        public bool Sacar(double valor) {
            if (valor <= saldo) {
                if (idade <= 18) {
                    if (valor <= 200) {
                        this.saldo -= valor;
                        return true;
                    } else {
                        return false;
                    }
                }
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public void Transferir(double valor, Conta conta) {
            if (valor <= saldo) {
                this.Sacar(valor);
                conta.Depositar(valor);
            }
        }
    }
}
