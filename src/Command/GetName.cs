using src.data;
using src.Server;
using System;

namespace src.Command;
public class GetCommand : Command {
    private Dictionary<int, Pessoa> db;    
    public GetCommand(Dictionary<int, Pessoa> db) {
        this.db = db;
    }
    public Object execute(Object arg) {
        Data d = (Data)arg;
        
        int id = d.GetArg<int>(0);

        if (db.TryGetValue(id, out Pessoa pessoa))
            Console.WriteLine($"ID: {pessoa.Id}, Nome: {pessoa.Nome}");
        else
            Console.WriteLine($"Pessoa com ID {id} não encontrada.");
        return null;
    }
}