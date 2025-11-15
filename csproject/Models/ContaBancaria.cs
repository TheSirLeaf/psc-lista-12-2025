using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csproject.Models
{
    public class ContaBancaria
    {
        private string numeroConta = string.Empty;
        private string titular = string.Empty;
        private double saldo;

        public ContaBancaria() { }

        public ContaBancaria(string numeroConta, string titular, double saldo)
        {
                NumeroConta = numeroConta;
                Titular = titular;
                this.saldo = saldo;
        }

        public string NumeroConta
        {
                get => numeroConta;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("numeroConta não pode ser nulo ou vazio.", nameof(value));
                    numeroConta = value;
                }
        }

        public string Titular
        {
                get => titular;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("titular não pode ser nulo ou vazio.", nameof(value));
                    titular = value;
                }
        }

            public double Saldo => saldo;

            public void depositar(double valor)
            {
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido para depósito. Informe um valor positivo.");
                    return;
                }

                saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso. Saldo atual: R$ {saldo:F2}");
            }

            // Método para sacar — só permite saque se valor positivo e suficiente saldo
            public void sacar(double valor)
            {
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido para saque. Informe um valor positivo.");
                    return;
                }

                if (valor > saldo)
                {
                    Console.WriteLine("Saldo insuficiente para saque.");
                    return;
                }

                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso. Saldo atual: R$ {saldo:F2}");
            }
    }
}