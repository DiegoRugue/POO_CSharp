using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WishFood.Estabelecimentos;
using WishFood.Produtos;
using WishFood.Usuarios;

namespace WishFood {
    public partial class FormCadastroEstabelecimento : Form {
        private Logista logista;
        public FormCadastroEstabelecimento(Logista logista) {
            this.logista = logista;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                Estabelecimento estabelecimento = new Estabelecimento();
                estabelecimento.RazaoSocial = textoRazao.Text;
                estabelecimento.NomeFantasia = textoNome.Text;
                estabelecimento.Cnpj = textoCNPJ.Text;
                estabelecimento.Endereco = logista.Endereco;

                logista.Estabelecimento = estabelecimento;

                logista.Estabelecimento.Produtos = new List<Produto>();

                MessageBox.Show("Estabelecimento cadastrado com sucesso");
                this.Hide();
            } catch {
                MessageBox.Show("Preencha os campos corretamente");
            }
            
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
