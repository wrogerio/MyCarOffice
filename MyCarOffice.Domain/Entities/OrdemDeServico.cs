using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class OrdemDeServico : EntityBase
{
    public OrdemDeServico(DateTime dataHoraInicio, string clienteNome, string clienteCPF, string clienteEmail,
        string clienteTelefone, string veiculoMarca, string veiculoModelo, string veiculoPlaca, int veiculoAno,
        AreaEnum servicoArea, string servicoNome, decimal servicoValor, string profissionalNome, string profissionalCPF,
        string oficinaNomeFantasia, string oficinaCNPJ, string oficinaFone, string oficinaNomeResponsavel)
    {
        if (!Validar()) return;
        DataHoraInicio = dataHoraInicio;
        ClienteNome = clienteNome;
        ClienteCPF = clienteCPF;
        ClienteEmail = clienteEmail;
        ClienteTelefone = clienteTelefone;
        VeiculoMarca = veiculoMarca;
        VeiculoModelo = veiculoModelo;
        VeiculoPlaca = veiculoPlaca;
        VeiculoAno = veiculoAno;
        ServicoArea = servicoArea;
        ServicoNome = servicoNome;
        ServicoValor = servicoValor;
        ProfissionalNome = profissionalNome;
        ProfissionalCPF = profissionalCPF;
        OficinaNomeFantasia = oficinaNomeFantasia;
        OficinaCNPJ = oficinaCNPJ;
        OficinaFone = oficinaFone;
        OficinaNomeResponsavel = oficinaNomeResponsavel;
    }

    public DateTime DataHoraInicio { get; } = DateTime.Now;
    public string ClienteNome { get; } = "";
    public string ClienteCPF { get; } = "";
    public string ClienteEmail { get; } = "";
    public string ClienteTelefone { get; } = "";
    public string VeiculoMarca { get; } = "";
    public string VeiculoModelo { get; } = "";
    public string VeiculoPlaca { get; } = "";
    public int VeiculoAno { get; }
    public string VeiculoCor { get; set; } = "";
    public AreaEnum ServicoArea { get; } = AreaEnum.Mecanica;
    public string ServicoNome { get; } = "";
    public decimal ServicoValor { get; }
    public DateTime? DataHoraEncerramento { get; set; }
    public DateTime? TempoTotal { get; set; }
    public string ProfissionalNome { get; } = "";
    public string ProfissionalCPF { get; } = "";
    public string OficinaNomeFantasia { get; } = "";
    public string OficinaCNPJ { get; } = "";
    public string OficinaFone { get; } = "";
    public string OficinaEmail { get; set; } = "";
    public string OficinaNomeResponsavel { get; } = "";

    private bool Validar()
    {
        // DataHora Inicio
        if (DataHoraInicio.Equals(null)) return false;

        // Cliente Nome
        if (string.IsNullOrEmpty(ClienteNome)) return false;

        // Cliente CPF
        if (string.IsNullOrEmpty(ClienteCPF)) return false;

        // Cliente Email
        if (string.IsNullOrEmpty(ClienteEmail)) return false;

        // Cliente Telefone
        if (string.IsNullOrEmpty(ClienteTelefone)) return false;

        // Veículo Marca
        if (string.IsNullOrEmpty(VeiculoMarca)) return false;

        // Veículo Modelo
        if (string.IsNullOrEmpty(VeiculoModelo)) return false;

        // Veículo Placa
        if (string.IsNullOrEmpty(VeiculoPlaca)) return false;

        // Veículo Ano
        if (VeiculoAno <= 0) return false;

        // Serviço Área
        if (ServicoArea <= 0) return false;

        // Serviço Nome
        if (string.IsNullOrEmpty(ServicoNome)) return false;

        // Serviço Valor
        if (ServicoValor <= 0) return false;

        // Profissional Nome
        if (string.IsNullOrEmpty(ProfissionalNome)) return false;

        // Profissional CPF
        if (string.IsNullOrEmpty(ProfissionalCPF)) return false;

        // Oficina Nome Fantasia
        if (string.IsNullOrEmpty(OficinaNomeFantasia)) return false;

        // Oficina CNPJ
        if (string.IsNullOrEmpty(OficinaCNPJ)) return false;

        // Oficina Fone
        if (string.IsNullOrEmpty(OficinaFone)) return false;

        // Oficina Nome Responsável
        if (string.IsNullOrEmpty(OficinaNomeResponsavel)) return false;

        return true;
    }
}