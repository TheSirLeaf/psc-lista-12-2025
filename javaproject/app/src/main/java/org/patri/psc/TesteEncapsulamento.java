package org.patri.psc;

public class TesteEncapsulamento {
    public static void main(String[] args) {
        // 1. Criar nova instância
        ContaBancaria conta = new ContaBancaria();

        // 2. Tentativa de acesso direto (comentado para manter compilação)
        // As linhas abaixo causariam erro de compilação porque os atributos são privados:
        // conta.saldo = 500; // erro: saldo tem acesso privado
        // System.out.println(conta.saldo);

        System.out.println("Tentativa de acesso direto mostrada como comentário (causaria erro de compilação).\n");

        // 3. Usar setters para inicializar numeroConta e titular
        conta.setNumeroConta("12345-6");
        conta.setTitular("João Silva");

        System.out.println("Conta: " + conta.getNumeroConta() + " - Titular: " + conta.getTitular() + "\n");

        // 4. Testar depositar() e sacar()
        System.out.println("Tentativa de depósito válido de 1000:");
        conta.depositar(1000);

        System.out.println("Tentativa de depósito inválido (-50):");
        conta.depositar(-50);

        System.out.println("Tentativa de saque válido de 200:");
        conta.sacar(200);

        System.out.println("Tentativa de saque inválido (valor maior que saldo):");
        conta.sacar(10000);

        // 5. Usar getter de saldo para imprimir saldo final
        System.out.printf("\nSaldo final (via getter): R$ %.2f%n", conta.getSaldo());
    }
}
