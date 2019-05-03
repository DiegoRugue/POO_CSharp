using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishFood.Pagamento {
    public class MetodoPagamento {
        public string NomeCartao { get; set; }
        public int Numero { get; set; }
        public string DataVencimento { get; set; }

        public MetodoPagamento() {

        }

        public MetodoPagamento(string nomeCartao, int numero, string dataVencimento) {
            this.NomeCartao = nomeCartao;
            this.Numero = numero;
            this.DataVencimento = dataVencimento;
        }

        public override string ToString() {
            string toString;
            toString = "Nome do Titular: " + NomeCartao;
            toString += " Numero: " + Numero;
            toString += " Data de Vencimento: " + DataVencimento;
            return toString;
        }
    }
}
