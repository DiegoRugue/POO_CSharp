using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishFood.Estabelecimentos;

namespace WishFood.Usuarios {
    public class Logista : Usuario {

        public Estabelecimento Estabelecimento { get; set; }

        public Logista() : base() {
                
        }

        public Logista(string nome, string cpf, string email, string telefone, string senha, Endereco endereco, Estabelecimento estabelecimento)  : base(nome, cpf, email, telefone, senha, endereco) {
            this.Estabelecimento = estabelecimento;
        }

        public override string ToString() {
            string toString;
            toString = base.ToString();
            toString += "Estabelecimento: " + Estabelecimento;
            return toString;
        }

    }
}
