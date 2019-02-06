using Atividade1POO;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do titular: ");
            var titular = Convert.ToString(Console.ReadLine());

            DateTime dateTime = DateTime.Now;
            ContaPoupanca contaPoupanca = new ContaPoupanca(0.1M, dateTime, titular);

            ContaCorrente contaCorrente = new ContaCorrente(titular);

            while (true)
            {
                Console.WriteLine("############################");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 para Conta Poupança (CP)");
                Console.WriteLine("2 para Conta Corrente (CC)");
                Console.WriteLine("0 para Sair");

                var tipoConta = Convert.ToInt16(Console.ReadLine());

                if (tipoConta == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("############################");
                        Console.WriteLine("Escolha uma opção: ");
                        Console.WriteLine("1 para Sacar");
                        Console.WriteLine("2 para Depositar");
                        Console.WriteLine("3 para Saldo");
                        Console.WriteLine("0 para Voltar");

                        var operacao = Convert.ToInt16(Console.ReadLine());

                        if (operacao == 1)
                        {
                            Console.WriteLine("Informe o valor: ");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaPoupanca.Sacar(valor);
                        }
                        else if (operacao == 2)
                        {
                            Console.WriteLine("Informe o valor: ");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaPoupanca.Depositar(valor);
                        }
                        else if (operacao == 3)
                        {
                            Console.WriteLine($"Titular: {contaPoupanca.Id} / Saldo: {contaPoupanca.Saldo}");
                        }
                        else if (operacao == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida, tente novamente.");
                        }
                    }
                }
                else if (tipoConta == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("############################");
                        Console.WriteLine("Escolha uma opção: ");
                        Console.WriteLine("1 para Sacar");
                        Console.WriteLine("2 para Depositar");
                        Console.WriteLine("3 para Saldo");
                        Console.WriteLine("0 para Sair");

                        var operacao = Convert.ToInt16(Console.ReadLine());

                        if (operacao == 1)
                        {
                            Console.WriteLine("Informe o valor: ");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaCorrente.Sacar(valor);
                        }
                        else if (operacao == 2)
                        {
                            Console.WriteLine("Informe o valor: ");
                            var valor = Convert.ToInt16(Console.ReadLine());
                            contaCorrente.Depositar(valor);
                        }
                        else if (operacao == 3)
                        {
                            Console.WriteLine($"Titular: {contaCorrente.Id} / Saldo: {contaCorrente.Saldo}");
                        }
                        else if (operacao == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida, digite novamente.");
                        }
                    }
                }
                else if (tipoConta == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente.");
                }
            }
        }
    }
}
