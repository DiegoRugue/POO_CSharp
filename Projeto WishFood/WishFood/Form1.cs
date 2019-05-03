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
    public partial class Form1 : Form {

        public List<Usuario> usuarios = new List<Usuario>();
        public List<Produto> produtos = new List<Produto>();

        public Form1() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            FormCadastrar cadastrar = new FormCadastrar(this);
            cadastrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            bool logado = false;
            try {
                string login = textoEmail.Text;
                string senha = textoSenha.Text;

                foreach (Usuario u in usuarios) {
                    if (u.Email == login && u.Senha == senha) {
                        if (u is Logista) {
                            logado = true;
                            FormLogista logista = new FormLogista(u, this);
                            logista.ShowDialog();
                        } else {
                            logado = true;
                            FormCliente cliente = new FormCliente(u, this);
                            cliente.ShowDialog();
                        }
                        
                    }
                }
                if (!logado) {
                    MessageBox.Show("Usuario ou senha incorretos");
                }

            } catch(Exception) {
                MessageBox.Show("Preemcha os campos corretamente");
            }

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
