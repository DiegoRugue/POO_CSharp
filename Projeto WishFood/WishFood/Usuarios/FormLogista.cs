using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WishFood.Usuarios;
using WishFood.Produtos;

namespace WishFood {
    public partial class FormLogista : Form {

        public List<Produto> produtos = new List<Produto>();

        public Logista logista;
        public Form1 formPrincipal;

        public FormLogista(Usuario u, Form1 form) {
            logista = (Logista) u;
            formPrincipal = form;
            InitializeComponent();
        }

        private void LogistaLogado_Load(object sender, EventArgs e) {
            textoNome.Text = this.logista.Nome;
            if (logista.Estabelecimento != null) {
                foreach (Produto p in logista.Estabelecimento.Produtos) {
                    listProduto.Items.Add(p.ToString());

                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (logista.Estabelecimento != null) {
                FormCadastroProduto p = new FormCadastroProduto(this);
                p.ShowDialog();
            } else {
                MessageBox.Show("Cadastre um estabelecimento primeiro!");
            }
               
        }

        private void button4_Click(object sender, EventArgs e) {
            if (logista.Estabelecimento == null) {
                FormCadastroEstabelecimento estabelecimento = new FormCadastroEstabelecimento(logista);
                estabelecimento.ShowDialog();
            }
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
