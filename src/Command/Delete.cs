using src.data;
using src.Server;
using System;

namespace src.Command;
public class DeleteCommand : Command {
    public DeleteCommand(Dictionary<int, Pessoa> db) {
        this.db = db;
    }
    public Object execute(Object arg) {
        Data d = (Data)arg;
        int id = d.getArg(0);
        if (db.Remove(id)) {
            Console.WriteLine($"Pessoa com ID {id} removida com sucesso.");
        } else {
            Console.WriteLine($"Pessoa com ID {id} não encontrada.");
        }
        return null;
    }
}