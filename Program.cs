using System;

namespace dotnetcore
{
    class Program {

        static void FunctionInit() {

            // Aula: 
            Console.Write("Seu nome, por favor: ");
            string name = Console.ReadLine();
            var altura = 1.78;

            Console.WriteLine("\nSeu nome: " + name + "\nSua altura: " + altura);
            Console.WriteLine($"O valor em decimal: {altura:C}"); //Moeda Corrente
                        
            // Desafio 1:
            var valorConta = 130.00;
            var valorTaxa = 0.15;
            var valorCusto = valorConta + (valorConta*valorTaxa);
            Console.WriteLine($"Valor da conta final: R{valorCusto:C}");
            
            // DICA:
            Console.WriteLine("Digite algum numero: ");

            var num = Console.ReadLine();
            var numero = int.Parse(num);

            Console.WriteLine("O dobro daquele numero eh: " + numero*2);
        }

        static void FunctionCond() {

            Console.WriteLine("Que horas são no relogio de 24h?");

            var hours = int.Parse(Console.ReadLine());

            if(hours < 12) {
                Console.WriteLine("Sao " + hours + " da manha!");
            } 
            
            else if(hours > 12 && hours < 18) {
                Console.WriteLine("Sao " + (hours - 12) + " da tarde!");
            }

            else if(hours == 12){
                Console.WriteLine("Eh Meio Dia!");
            }
            else {
                Console.WriteLine("Sao " + (hours - 12) + " da noite!");
            }
        }

        static void FunctionSwitch() {
            
            Console.WriteLine("Seu tipo de musica favorito:");

            var music = Console.ReadLine();
            
            switch(music) {

                case "pop" : Console.WriteLine("Tem bom gosto!"); break;
                case "rock" : Console.WriteLine("Tem bom gosto!"); break;
                case "funk" : Console.WriteLine("Nao tem bom gosto!"); break;
                case "lo-fi" : Console.WriteLine("Tem muito bom gosto!"); break;
                default: Console.WriteLine("Informacao Invalida!"); break;
            }
        }

        static void FunctionRepe() {

            int soma = 0;
            int sub = 10;
            int i = 0; //variavel para loop 

            for(i = 0; i > 10; i++) {
                soma += 1;
            }

            i = 0; //zerando a variavel para loop:

            while(i < 10 && i > 0) {
                sub -= 1;
            }

            Console.WriteLine("Os resultados: \nSoma = " + soma + "\nSubtracao = " + sub);
        }

        static void Main(string[] args) {
            
            // FunctionInit();
            // FunctionCond();
            // FunctionSwitch();
            FunctionRepe();
        }
    }
}
