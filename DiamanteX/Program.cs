using System.Xml;

namespace DiamanteX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Desafio do diamante de X\n\nPor favor, informe um número natural ímpar (positivo e inteiro):");
                decimal num = Convert.ToDecimal(Console.ReadLine());

                while (num % 2 == 0 || num < 0 || num % 1 != 0)
                {
                    Console.WriteLine("Número inválido :(\n\nPor favor, informe um novo número:");
                    num = Convert.ToDecimal(Console.ReadLine());
                }

                //Linha do meio
                decimal iMeio = Math.Floor(num / 2);
                Console.WriteLine();

                //linha
                for (int i = 0; i < num; i++)
                {
                    //coluna
                    for (int j = 0; j < num; j++)
                    {
                        if (Math.Abs(j - iMeio) <= i && i <= iMeio) Console.Write("X");
                        else if (Math.Abs(i - 2 * iMeio) >= Math.Abs(j - iMeio) && i > iMeio) Console.Write("X");
                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Show! O volume é:\n\nDeseja continuar? [S/N]");

                if (DeveContinuar()) break;
            }
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}