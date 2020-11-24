using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
            preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
            desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
            - Se quantidade <= 5 o desconto será de 2%
            - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
            - Se quantidade > 10 o desconto será de 5%
            Dica: utilize if / else if / else
            
            */
            System.Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            
            System.Console.WriteLine("Digite a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor unitario");
            float valorunitario = float.Parse(Console.ReadLine());

            float total = quantidade * valorunitario;

            if(quantidade <= 5){
                total = total - (total * 0.02);
            }else if(quantidade > 5 && quantidade <= 10){
                total = total - (total * 0.03);
            }else{
                total = total - (total * 0.05);
            }

            Console.WriteLine("O total final com desconto é :" + total);

        }
    }
}
