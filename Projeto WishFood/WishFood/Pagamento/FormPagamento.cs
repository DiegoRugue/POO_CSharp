using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WishFood.Pagamento;

namespace WishFood {
    public partial class FormPagamento : Form {
        FormCarrinho carrinho;
        public FormPagamento(FormCarrinho c) {
            this.carrinho = c;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {

            try {
                MetodoPagamento pagamento = new MetodoPagamento();

                pagamento.NomeCartao = textoNome.Text;
                pagamento.Numero = Convert.ToInt32(textoNumero.Text);
                pagamento.DataVencimento = textoData.Text;

                carrinho.cliente.carrinho.Pagamento = pagamento;
                MessageBox.Show("Pagamento adicionado com sucesso");
                this.Hide();
            } catch {
                MessageBox.Show("Preencha os campos corretamente");
            }
            

        }
    }
}
