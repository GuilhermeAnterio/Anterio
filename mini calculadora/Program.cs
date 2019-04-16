using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digita o Primeiro Numero: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita o Segunda Numero: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            int somaAdicao = primeiroNumero + segundoNumero;
            Console.WriteLine("Resultado da Adição é : " + somaAdicao);

            int somaSubtracao = primeiroNumero - segundoNumero;
            Console.WriteLine("Resultado da Subtração é : " + somaSubtracao);

            int somaMultiplicacao = primeiroNumero * segundoNumero;
            Console.WriteLine("Resultado da Multiplicação é : " + somaMultiplicacao);

            int somaDivisao = primeiroNumero / segundoNumero;
            Console.WriteLine("Resultado da Divisão é : " + somaDivisao);

            Console.ReadKey();










            Console.WriteLine();
             

      
            



       

          
        }
    }
}
