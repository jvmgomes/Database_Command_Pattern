using src.Command;
using src.data;
using System;
using System.Collections.Generic;

namespace src.Server;

public class Server
{
    private Dictionary<int, Pessoa> db = new Dictionary<int, Pessoa>();
    private Dictionary<string, ICommand> cmds = new Dictionary<string, ICommand>();

    public Server()
    {
        initCommands();
    }

    private void initCommands()
    {
        cmds.Add("new", new NewCommand(db));
        cmds.Add("del", new DeleteCommand(db));
        cmds.Add("delete", new DeleteCommand(db));
        cmds.Add("get", new GetCommand(db));
        cmds.Add("all", new AllCommand(db));
    }

    public void Service (string cmd, object data)
    {
        if (cmds.TryGetValue(cmd, out ICommand c))
        {
            c.execute(data);
        }
        else
        {
            Console.WriteLine($"Comando '{cmd}' não reconhecido pelo Server");
        }
    }
}