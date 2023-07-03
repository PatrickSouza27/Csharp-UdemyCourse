using System;
using System.Globalization;

namespace ExercicioDeFic
{
    class ContaBancaria
    {
        private string? _nome;
        public double Saldo { get; private set; }
        public int Conta { get; private set; }

        public ContaBancaria(string nome, int conta)
        {
            _nome = nome;
            Conta = conta;
        }

        public ContaBancaria(string nome, int conta, double saldo):this(nome, conta)
        {
            if (saldo > 0)
            {
                Deposito(saldo);
            }
        }
    
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double deposito)
        {
            Saldo +=  deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return ($"Dados da Conta Atualizados:\nConta {Conta}, Titular: {_nome}, Saldo: ${Saldo.ToString("f2", CultureInfo.InvariantCulture)}");
        }
    }
}
