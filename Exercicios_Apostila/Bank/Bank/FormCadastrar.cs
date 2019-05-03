using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Clientes;
using Banco.Contas;
using Banco.Busca;


namespace Bank {
    public partial class FormCadastrar : Form {

        private Form1 formPrincipal;

        private ICollection<string> devedores;

        public FormCadastrar(Form1 formPrincipal) {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textoTitular.Text != "" && comboTipo.SelectedItem != null) {
                int tipoConta = comboTipo.SelectedIndex;

                string titular = this.textoTitular.Text;
                bool ehDevedor = false;
                for (int i = 0; i < 30000; i++) {
                    ehDevedor = this.devedores.Contains(titular);
                }
                if (!ehDevedor) {
                    if (tipoConta == 0) {
                        Conta novaConta = new ContaCorrente();
                        novaConta.Titular = new Cliente(textoTitular.Text);
                        textoNumero.Text = Convert.ToString(novaConta.Numero);
                        this.formPrincipal.AdicionaConta(novaConta);
                    } else {
                        Conta novaConta = new ContaPoupanca();
                        novaConta.Titular = new Cliente(textoTitular.Text);
                        textoNumero.Text = Convert.ToString(novaConta.Numero);
                        this.formPrincipal.AdicionaConta(novaConta);
                    }
                } else {
                    MessageBox.Show("devedor");
                }
                this.Hide();
            } else {
                MessageBox.Show("Preencha os campos corretamente");
            }
            
        }


        private void FormCadastrar_Load(object sender, EventArgs e) {
            comboTipo.Items.Add("Conta Corrente");
            comboTipo.Items.Add("Conta Poupança");
            textoNumero.Text = Convert.ToString(Conta.ProximaConta());
        }
    }
}
