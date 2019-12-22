using System;
public class soma_dupla
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entre com dois numeros");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int soma = num1 + num2;
        Console.WriteLine("A soma de "+num1+" e "+num2+" é "+soma+".");
    }
}
