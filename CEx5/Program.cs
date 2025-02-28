namespace CEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º número:");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o 2º número:");
            int num2 = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o 3º número:");
            int num3 = int.Parse(Console.ReadLine()!);

            int maior = Math.Max(Math.Max(num1, num2), num3);
            int menor = Math.Min(Math.Min(num1, num2), num3);

            Console.WriteLine($"\nO número {maior} é o maior valor.");
            Console.WriteLine($"\nO número {menor} é o menor valor.");
        }
    }
}
