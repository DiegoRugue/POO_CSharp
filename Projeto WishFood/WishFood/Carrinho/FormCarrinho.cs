using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WishFood.Produtos;
using WishFood.Usuarios;

namespace WishFood {
    public partial class FormCarrinho : Form {
        private double totalPagar;
        public FormCliente cliente;
        public FormCarrinho(FormCliente c) {
            this.cliente = c;
            InitializeComponent();
        }

        private void FormCarrinho_Load(object sender, EventArgs e) {
            foreach (Produto p in cliente.carrinho.ProdutosCarrinho) {
                listaProdutos.Items.Add(p);
            }

            comboEndereco.Items.Add(cliente.cliente.Endereco);

            foreach (Produto p in cliente.carrinho.ProdutosCarrinho) {
                totalPagar += p.Preco;
            }

            textoValor.Text += " R$: " + totalPagar;

        }

        private void button3_Click(object sender, EventArgs e) {
            if (cliente.carrinho.Pagamento != null && comboEndereco.Text != "") {
                foreach (Produto produto in cliente.carrinho.ProdutosCarrinho) {
                    if (produto.Quantidade > 0) {
                        produto.Quantidade--;
                    } else {
                        MessageBox.Show("Estoque indisponivel");
                        break;
                    }
                    
                }

                cliente.carrinho.Endereco = (Endereco) comboEndereco.SelectedItem;

                cliente.listaProduto.Items.Clear();
                listaProdutos.Items.Clear();
                cliente.carrinho.ProdutosCarrinho.Clear();

                foreach (Produto p in cliente.formPrincipal.produtos) {
                    cliente.listaProduto.Items.Add(p);
                }
                MessageBox.Show("Compra realizada com sucesso");
                this.Hide();
            } else {
                MessageBox.Show("Adicione um metodo de pagamento e endereço");
            }
            
        }

        private void button2_Click(object sender, EventArgs e) {
            FormPagamento pagamento = new FormPagamento(this);
            pagamento.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            FormNovoEndereco novoEndereco = new FormNovoEndereco(this);
            novoEndereco.ShowDialog();
        }
    }
}
