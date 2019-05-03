using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishFood.Produtos;
using WishFood.Usuarios;

namespace WishFood.Estabelecimentos {
    public class Estabelecimento {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public Endereco Endereco { get; set; }
        public List<Produto> Produtos { get; set; }

        public Estabelecimento() {

        }

        public Estabelecimento(string razao, string nome, string cnpj, Endereco endereco, Produto produto) {
            this.RazaoSocial = razao;
            this.NomeFantasia = nome;
            this.Cnpj = cnpj;
            this.Endereco = endereco;
            this.Produtos.Add(produto);
        }

        public override string ToString() {
            string toString;
            toString = "Razão Social: " + RazaoSocial;
            toString += " Nome: " + NomeFantasia;
            toString += " CNPJ: " + Cnpj;
            toString += " Produtos: " + Produtos;
            return toString;
        }

    }
}
