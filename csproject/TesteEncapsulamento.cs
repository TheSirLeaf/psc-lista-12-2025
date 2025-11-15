using System;
using csproject.Models;

namespace csproject
{
    class TesteEncapsulamento
    {
        static void Main(string[] args)
        {
            // 1. Criar nova instância
            var conta = new ContaBancaria();

            // 2. Tentativa de acesso direto (comentado para manter compilação)
            // Essas linhas causariam erro de compilação porque os atributos são privados:
            // conta.saldo = 500; // erro: 'ContaBancaria.saldo' inacessível devido ao seu nível de proteção
            // Console.WriteLine(conta.saldo);

            Console.WriteLine("Tentativa de acesso direto mostrada como comentário (causaria erro de compilação).\n");

            // 3. Usar propriedades (setters) para inicializar numeroConta e titular
            conta.NumeroConta = "12345-6";
            conta.Titular = "João Silva";

            Console.WriteLine($"Conta: {conta.NumeroConta} - Titular: {conta.Titular}\n");

            // 4. Testar depositar() e sacar()
            Console.WriteLine("Tentativa de depósito válido de 1000:");
            conta.depositar(1000);

            Console.WriteLine("Tentativa de depósito inválido (-50):");
            conta.depositar(-50);

            Console.WriteLine("Tentativa de saque válido de 200:");
            conta.sacar(200);

            Console.WriteLine("Tentativa de saque inválido (valor maior que saldo):");
            conta.sacar(10000);

            // 5. Usar getter de saldo para imprimir saldo final
            Console.WriteLine($"\nSaldo final (via getter): R$ {conta.Saldo:F2}");
        }
    }
}
