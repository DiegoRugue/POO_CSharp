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
    public partial class FormNovoEndereco : Form {
        private FormCarrinho formCarrinho;
        public FormNovoEndereco(FormCarrinho c) {
            formCarrinho = c;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                string rua = textoRua.Text;
                int numero = Convert.ToInt32(textoNumero.Text);
                string bairro = textoBairro.Text;
                int cep = Convert.ToInt32(textoCep.Text);
                string complemento = textoComplemento.Text;
                string cidade = textoCidade.Text;
                string estado = textoEstado.Text;

                Endereco endereco = new Endereco(rua, numero, bairro, cep, complemento, cidade, estado);
                formCarrinho.comboEndereco.Items.Add(endereco);

                MessageBox.Show("Endereço adicionado com sucesso!");
                this.Hide();
            } catch {
                MessageBox.Show("Preencha os campos corretamente");
            }
            
        }
    }
}
