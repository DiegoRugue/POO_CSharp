﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Clientes {
    public class Cliente {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public Cliente(string nome, string cpf, string rg, string endereco, int idade) {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Endereco = endereco;
            this.Idade = idade;
        }

        public Cliente(string nome) {
            this.Nome = nome;
            this.Cpf = null;
            this.Rg = null;
            this.Endereco = null;
            this.Idade = 0;
        }
        
        public bool MaiorIdade() {
            if (Idade >= 18) {
                return true;
            }
            return false;
        }
    }
}
