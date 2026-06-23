namespace src.data;
public class Pessoa
{
    public string Nome { get; }
    public int Id { get; }
    private Pessoa(string nome, int identidade)
    {
        Nome = nome;
        Id = identidade;
    }
    public class Builder
    {
        private string? _nome;
        private int? _identidade;

        public Builder ComNome(string nome)
        {
            _nome = nome;
            return this;
        }

        public Builder ComIdentidade(int identidade)
        {
            _identidade = identidade;
            return this;
        }

        public Pessoa Build()
        {
            if (string.IsNullOrWhiteSpace(_nome))
                throw new InvalidOperationException("Nome é obrigatório para criar uma Pessoa.");
            if (string.IsNullOrWhiteSpace(_identidade))
                throw new InvalidOperationException("Identidade é obrigatória para criar uma Pessoa.");

            return new Pessoa(_nome, _identidade);
        }
    }
}