using System;

namespace controleContas
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                int opcao = 0;
                Conta contacorrente = null;
                Conta contapoupanca = null;
                Cliente cliente1 = null;

                while (opcao != 5)
                {
                    Console.WriteLine("|--------'Bem Vindo ao Menu'--------|");
                    Console.WriteLine("|Opção 1 Cadastrar Contas/Clientes  |");
                    Console.WriteLine("|Opção 2 Depositar                  |");
                    Console.WriteLine("|Opção 3 Sacar                      |");
                    Console.WriteLine("|Opção 4 Transferir Contas/Clientes |");
                    Console.WriteLine("|Sair  5                            |");
                    Console.WriteLine("|-----------------------------------|");
                    Console.WriteLine("Escolha a Opção de 1 ao 5");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.WriteLine("Para Cadastrar Digite o Numero da Conta-Corrente:  ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Para Cadastrar Digite o Numero da Conta-Poupança:  ");
                        int numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Seu Nome:  ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite a Data de Nascimento (ano):  ");
                        int anonascimento = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o seu CPF: ");
                        string cpf = Console.ReadLine();

                        // Criando as contas e o cliente
                        contacorrente = new Conta(numero);
                        contapoupanca = new Conta(numero1);
                        cliente1 = new Cliente(nome, anonascimento, cpf);

                        // Associando as contas ao cliente
                        contacorrente.Titular = cliente1;
                        contapoupanca.Titular = cliente1;

                        Console.WriteLine("Contas e cliente cadastrados com sucesso!");
                    }
                    else if (opcao == 2)
                    {
                        if (contacorrente == null || contapoupanca == null)
                        {
                            Console.WriteLine("Por favor, cadastre as contas primeiro (Opção 1).");
                        }
                        else
                        {
                            Console.WriteLine("Digite o valor para depósito na conta corrente: ");
                            decimal valor = Convert.ToDecimal(Console.ReadLine());
                            contacorrente.Depositar(valor);

                            Console.WriteLine("Digite o valor para depósito na conta poupança: ");
                            valor = Convert.ToDecimal(Console.ReadLine());
                            contapoupanca.Depositar(valor);

                            Console.WriteLine("Depósitos realizados com sucesso!");
                            Console.WriteLine("Saldo da conta corrente: {0}", contacorrente.Saldo);
                            Console.WriteLine("Saldo da conta poupança: {0}", contapoupanca.Saldo);
                        }
                    }
                    else if (opcao == 3)
                    {
                        if (contacorrente == null || contapoupanca == null)
                        {
                            Console.WriteLine("Por favor, cadastre as contas primeiro (Opção 1).");
                        }
                        else
                        {
                            Console.WriteLine("Digite o valor para saque na conta corrente: ");
                            decimal valor = Convert.ToDecimal(Console.ReadLine());
                            contacorrente.Sacar(valor);

                            Console.WriteLine("Digite o valor para saque na conta poupança: ");
                            valor = Convert.ToDecimal(Console.ReadLine());
                            contapoupanca.Sacar(valor);

                            Console.WriteLine("Saque(s) realizado(s) com sucesso!");
                            Console.WriteLine("Saldo da conta corrente: {0}", contacorrente.Saldo);
                            Console.WriteLine("Saldo da conta poupança: {0}", contapoupanca.Saldo);
                        }
                    }
                    else if (opcao == 4)
                    {
                        if (contacorrente == null || contapoupanca == null)
                        {
                            Console.WriteLine("Por favor, cadastre as contas primeiro (Opção 1).");
                        }
                        else
                        {
                            Console.WriteLine("Digite o valor para transferir da conta corrente para a poupança: ");
                            decimal valor = Convert.ToDecimal(Console.ReadLine());

                            bool sucesso = contacorrente.Transferir(contapoupanca, valor);

                            if (sucesso)
                            {
                                Console.WriteLine("Transferência realizada com sucesso!");
                                Console.WriteLine("Saldo da conta corrente: {0}", contacorrente.Saldo);
                                Console.WriteLine("Saldo da conta poupança: {0}", contapoupanca.Saldo);
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente para realizar a transferência.");
                            }
                        }
                    }
                    else if (opcao == 5)
                    {
                        if (contacorrente != null && contapoupanca != null)
                        {
                            Console.WriteLine("O cliente da conta {0} é {1}", contacorrente.Numero, contacorrente.Titular.Nome);
                            Console.WriteLine("O cliente da conta {0} é {1}", contapoupanca.Numero, contapoupanca.Titular.Nome);
                        }
                        else
                        { 
                            Console.WriteLine("Contas não cadastradas. Por favor, cadastre as contas primeiro (Opção 1)."); 5
                        } 
                    } 
                    else 
                    { 
                        Console.WriteLine("Opção inválida! Tente novamente."); 5
                    } 
                } 
            } 
            catch (Exception e) 
            { 
            } 
    } 
} 
}