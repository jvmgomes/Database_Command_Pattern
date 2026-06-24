using System;
using src.Server;
using src.data;

namespace src;

class Program
{
    static void Main(string[] args)
    {
        //inicializa o invocador 
        Server.Server server = new Server.Server();

        Console.WriteLine("--- BANCO DE DADOS DE PESSOAS ---");
        Console.WriteLine("Comandos suportados:");
        Console.WriteLine("new <id> <nome>");
        Console.WriteLine("delete <id> (ou del <id>)");
        Console.WriteLine("get <id>");
        Console.WriteLine("all");
        Console.WriteLine("Digite 'exit' para sair.\n");

        while (true)
        {
            Console.WriteLine("Server> ");
            string linha = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(linha)) continue;
            if (linha.Trim().ToLower() == "exit") break;

            //divide a string de entrada em partes, separadas por espaço
            string [] partes = linha.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string comandoDigitado = partes[0].ToLower();

            //separa os argumentos (tudo que vem depois do nome do comnando)
            string[] argumentosPuros = new string[partes.Length - 1];
            Array.Copy(partes, 1, argumentosPuros, 0, partes.Length - 1);

            //encapsula os argumentos no objeto data
            Data dados = new Data(argumentosPuros);

            //invoca o comando no servidor
            server.Service(comandoDigitado, dados);


        }
    }
}