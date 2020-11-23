using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:

            Álcool: 
            . até 20 litros, desconto de 3% por litro Álcool 
            . acima de 20 litros, desconto de 5% por litro 
            Gasolina: 
            . até 20 litros, desconto de 4% por litro Gasolina 
            . acima de 20 litros, desconto de 6% por litro

            Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
            Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

            */

            // Perguntamos e capturamos o tipo de combustivel
            Console.WriteLine("Qual tipo de combustível você deseja? \n  A-álcool \n  G-gasolina");
            string tipoCombustivel = Console.ReadLine();
            
            // Perguntamos e capturamos a quantidade de litros desejada
            Console.WriteLine("Quantos litros você quer abastecer?");
            float litros = float.Parse(Console.ReadLine());

            // Criamos a estrutura switch para aplicar as configurações
            switch (tipoCombustivel)
            {
                case "A":
                    MostrarValorPago( AplicarDesconto(litros, 4.90f, 3, 5) );
                    break;

                case "G":
                    MostrarValorPago( AplicarDesconto(litros, 5.30f, 4, 6) );
                    break;

                default:
                    Console.WriteLine("Tipo de combustível inválido");
                    break;
            }

            // Criamos um método genérico para realizar o cálculo
            float AplicarDesconto(float litros, float preco, float perc1, float perc2){
                
                if(litros <= 20){
                    return litros * (preco - (preco * perc1 / 100));
                }

                return litros * (preco - (preco * perc2 / 100));
            }

            // Criamos um método para mostrar os valores
            void MostrarValorPago(float valorPago){
                Console.WriteLine("Valor total a ser pago é : "+valorPago);
            }


        }
    }
}
