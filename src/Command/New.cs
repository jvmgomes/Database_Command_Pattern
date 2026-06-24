using src.data;
using src.Server;
using System;

namespace src.Command;

public class NewCommand : ICommand {
    private Dictionary<int, Pessoa> db;
    public NewCommand(Dictionary<int, Pessoa> db)
    {
        this.db = db;
    }
    public Object execute(Object arg) {
        Data d = (Data)arg;
        int id = d.GetArg<int>(0);
        string nome = d.GetArg<string>(1);

        Pessoa p = new Pessoa.Builder()
            .ComIdentidade(id)
            .ComNome(nome)
            .Build();

        db.Add(id, p);
        Console.WriteLine($"Pessoa {nome} (ID {id}) adicionada.");
        return null;
    }
}