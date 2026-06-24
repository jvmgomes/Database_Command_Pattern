using System;

namespace src.data;

public class Data
{
    private string[] _args;

    public Data(string[] args)
    {
        _args = args;
    }

    // Método genérico para converter o argumento de string para o tipo desejado (int, string, etc.)
   public T GetArg<T>(int index)
    {
        // 1. Verifica se o índice é válido
        if (index < 0 || index >= _args.Length)
        {
            return default(T);
        }
        
        // 2. Se estivermos pedindo uma string no índice 1 (ex: o Nome), 
        // junta todos os pedaços que sobraram caso o nome seja composto
        if (typeof(T) == typeof(string) && index == 1)
        {
            string nomeComposto = string.Join(" ", _args, 1, _args.Length - 1);
            return (T)Convert.ChangeType(nomeComposto, typeof(T));
        }

        // 3. Comportamento normal para IDs e outras coisas
        return (T)Convert.ChangeType(_args[index], typeof(T));
    }
}