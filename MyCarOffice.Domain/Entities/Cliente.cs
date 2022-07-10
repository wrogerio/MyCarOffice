namespace MyCarOffice.Domain.Entities;

public class Cliente : EntityBase
{
    public Cliente(string nome, string cpf, DateTime dataNasc, string sexo, string logradouro, string telefone)
    {
        if (!Validar()) return;

        Nome = nome;
        Cpf = cpf;
        DataNasc = dataNasc;
        Sexo = sexo;
        Logradouro = logradouro;
        Telefone = telefone;
    }

    public string Nome { get; } = "";
    public string Cpf { get; } = "";
    public DateTime DataNasc { get; } = DateTime.Now;
    public string Email { get; } = "";
    public string Telefone { get; } = "";
    public string Sexo { get; } = "";
    public string Logradouro { get; } = "";
    public string Numero { get; } = "";
    public string Complemento { get; set; } = "";
    public string Bairro { get; set; } = "";
    public string Cep { get; set; } = "";
    

    // Relacionamentos
    public virtual IEnumerable<Veiculo>? Veiculos { get; set; }

    private bool Validar()
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