using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAgendaCelular {
    internal class Pessoa {


        public string Nome { get; set; }
        public string Telefone { get; set; }

        public  string Email { get; set; }
        public DateTime Aniversario { get; set; }

        public Pessoa() { }


        public Pessoa CadastrarPessoa(string nome, string telefone, string email, DateTime aniver) {
            this.Nome=nome;
            this.Telefone = telefone;
            this.Email = email;
            this.Aniversario= aniver;
            
            return new Pessoa();
        }

        public override string ToString() {
            return "\nNome: "+Nome+"\nTelefone: "+Telefone+"\nEmail: "+Email+"\nAnversario: "+Aniversario.ToShortDateString();
        }
    }
}
