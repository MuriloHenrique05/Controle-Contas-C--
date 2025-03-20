using System;

namespace controleContas
{
    class Conta
    {
        private long numero;
        public long Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        private decimal saldo;
        public decimal Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        private Cliente titular;
        public Cliente Titular
        {
            get { return this.titular; }
            set { this.titular = value; }
        }
        public Conta(int numero)
        {
            if (numero < 9999)
                throw new System.ArgumentException("O número da conta deve ser superior a 999!");
            this.Numero = numero;
        }
        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }
        public bool Sacar(decimal valor)
        {
            if ((Saldo - (valor - 0.1m) < 0))
            {
                return false;
            }
            this.Saldo -= (valor + 0.1m);
            return true;
        }

        public bool Transferir(Conta destino, decimal valor)
        {
            if (Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}