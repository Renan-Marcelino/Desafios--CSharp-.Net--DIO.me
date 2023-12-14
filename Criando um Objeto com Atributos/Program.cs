using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }
}

class Program
{
    static void Main()
    {
        string Nome = Console.ReadLine();
        string Nacionalidade = Console.ReadLine();
        int Idade = Convert.ToInt32(Console.ReadLine());
        string Posicao = Console.ReadLine();
        
        Console.WriteLine($"Jogador criado!\n{Nome}\n{Nacionalidade}\n{Idade}\nPosição: {Posicao}");
      
    }
}