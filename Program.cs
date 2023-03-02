

using System;

namespace Conta
{
    public class Conta
    {
        double saldo;
        int numero;
        double ValorDeposito;
        double ValorSaque;

        public Conta() {
            double saldo = 0;
        }

        public Conta(int numero, double saldo) { }

        public Conta(int numero) {
            double saldo = 0;
        }

        public void depositar(double saldo, double ValorDeposito) {
            saldo = saldo + ValorDeposito;
        }

        public bool Sacar(double saldo, double Valor)
        {
            if (Valor > saldo)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static void Main(double saldo)
        {
            Console.WriteLine("Digite o numero da sua conta");

            string numero = Console.ReadLine();
            Console.WriteLine("Bem vindo dono da conta : " + numero);
            Console.WriteLine("1 – Entrada");
            Console.WriteLine("2 – Retirada");
            Console.WriteLine("3 – Consultar saldo");
            Console.WriteLine("0 – Sair");
            string Escolha = Console.ReadLine();

            if(Escolha == "1")
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Bem vindo a area de Depositos");
                Console.WriteLine("Digite a quantidade que gostaria de depositar: ");
                double ValorDeposito = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Você confirma esse valor? " + ValorDeposito);
                Console.ReadLine();



            }
            else if (Escolha == "2")
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Bem vindo a area de Saque");
                Console.WriteLine("Digite a quantidade que gostaria de Sacar: ");
                double ValorSaque = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Você confirma esse valor? " + ValorSaque);
                Console.ReadLine();


            }
            else if (Escolha == "3")
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Seu Saldo é de ");
            }else if(Escolha == "0")
            {

            }
            else{
                Console.WriteLine("Digite um Numero Valido");
            }
            Console.ReadKey();
        }
    }
}
