using System;

namespace Aula1_24v09
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Console.Write("Digite um valor: ");
            numero.Valor = double.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            numero.Valor2 = double.Parse(Console.ReadLine());
            double soma = numero.Valor + numero.Valor2;
            Console.WriteLine("A soma é: " + soma);
            Console.ReadKey();
        }
    }
}
