using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
Gerente gerenteMatheus = new Gerente()
            {
               Nome = "Matheus",
               CPF = "987.654.321-00",
               Salario = 3000.00,
               NumeroDeAgencias = 1,
            };

            Vendedor vendedorMarco = new Vendedor()
            {
                Nome = "Marco",
                CPF = "400.289.220-44",
                Salario = 1400.00,
                NumeroDeClientesAtendidos = 1,
            };

            Vendedor vendedorJv = new Vendedor()
            {
                Nome = "Jõao Vitor",
                CPF = "456.456.456-56",
                Salario = 1400.00,
                NumeroDeClientesAtendidos = 1,
            };

            Vendedor vendedorNeco = new Vendedor()
            {
                Nome = "Neco Torcinco",
                CPF = "444.444.444-56",
                Salario = 1400.00,
                NumeroDeClientesAtendidos = 4,
            };

        vendedorJv.Bonificacao = vendedorJv.Salario;
        vendedorMarco.Bonificacao = vendedorMarco.Salario;
        vendedorNeco.Bonificacao = vendedorNeco.Salario;
        gerenteMatheus.Bonificacao = gerenteMatheus.Salario;

            ContaCorrente contaDoTulio = new ContaCorrente("Túlio Henrique Gonçalves Simões", 1234, 4000.00, vendedorJv);
            contaDoTulio.Conta = 321;
            ContaCorrente contaDoAndre = new ContaCorrente("André", 1234, 1387.40, vendedorMarco);
            contaDoAndre.Conta = 740;
            ContaCorrente contaDoRafael = new ContaCorrente("Rafael", 1234, 1650.90, vendedorNeco);
            contaDoRafael.Conta = 990;

            Console.WriteLine("O titular da conta é: " + contaDoTulio.Titular);
            Console.WriteLine("O titular da conta é: " + contaDoAndre.Titular);
            Console.WriteLine("O titular da conta é: " + contaDoRafael.Titular);

            Console.WriteLine("O vendedor é : " + vendedorJv.Nome);
            Console.WriteLine("O vendedor é : " + vendedorMarco.Nome);
            Console.WriteLine("O vendedor é : " + vendedorNeco.Nome);
            Console.WriteLine("O gerente é : " + gerenteMatheus.Nome);

            Console.WriteLine("A bonificação do vendedor " + vendedorJv.Nome + " é: " + vendedorJv.Bonificacao);
            Console.WriteLine("A bonificação do vendedor " + vendedorMarco.Nome + " é: " + vendedorMarco.Bonificacao);
            Console.WriteLine("A bonificação do vendedor " + vendedorNeco.Nome + " é: " + vendedorNeco.Bonificacao);
            Console.WriteLine("A bonificação do gerente " + gerenteMatheus.Nome + " é: " + gerenteMatheus.Bonificacao);

            Console.WriteLine("A remuneração total do vendedor " + vendedorJv.Nome + " é: " + vendedorJv.RemuneracaoTotal(vendedorJv.Salario, vendedorJv.Bonificacao));
            Console.WriteLine("A remuneração total do vendedor " + vendedorMarco.Nome + " é: " + vendedorMarco.RemuneracaoTotal(vendedorMarco.Salario, vendedorMarco.Bonificacao)); 
            Console.WriteLine("A remuneração total do vendedor " + vendedorNeco.Nome + " é: " + vendedorNeco.RemuneracaoTotal(vendedorNeco.Salario, vendedorNeco.Bonificacao));   
            Console.WriteLine("A remuneração total do gerente " + gerenteMatheus.Nome + " é: " + gerenteMatheus.RemuneracaoTotal(gerenteMatheus.Salario, gerenteMatheus.Bonificacao));      

            Console.WriteLine("O gerente terá: " + gerenteMatheus.CalcularFerias() + " dias de ferias.");
            Console.WriteLine("O vendedor terá: " + vendedorJv.CalcularFerias() + " dias de ferias.");
            Console.WriteLine("O total de contas criadas é: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}