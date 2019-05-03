using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WishFood.Usuarios {
    public abstract class Usuario {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
        

        public Usuario() {

        }

        public Usuario(string nome, string cpf, string email, string telefone, string senha, Endereco endereco) {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Endereco = endereco;
        }

        public override string ToString() {
            string toString;
            toString = "Produtos: " + Nome;
            toString += " Pagamento: " + Cpf;
            toString += " Cliente: " + Email;
            toString += " Endereço: " + Telefone;
            toString += " Senha: " + Senha;
            toString += " Endereço: " + Endereco;
            return toString;
        }
    }
}
