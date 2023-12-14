using System;

class Program
{
    static void Main(string[] args)
    {
        
    string registroEmail = "";
    string registroNome = ""; 
    string senha = "";

    registroEmail = Console.ReadLine();
    registroNome = Console.ReadLine();
    senha = Console.ReadLine();

    Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");

    }
}