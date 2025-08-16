using System;

namespace MeuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Multiplicaçao e divisão são executadas primeiros se quiser
            // mudar a order, usar parenteses

            int soma = 25 + 22; // 47
            int subtracao = 25 - 22; // 3
            int multiplicacao = 25 * 22; // 550
            int divisao = 25 / 22; // 4 - foi arredondado

            int x = 2 + 2 * 2; // 6
            int y = 2 + (2 * 2); // 6 - Mesmo do anterios
            int z = (2 + 2) * 2; // 8 - Executou a soma primeiro

        }
    }
}