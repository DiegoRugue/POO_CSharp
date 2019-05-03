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

namespace WishFood {
    public partial class FormCadastrar : Form {

        private Form1 formPrincipal;

        public FormCadastrar(Form1 formPrincipal) {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

       

        private void FormCadastrar_Load(object sender, EventArgs e) {
            comboConta.Items.Add("Cliente");
            comboConta.Items.Add("Lojista");
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                string tipoConta = (string)comboConta.SelectedItem;
                string rua = textoRua.Text;
                int numero = Convert.ToInt32(textoNumero.Text);
                string bairro = textoBairro.Text;
                int cep = Convert.ToInt32(textoCep.Text);
                string complemento = textoComplemento.Text;
                string cidade = textoCidade.Text;
                string estado = textoEstado.Text;
                bool cadastrado = false;

                Endereco endereco = new Endereco(rua, numero, bairro, cep, complemento, cidade, estado);

                foreach (Usuario user in formPrincipal.usuarios) {
                    if (textoEmail.Text == user.Email) {
                        cadastrado = true;
                    }
                }

                if (tipoConta == "Cliente" && !cadastrado) {
                    Cliente cliente = new Cliente();

                    cliente.Nome = textoNome.Text;
                    cliente.Cpf = textoCpf.Text;
                    cliente.Email = textoEmail.Text;
                    cliente.Telefone = textoTelefone.Text;
                    cliente.Senha = textoSenha.Text;
                    cliente.Endereco = endereco;

                    this.formPrincipal.usuarios.Add(cliente);

                } else if (tipoConta == "Lojista" && !cadastrado) {
                    Logista cliente = new Logista();

                    cliente.Nome = textoNome.Text;
                    cliente.Cpf = textoCpf.Text;
                    cliente.Email = textoEmail.Text;
                    cliente.Telefone = textoTelefone.Text;
                    cliente.Senha = textoSenha.Text;
                    cliente.Endereco = endereco;

                    this.formPrincipal.usuarios.Add(cliente);

                }

                if (cadastrado) {
                    MessageBox.Show("Usuario já cadastrado");
                } else {
                    MessageBox.Show("Conta Cadastrada com Sucesso");
                    this.Hide();
                }
            } catch (Exception) {
                MessageBox.Show("Preencha os campos corretamente");
            }
            
        }

        private void comboConta_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
