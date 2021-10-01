using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionarioRafael = new Funcionario();
            funcionarioRafael.Nome = "Rafael";
            funcionarioRafael.CPF = "222.111.333.55";
            funcionarioRafael.Cargo = "Auxiliar";
            funcionarioRafael.Salario = 1500.00;

            Funcionario funcionarioSamuel = new Funcionario();
            funcionarioSamuel.Nome = "Samuel";
            funcionarioSamuel.CPF = "111.222.333.44";
            funcionarioSamuel.Cargo = "Vendedor";
            funcionarioSamuel.Salario = 1000.00;

            ContaCorrente Tulio = new ContaCorrente("Tulio", 1234, 3000, funcionarioSamuel);
            Tulio.Conta = 950;
            ContaCorrente Gabriel = new ContaCorrente("Gabriel", 1234, 800, funcionarioRafael);
            Gabriel.Conta = 500;
            ContaCorrente Diogo = new ContaCorrente("Diogo", 1234, 1000, funcionarioSamuel);
            Diogo.Conta = 860;
            ContaCorrente Matheus = new ContaCorrente("Matheus", 1234, 2500, funcionarioRafael);
            Matheus.Conta = 740;

            Console.WriteLine("O titular da conta é o: " + Tulio.Titular);
            Console.WriteLine("O titular da conta é o: " + Gabriel.Titular);
            Console.WriteLine("O titular da conta é o: " + Diogo.Titular);
            Console.WriteLine("O saldo da conta do Tulio é: " + Tulio.Saldo);

            Console.WriteLine("A comissao do Vendedor Fábio é: " + funcionarioSamuel.Comissao);
            Console.WriteLine("A comissao do Vendedor Rafael é: " + funcionarioRafael.Comissao);

            Tulio.Sacar(200);
            Console.WriteLine("Seu saldo após o saque de R$200,00 é: " + Tulio.Saldo);
            Tulio.Depositar(150);
            Console.WriteLine("Seu saldo após o deposito de R$150,00 é: " + Tulio.Saldo);
            Tulio.Transferir(100, Matheus);
            Console.WriteLine("Seu saldo após a transferência de R$100,00 é: " + Tulio.Saldo);

            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}