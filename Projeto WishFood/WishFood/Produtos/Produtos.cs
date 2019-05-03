using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishFood.Produtos {
    public class Produto {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string UnidadeMedida { get; set; }

        public Produto() {

        }

        public Produto(string nome, double preco, int quantidade, string unidade) {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.UnidadeMedida = unidade;
        }

        public override string ToString() {
            string toString = "";
            toString += "Produto: " + Nome;
            toString += " Preco: R$ " + Preco;
            toString += " Quantidade em estoque: " + Quantidade;
            toString += " " + UnidadeMedida;
            return toString;
        }

    }
}
