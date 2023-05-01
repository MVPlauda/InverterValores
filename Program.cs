internal class Program
{
    private static void Main(string[] args)
    {
   
        int A, B;

        Console.WriteLine("Qual o primeiro número?");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual o segundo número?");
        B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nAntes de fazer a troca A = {A}, B = {B}");

        // Faz a troca dos valores de A e B utilizando a técnica de multiplicação, divisão e atribuição múltipla
        A = A * B;
        B = A / B;
        A = A / B;
        
        Console.WriteLine($" Depois de fazer a troca A = {A}, B = {B}");
    }
}