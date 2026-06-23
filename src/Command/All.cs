namespace src.Command;
public class AllCommand : Command {
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