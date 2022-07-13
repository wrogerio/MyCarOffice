namespace MyCarOffice.Domain.Entities;

public class Veiculo : EntityBase
{
    public Veiculo(string marca, string modelo, string placa, int ano)
    {
        if (!ValidarEntidade()) return;
        Marca = marca;
        Modelo = modelo;
        Placa = placa;
        Ano = ano;
    }

    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public string Placa { get; set; } = "";
    public int Ano { get; set; } = DateTime.Now.Year;
    public string Cor { get; set; } = "";
    public string Observacao { get; set; } = "";

    //Relacionamentos
    public Guid ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }

    private bool ValidarEntidade()
    {
        // Marca
        if (string.IsNullOrEmpty(Marca)) return false;

        // Modelo
        if (string.IsNullOrEmpty(Modelo)) return false;

        // Placa
        if (string.IsNullOrEmpty(Placa)) return false;

        // Ano
        if (Ano <= 0) return false;

        return true;
    }
}