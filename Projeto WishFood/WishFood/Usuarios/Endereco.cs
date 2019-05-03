using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishFood.Usuarios {
    public class Endereco {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int Cep { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco() {

        }

        public Endereco(string rua, int numero, string bairro, int cep, string complemento, string cidade, string estado) {
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Complemento = complemento;
            this.Cidade = cidade;
            this.Estado = estado;
        }

        public override string ToString() {
            string toString ="";

            toString = "Rua : " + Rua;
            toString += " Numero: " + Numero;
            toString += " Bairro: " + Bairro;

            return toString;
        }


    }
}
