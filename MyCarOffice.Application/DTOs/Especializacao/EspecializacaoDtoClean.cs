namespace MyCarOffice.Application.DTOs.Especializacao;

public class EspecializacaoDtoClean
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = "";
    public DateTime Since { get; set; } = DateTime.Now;
}