namespace MyCarOffice.Domain.Entities;

public class Oficina : EntityBase
{
    public Oficina(string nomeFantasia, string cnpj, string nomeResponsavel, string telefone, string logradouro)
    {
        if (!Validar()) return;
        NomeFantasia = nomeFantasia;
        Cnpj = cnpj;
        NomeResponsavel = nomeResponsavel;
        Telefone = telefone;
        Logradouro = logradouro;
    }

    public string NomeFantasia { get; } = "";
    public string Cnpj { get; } = "";
    public string NomeResponsavel { get; } = "";
    public string Telefone { get; } = "";
    public string Email { get; set; } = "";
    public string Site { get; set; } = "";
    public string Logradouro { get; } = "";
    public string Numero { get; } = "";
    public string Complemento { get; set; } = "";
    public string Bairro { get; set; } = "";
    public string Cep { get; set; } = "";

    private bool Validar()
    {
        // Nome Fantasia
        if (string.IsNullOrEmpty(NomeFantasia)) return false;

        // CNPJ
        if (string.IsNullOrEmpty(Cnpj)) return false;

        // Nome Responsável
        if (string.IsNullOrEmpty(NomeResponsavel)) return false;

        // Telefone
        if (string.IsNullOrEmpty(Telefone)) return false;

        // Logradouro
        if (string.IsNullOrEmpty(Logradouro)) return false;

        // Numero
        if (string.IsNullOrEmpty(Numero)) return false;

        return true;
    }
}