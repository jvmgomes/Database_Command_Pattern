using src.data;
using src.Server;
using System;

namespace src.Command;
public class AllCommand : Command {
    private Dictionary<int, Pessoa> db;
    public AllCommand(Dictionary<int, Pessoa> db) {
        this.db = db;
    }
    public Object execute(Object arg){
        foreach (var pessoa in db.Values)
        {
            Console.WriteLine($"ID: {pessoa.getId()}, Nome: {pessoa.getNome()}");
        }
        return null;
    }
}