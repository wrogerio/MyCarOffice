namespace MyCarOffice.Domain.Entities;

public class Veiculo : EntityBase
{
    public Veiculo(string marca, string modelo, string placa, int ano)
    {
        if (Validar())
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Ano = ano;
        }
    }

    public string Marca { get; } = "";
    public string Modelo { get; } = "";
    public string Placa { get; } = "";
    public int Ano { get; }
    public string Cor { get; set; } = "";
    public string Observacao { get; set; } = "";

    //Relacionamentos
    public Guid ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; }

    private bool Validar()
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