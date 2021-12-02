using System;

namespace dotnetcore
{
    class Program {
        static void Main(string[] args) {
            
            /*
            // Aula: 

            Console.Write("Seu nome, por favor: ");

            string name = Console.ReadLine();
            var altura = 1.78;

            Console.WriteLine("\nSeu nome: " + name + "\nSua altura: " + altura);
            Console.WriteLine($"O valor em decimal: {altura:C}"); //Moeda Corrente
            */

            /*
            // Desafio 1:

            var valorConta = 130.00;
            var valorTaxa = 0.15;
            var valorCusto = valorConta + (valorConta*valorTaxa);
            Console.WriteLine($"Valor da conta final: R{valorCusto:C}");
            */

            /* DICA:

            Console.WriteLine("Digite algum numero: ");

            var num = Console.ReadLine();

            var numero = int.Parse(num);

            Console.WriteLine("O dobro daquele numero eh: " + numero*2);
            */

            /*
            Console.Write("Digite algum numero: ");

            var num = Console.ReadLine();

            var numero = int.Parse(num);

            Console.WriteLine("O dobro daquele numero eh: " + numero*2);
            */

            int hours = 23;

            if(hours < 12) {
                Console.WriteLine("Sao " + hours + " da manha!");
            } 
            
            else if(hours > 12 && hours < 18) {
                Console.WriteLine("Sao " + (hours - 12) + " da tarde!");
            }

            else {
                Console.WriteLine("Sao " + (hours - 12) + " da noite!");
            }
        }
    }
}
