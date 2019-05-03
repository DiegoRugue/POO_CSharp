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
using Banco.Tributaveis;

namespace Bank {
    public partial class Form1 : Form {

        private List<Conta> contas = new List<Conta>();
        private Dictionary<string, Conta> dicionario;
        private Conta selecionada;
        private Conta transferencia;
        private TotalizadorDeTributos tributos = new TotalizadorDeTributos();

        public void AdicionaConta(Conta conta) {
            contas.Add(conta);
            comboContas.Items.Add(conta);
            comboTransfere.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
        }
        //private TotalizadorDeContas saldoTotal;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.dicionario = new Dictionary<string, Conta>();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (comboContas.SelectedItem != null && textoValor.Text != "") {
                double valorDigitado = Convert.ToDouble(textoValor.Text);
                try {
                    this.selecionada.Depositar(valorDigitado);
                    textoSaldo.Text = Convert.ToString(this.selecionada.Saldo);
                    textoValor.Text = "";
                    MessageBox.Show("Deposito realizado com sucesso");

                } catch (Exception ex) {
                    MessageBox.Show(Convert.ToString(ex));
                }
            } else {
                MessageBox.Show("Preencha os campos corretamente!");
            }           

        }

        private void Button2_Click(object sender, EventArgs e) {
            if (comboContas.SelectedItem != null && textoValor.Text != "" && textoValor.Text != "0") {
                double valorDigitado = Convert.ToDouble(textoValor.Text);

                try {
                    this.selecionada.Sacar(valorDigitado);
                    textoSaldo.Text = Convert.ToString(this.selecionada.Saldo);
                    textoValor.Text = "";
                    MessageBox.Show("Saque realizado com sucesso");
                } catch (Exception ex) {
                    MessageBox.Show(Convert.ToString(ex));
                }
            } else {
                MessageBox.Show("Preencha os campos corretamente!");
            }
        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = comboContas.SelectedIndex;

            this.selecionada = this.contas[indice];

            textoTipo.Text = this.selecionada.Tipo;
            textoTitular.Text = this.selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(this.selecionada.Saldo);
            textoNumero.Text = Convert.ToString(this.selecionada.Numero);
        }

        private void comboTransfere_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = comboTransfere.SelectedIndex;

            this.transferencia = this.contas[indice];
                  
        }

        private void button3_Click(object sender, EventArgs e) {
            if (comboContas.SelectedItem != null && textoValor.Text != "" && comboTransfere.SelectedItem != null) {
                double valorDigitado = Convert.ToDouble(textoValor.Text);
                try {
                    Conta.Transferir(valorDigitado, selecionada, transferencia);
                    textoValor.Text = "";
                    MessageBox.Show("Transferencia realizada com sucesso");
                    textoSaldo.Text = Convert.ToString(this.selecionada.Saldo);
                } catch (Exception ex) {
                    MessageBox.Show(Convert.ToString(ex));
                }
            } else {
                MessageBox.Show("Preencha os campos corretamente!");
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            FormCadastrar cadastro = new FormCadastrar(this);
            cadastro.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) {
            foreach (Conta conta in contas) {
                if (conta.Tipo is "Conta Corrente") {
                    ContaCorrente teste = (ContaCorrente)conta;
                    try {
                        this.tributos.Adiciona(teste);
                        if (conta.Saldo > 0) {
                            conta.Sacar((conta.Saldo * 0.05) - 0.05);
                        }
                        
                    } catch (Exception ex) {
                        MessageBox.Show(Convert.ToString(ex));
                    }
                    

                }
            }
            if (comboContas.SelectedItem != null ) {
                textoSaldo.Text = Convert.ToString(this.selecionada.Saldo);
            }
            MessageBox.Show("Imposto total: " + this.tributos.Total);
        }

        private void Button6_Click(object sender, EventArgs e) {
            string nomeTitular = textoBuscaTitular.Text;
            try {
                Conta conta = dicionario[nomeTitular];
                comboContas.SelectedItem = conta;
                textoBuscaTitular.Text = "";
            } catch (Exception) {
                MessageBox.Show("Usuario não existe");
            }

        }

        private void Button7_Click(object sender, EventArgs e) {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
    }
}
