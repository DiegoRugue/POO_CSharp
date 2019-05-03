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
    public partial class FormCadastroProduto : Form {
        private FormLogista formLogista;
        public FormCadastroProduto(FormLogista logista) {
            this.formLogista = logista;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Produto produto = new Produto();
                produto.Nome = textoNome.Text;
                produto.Preco = Convert.ToDouble(textoPreco.Text);
                produto.Quantidade = Convert.ToInt32(textoQuant.Text);
                produto.UnidadeMedida = textoUnidade.Text;

                formLogista.logista.Estabelecimento.Produtos.Add(produto);
                formLogista.listProduto.Items.Add(produto.ToString());
                formLogista.formPrincipal.produtos.Add(produto);
                
                MessageBox.Show("Produto cadastrado com sucesso");
                this.Hide();
            } catch {
                MessageBox.Show("Preencha os campos corretamente");
            }
            
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
