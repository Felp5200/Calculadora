using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora");
            Console.Write("Digite o número (X): ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número (Y): ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a operação (+ ou - ou * ou / ): ");
            char operation = Console.ReadLine()[0];

            double resultado = 0;

            // Realiza a operação com base na entrada do usuário
            if (operation == '+')
            {
                resultado = x + y;
            }
            else if (operation == '-')
            {
                resultado = x - y;
            }
            else if (operation == '*')
            {
                resultado = x * y;
            }
            else if (operation == '/')
            {
                resultado = x / y;
            }
            else
            {
                Console.WriteLine("Operação inválida. Tente novamente.");
                continue;
            }

            Console.WriteLine($"Equação: {x} {operation} {y} = {resultado}");

            Console.WriteLine("O resultado é: " + resultado);
            
            Console.Write("Fazer outra operação? (S/N): ");
            if (Console.ReadLine().ToUpper() != "S")
            {
                break;
            }
        }
    }
}
