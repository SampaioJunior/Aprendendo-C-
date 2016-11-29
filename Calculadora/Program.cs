using System;

namespace MiniCalculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
         double numero1, numero2;
         string temporario;
         double resultado;

         Console.WriteLine("Digite um numero");
         temporario = Console.ReadLine();
         numero1 = int.Parse(temporario);
        
         Console.WriteLine("Digite mais um numero");
         temporario = Console.ReadLine();
         numero2 = int.Parse(temporario);

         resultado = numero1 + numero2;
         Console.WriteLine("Soma: " + resultado);

         resultado = numero1 - numero2;
         Console.WriteLine("Subratacao: " + resultado);
         
         resultado = numero1 * numero2;
         Console.WriteLine("Multiplicacao: " + resultado);

         resultado = numero1 / numero2;
         Console.WriteLine("divisao: " + resultado);

        }
    }
}
