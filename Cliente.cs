using System;

namespace controleContas
{
    class Cliente
    {

        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private string email;
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        private int anonascimento;
        public int AnoNascimento
        {
            get { return this.anonascimento; }
            set { this.anonascimento = value; }
        }

        private string cpf;
        public string Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        private List<Conta> contas;
        public List<Conta> Contas
        {
            get { return this.contas; }
            set { this.contas = value; }
        }

        public Cliente(string nome, int anonascimento, string cpf)
        {
            if (Int32.Parse(DateTime.Now.ToString("yyyy")) - anonascimento < 18)
                throw new System.ArgumentException("O Cliente deve ter mais de 18 anos!!");
            if (cpf.Length != 11)
                throw new System.ArgumentException("O CPF deve possuir 11 digitos");

            this.Nome = nome;
            this.AnoNascimento = anonascimento;
            this.Cpf = cpf;
        }
    }
}