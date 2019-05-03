using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;

namespace Bank {
    public partial class FormRelatorios : Form {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas) {
            InitializeComponent();
            this.contas = contas;
        }

        private void FormRelatorios_Load(object sender, EventArgs e) {

        }

        private void Button1_Click(object sender, EventArgs e) {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Saldo > 500
                            orderby c.Titular.Nome descending, c.Numero
                            select new { c.Titular.Nome, c.Saldo};
            foreach (var c in resultado) {
                listaResultado.Items.Add(c.Nome);
            }

            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);

        }

        private void Button2_Click(object sender, EventArgs e) {
            listaResultado.Items.Clear();
            var resultado = from c in contas
                            where c.Saldo > 500 && c.Numero <= 10
                            orderby c.Titular.Nome descending, c.Numero
                            select new { c.Titular.Nome, c.Saldo };
            foreach (var c in resultado) {
                listaResultado.Items.Add(c.Nome);
            }

            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);
        }
    }
}
