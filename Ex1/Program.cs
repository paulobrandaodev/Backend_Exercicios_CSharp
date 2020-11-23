using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
            */

            // Perguntamos para o usuário:
            Console.WriteLine("Digite o ano em que vc nasceu:");

            // Capturamos o que é digitado, convertendo para int:
            int anoNascimento = int.Parse(Console.ReadLine());

            // Utilizando a biblioteca Datetime conseguimos capturar algumas informações da nossa máquina
            int anoAtual = DateTime.Now.Year;

            // Fazemos o cálculo para saber a idade da pessoa
            int idade = anoAtual - anoNascimento;

            // Criamos uma condicional para mostrar a mensagem solicitada
            if(idade > 16){
                Console.WriteLine("Você poderá votar este ano");
            }else{ 
                Console.WriteLine("Você NÃO poderá votar este ano");
            }
            
        }
    }
}
