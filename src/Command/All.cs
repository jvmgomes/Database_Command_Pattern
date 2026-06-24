using src.data;
using src.Server;
using System;

namespace src.Command;
public class AllCommand : ICommand {
    private Dictionary<int, Pessoa> db;
    public AllCommand(Dictionary<int, Pessoa> db) {
        this.db = db;
    }
    public Object execute(Object arg){
        foreach (var pessoa in db.Values)
        {
            Console.WriteLine($"ID: {pessoa.Id}, Nome: {pessoa.Nome}");
        }
        return null;
    }
}