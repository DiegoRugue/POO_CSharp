using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishFood.Pagamento;
using WishFood.Produtos;
using WishFood.Usuarios;

namespace WishFood.Carrinhos {
    public class Carrinho {
        public List<Produto> ProdutosCarrinho { get; set; }
        public MetodoPagamento Pagamento { get; set; }
        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }

        public Carrinho() {

        }

        public Carrinho(Produto p, MetodoPagamento pagamento, Cliente cliente) {
            this.ProdutosCarrinho.Add(p);
            this.Pagamento = pagamento;
            this.Cliente = cliente;
        }

        public override string ToString() {
            string toString;
            toString = "Produtos: " + ProdutosCarrinho;
            toString += " Pagamento: " + Pagamento;
            toString += " Cliente: " + Cliente;
            toString += " Endereço: " + Endereco;
            return toString;
        }
    }
}
