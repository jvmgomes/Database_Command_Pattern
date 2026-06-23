namespace src.Command;

public class New : Command {

    public New()
    {
        this.db = db;
    }
    public Object execute(Object arg) {
        Data d = (Data)arg;
        int id = d.getArg(0);
        String nome = d.getArg(1);
        db.put(new Pessoa(id, nome));
    }
}