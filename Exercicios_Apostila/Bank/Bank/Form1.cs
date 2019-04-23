using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank {
    public partial class Form1 : Form {
        private Conta contaDiego;
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            
        }

        private void Form1_Load(object sender, EventArgs e) {
            Cliente diego = new Cliente("Diego");
            this.contaDiego = new Conta(diego, 1, 150);

            titularText.Text = Convert.ToString(contaDiego.Titular.Nome);
            numeroText.Text = Convert.ToString(contaDiego.Numero);
            saldoText.Text = Convert.ToString(contaDiego.Saldo);
        
        }

        private void button1_Click_1(object sender, EventArgs e) {
            double valorDigitado = Convert.ToDouble(valorText.Text);
            this.contaDiego.Depositar(valorDigitado);
            saldoText.Text = Convert.ToString(contaDiego.Saldo);

        }
    }
}
