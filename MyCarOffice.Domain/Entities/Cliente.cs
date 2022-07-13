namespace MyCarOffice.Domain.Entities;

public class Cliente : EntityBase
{
    public Cliente(string nome, string cpf, DateTime dataNasc, string sexo, string logradouro, string telefone)
    {
        if (!ValidarEntidade()) return;
        Nome = nome;
        Cpf = cpf;
        DataNasc = dataNasc;
        Sexo = sexo;
        Logradouro = logradouro;
        Telefone = telefone;
    }

    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";
    public DateTime DataNasc { get; set; } = DateTime.Now;
    public string Email { get; set; } = "";
    public string Telefone { get; set; } = "";
    public string Sexo { get; set; } = "";
    public string Logradouro { get; set; } = "";
    public string Numero { get; set; } = "";
    public string Complemento { get; set; } = "";
    public string Bairro { get; set; } = "";
    public string Cep { get; set; } = "";


    // Relacionamentos
    public virtual IEnumerable<Veiculo>? Veiculos { get; set; }

    private bool ValidarEntidade()
    {
        // Nome 
        if (string.IsNullOrEmpty(Nome)) return false;

        // CPF 
        if (string.IsNullOrEmpty(Cpf)) return false;

        // Data Nascimento
        if (DataNasc.Equals(null)) return false;

        // Email 
        if (string.IsNullOrEmpty(Email)) return false;

        // Sexo 
        if (string.IsNullOrEmpty(Sexo)) return false;

        // Logradouro 
        if (string.IsNullOrEmpty(Logradouro)) return false;

        // Numero 
        if (string.IsNullOrEmpty(Numero)) return false;

        // Telefone
        if (string.IsNullOrEmpty(Telefone)) return false;

        return true;
    }
}