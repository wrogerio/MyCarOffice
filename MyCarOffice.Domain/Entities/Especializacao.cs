namespace MyCarOffice.Domain.Entities;

public class Especializacao : EntityBase
{
    public Especializacao(string nome, DateTime since)
    {
        if (!ValidarEntidade()) return;
        Nome = nome;
        Since = since;
    }

    public Especializacao()
    {
    }

    public string Nome { get; set; } = "";
    public DateTime Since { get; set; } = DateTime.Now;

    // Relacionamentos
    public Guid ProfissionalId { get; set; }
    public virtual Profissional? Profissional { get; set; }

    private bool ValidarEntidade()
    {
        // Nome
        if (string.IsNullOrEmpty(Nome)) return false;

        // Since
        if (Since.Equals(null)) return false;

        return true;
    }
}