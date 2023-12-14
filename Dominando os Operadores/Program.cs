using System;

class Program
{
    static void Main()
    {
        string titulo = "";
        string descricao = "";
        string dataVencimento = "";

        titulo = Console.ReadLine();
        descricao = Console.ReadLine();

        if (descricao.Length > 50)
        {
            Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        }
        else
        {
            dataVencimento = Console.ReadLine();

            Console.WriteLine($"{descricao} ate {dataVencimento}");
        }
    }
}