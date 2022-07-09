using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities
{
    public class OrdemDeServico : EntityBase
    {
        public DateTime DataHoraInicio { get; set; } = DateTime.Now;
        public string ClienteNome { get; set; } = "";
        public string ClienteCPF { get; set; } = "";
        public string ClienteEmail { get; set; } = "";
        public string ClienteTelefone { get; set; } = "";
        public string VeiculoMarca { get; set; } = "";
        public string VeiculoModelo { get; set; } = "";
        public string VeiculoPlaca { get; set; } = "";
        public int VeiculoAno { get; set; }
        public string VeiculoCor { get; set; } = "";
        public AreaEnum ServicoArea { get; set; } = AreaEnum.Mecanica;
        public string ServicoNome { get; set; } = "";
        public decimal ServicoValor { get; set; }
        public DateTime DataHoraEncerramento { get; set; } = DateTime.Now;
        public DateTime TempoTotal { get; set; } = DateTime.Now;
        public string ProfissionalNome { get; set; } = "";
        public string ProfissionalCPF { get; set; } = "";
        public string OficinaNomeFantasia { get; set; } = "";
        public string OficinaCNPJ { get; set; } = "";
        public string OficinaFone { get; set; } = "";
        public string OficinaEmail { get; set; } = "";
        public string OficinaResponsavel { get; set; } = "";
    }
}
