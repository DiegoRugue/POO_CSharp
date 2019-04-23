using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Apostila {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Hello World");

        }

        private void button2_Click(object sender, EventArgs e) {
            int idadeWill = 20;
            int idadeClayton = 20;
            int idadeRita = 19;
            double media = (idadeWill + idadeClayton + idadeRita) / 3.0;

            MessageBox.Show("A idade media dos meus amigos é de : " + media);

        }

        private void button3_Click(object sender, EventArgs e) {
            int a = 1;
            int b = 10;
            int c = 24;
            double a1 = 0;
            double a2 = 0;
            double delta = b * b - 4 * a * c;

            if (delta >= 0) {
                a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                a2 = (-b - Math.Sqrt(delta)) / (2 * a);

                MessageBox.Show("O valor de x1 é: " + a1 + "\n" + "O valor de x2 é : " + a2);

            } else {
                MessageBox.Show("Delta negativo");

            }
        }

        private void button4_Click(object sender, EventArgs e) {
            int idade = 17;
            bool brasileiro = true;

            if (idade >= 16 && brasileiro) {
                MessageBox.Show("Apto a votar");

            } else {
                MessageBox.Show("Não apto a votar");

            }
        }

        private void button5_Click(object sender, EventArgs e) {
            double valorDaNotaFiscal = 7000;

            if (valorDaNotaFiscal < 999) {
                MessageBox.Show("Imposto de 2%");

            } else if (valorDaNotaFiscal < 2999) {
                MessageBox.Show("Imposto de 2,5%");

            } else {
                MessageBox.Show("Imposto de 2,8%");

            }
        }

        private void button6_Click(object sender, EventArgs e) {
            int valor = 15;
            string menssagem = "";

            menssagem = valor > 10 ? "Maior que dez" : "Menor que dez";

            MessageBox.Show(menssagem);

        }

        private void button7_Click(object sender, EventArgs e) {
            int soma = 0;

            for (int i = 0; i < 1000; i++) {
                soma += i;
            }

            MessageBox.Show("A soma dos numeros de 1 ate 1000 é: " + soma);

        }

        private void button8_Click(object sender, EventArgs e) {
            string multiplos = "";

            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    multiplos += i + ",";
                }
            }

            MessageBox.Show("Os multiplos de 3 de 1 a 100 são: " + multiplos);
        }

        private void button9_Click(object sender, EventArgs e) {
            string multiplos = "";
            for (int i = 0; i <= 30; i++) {
                if (i % 3 == 0 || i % 4 == 0) {
                    multiplos += i + ",";
                }
            }
            MessageBox.Show("Os multiplos de 3 e 4 de 0 a 30 são: " + multiplos);
        }

        private void button10_Click(object sender, EventArgs e) {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++) {
                fatorial *= n;
                MessageBox.Show("Fatorial de " + n + ": " + fatorial );
            }
        }

        private void button11_Click(object sender, EventArgs e) {
            int a = 0;
            int b = 1;
            int c = 0;
            string soma = "";
            while (a < 100) {
                a += b;
                b = c;
                c = a;
                
                soma += a + ",";
            }  
            MessageBox.Show("Os primeiros elementos da sequencia de fibbonacci ate > 100: " + soma);
        }

        private void button12_Click(object sender, EventArgs e) {
            string result = "";
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < i; j++) {
                    if (j != 0) {
                        result += ((j + 1) * i) + " ";
                    } else {
                        result += i + " ";
                    }
                    
                }
                result += "\n";
            }
            MessageBox.Show(result);
        }

        private void button13_Click(object sender, EventArgs e) {
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();

            conta1.titular = "Diego";
            conta1.numero = 1;
            conta1.saldo = 100.0;
            conta1.idade = 21;

            conta2.titular = "Carlos";
            conta2.numero = 2;
            conta2.saldo = 200;
            conta2.idade = 17;

            MessageBox.Show("Titular: " + conta1.titular);
            conta1.Depositar(200);
            MessageBox.Show("Saldo: " + conta1.saldo);

            if (conta1.Sacar(150)) {
                MessageBox.Show("Saque realizado com sucesso");
            } else {
                MessageBox.Show("Saldo insuficiente");
            }

            MessageBox.Show("Saldo: " + conta1.saldo);

            conta1.Transferir(50, conta2);

            MessageBox.Show(conta1.titular + ": " + conta1.saldo);
            MessageBox.Show(conta2.titular + ": " + conta2.saldo);

            if (conta2.Sacar(250)) {
                MessageBox.Show("Saque realizado com sucesso");
            } else {
                MessageBox.Show("Saldo insuficiente");
            }
            
        }
    }
}
