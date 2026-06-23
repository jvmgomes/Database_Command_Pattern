using src.data;
using src.Server;
using System;

namespace src.Command;

public class New : Command {

    public New(Dictionary<int, Pessoa> db)
    {
        this.db = db;
    }
    public Object execute(Object arg) {
        Data d = (Data)arg;
        int id = d.getArg(0);
        String nome = d.getArg(1);
        db.Add(new Pessoa(id, nome));
    }
}