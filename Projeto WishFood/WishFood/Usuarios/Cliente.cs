using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishFood.Pagamento;

namespace WishFood.Usuarios {
    public class Cliente : Usuario {

        public MetodoPagamento Pagamento { get; set; }

        public Cliente() : base() {
            
        }

        public Cliente(string nome, string cpf, string email, string telefone, string senha, Endereco endereco, MetodoPagamento pagamento) : base(nome, cpf, email, telefone, senha, endereco) {
            this.Pagamento = pagamento;
        }

        public override string ToString() {
            string toString;
            toString = base.ToString();
            toString += "Pagamento: " + Pagamento;
            return toString;
        }
    }
}
