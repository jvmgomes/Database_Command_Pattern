using src.data;
using src.Server;
using System;

namespace src.Command;
public class GetCommand : Command {
    public GetCommand(Dictionary<int, Pessoa> db) {
        this.db = db;
    }
    public Object execute(Object arg) {
        Data d = (Data)arg;
        int id = d.getArg(0);
        if (db.TryGetValue(id, out Pessoa pessoa))
        {
            string nome = pessoa.getNome();
            Console.WriteLine($"Encontrado: {nome}");
        }
        else
        {
            Console.WriteLine("Chave não encontrada.");
        }
        return null;
    }
}