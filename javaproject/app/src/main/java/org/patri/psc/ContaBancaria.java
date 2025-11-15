package org.patri.psc;

public class ContaBancaria {
    private String numeroConta = "";
    private String titular = "";
    private double saldo;

    public ContaBancaria() { }

    public ContaBancaria(String numeroConta, String titular, double saldo) {
        setNumeroConta(numeroConta);
        setTitular(titular);
        this.saldo = saldo;
    }

    public String getNumeroConta() {
        return numeroConta;
    }

    public void setNumeroConta(String numeroConta) {
        if (numeroConta == null || numeroConta.trim().isEmpty()) {
            throw new IllegalArgumentException("numeroConta não pode ser nulo ou vazio.");
        }
        this.numeroConta = numeroConta;
    }

    public String getTitular() {
        return titular;
    }

    public void setTitular(String titular) {
        if (titular == null || titular.trim().isEmpty()) {
            throw new IllegalArgumentException("titular não pode ser nulo ou vazio.");
        }
        this.titular = titular;
    }

    // Saldo somente leitura — só pode ser alterado via métodos de transação
    public double getSaldo() {
        return saldo;
    }

    public void depositar(double valor) {
        if (valor <= 0) {
            System.out.println("Valor inválido para depósito. Informe um valor positivo.");
            return;
        }
        saldo += valor;
        System.out.printf("Depósito de R$ %.2f realizado com sucesso. Saldo atual: R$ %.2f%n", valor, saldo);
    }

    public void sacar(double valor) {
        if (valor <= 0) {
            System.out.println("Valor inválido para saque. Informe um valor positivo.");
            return;
        }
        if (valor > saldo) {
            System.out.println("Saldo insuficiente para saque.");
            return;
        }
        saldo -= valor;
        System.out.printf("Saque de R$ %.2f realizado com sucesso. Saldo atual: R$ %.2f%n", valor, saldo);
    }
}
