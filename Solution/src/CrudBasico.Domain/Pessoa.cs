namespace CrudBasico.Domain
{
    public class Pessoa
    {
        protected Pessoa(){}

        public Pessoa(string nome, DateTime dataNascimento, string endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
    }
}