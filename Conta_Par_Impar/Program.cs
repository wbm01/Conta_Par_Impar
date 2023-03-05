internal class Program
{
    private static void Main(string[] args)
    {
        int contpar = 0, contimpar = 0, numero, soma1=0, soma2=0;

        do {
            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero%2 == 0 && numero < 1000 && numero > -1)
            {
                soma1 = numero + soma1;
                contpar++;
            }
            else
            {
                if (numero < 1000 && numero > -1)
                {
                    soma2 = numero + soma2;
                    contimpar++;
                }
            }

        } while (numero < 1000);

        Console.WriteLine("\nForam informados {0} números pares "
            + "e a soma é: {1}",contpar,soma1);

        Console.WriteLine("\nForam informados {0} números ímpares "
            + "e a soma é: {1}",contimpar, soma2);

        Console.WriteLine("\nFim do programa!");
    }
}