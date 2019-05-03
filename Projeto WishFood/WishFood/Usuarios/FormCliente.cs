using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WishFood.Carrinhos;
using WishFood.Produtos;
using WishFood.Usuarios;

namespace WishFood {
    public partial class FormCliente : Form {
        public Usuario cliente;
        public Form1 formPrincipal;
        public Carrinho carrinho;
        public FormCliente(Usuario u, Form1 form) {
            this.cliente = u;
            this.formPrincipal = form;
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e) {
            textoNome.Text += cliente.Nome;

            foreach (Produto p in formPrincipal.produtos) {
                listaProduto.Items.Add(p);
            }

            carrinho = new Carrinho();
            carrinho.Cliente = (Cliente) cliente;
            carrinho.ProdutosCarrinho = new List<Produto>();

        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) {
            FormCarrinho carrinho = new FormCarrinho(this);
            carrinho.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            Produto p = (Produto) listaProduto.SelectedItem;
            if (p != null) {
                carrinho.ProdutosCarrinho.Add(p);
                MessageBox.Show("Produto adicionado com sucesso");
            }
        }
    }
}
