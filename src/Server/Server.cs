using src.Command;
using System;

namespace src.Server;

public class Server
{
    private Dictionary<int, string> db = new Dictionary<int, string>();
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
            c.Execute(data);
        }
        else
        {
            Console.WriteLine($"Comando '{cmd}' não reconhecido pelo Server");
        }
    }
}