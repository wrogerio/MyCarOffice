using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class OrdemDeServico : EntityBase
{
    public OrdemDeServico(DateTime dataHoraInicio, string clienteNome, string clienteCpf, string clienteEmail,
        string clienteTelefone, string veiculoMarca, string veiculoModelo, string veiculoPlaca, int veiculoAno,
        AreaEnum servicoArea, string servicoNome, decimal servicoValor, string profissionalNome, string profissionalCpf,
        string oficinaNomeFantasia, string oficinaCnpj, string oficinaTelefone, string oficinaNomeResponsavel)
    {
        if (!Validar()) return;
        DataHoraInicio = dataHoraInicio;
        ClienteNome = clienteNome;
        ClienteCpf = clienteCpf;
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
        ProfissionalCpf = profissionalCpf;
        OficinaNomeFantasia = oficinaNomeFantasia;
        OficinaCnpj = oficinaCnpj;
        OficinaTelefone = oficinaTelefone;
        OficinaNomeResponsavel = oficinaNomeResponsavel;
    }

    public DateTime DataHoraInicio { get; set; } = DateTime.Now;
    public string ClienteNome { get; set; } = "";
    public string ClienteCpf { get; set; } = "";
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
    public DateTime? DataHoraEncerramento { get; set; }
    public DateTime? TempoTotal { get; set; }
    public string ProfissionalNome { get; set; } = "";
    public string ProfissionalCpf { get; set; } = "";
    public string OficinaNomeFantasia { get; set; } = "";
    public string OficinaCnpj { get; set; } = "";
    public string OficinaTelefone { get; set; } = "";
    public string OficinaEmail { get; set; } = "";
    public string OficinaNomeResponsavel { get; set; } = "";

    private bool Validar()
    {
        // DataHora Inicio
        if (DataHoraInicio.Equals(null)) return false;

        // Cliente Nome
        if (string.IsNullOrEmpty(ClienteNome)) return false;

        // Cliente CPF
        if (string.IsNullOrEmpty(ClienteCpf)) return false;

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
        if (string.IsNullOrEmpty(ProfissionalCpf)) return false;

        // Oficina Nome Fantasia
        if (string.IsNullOrEmpty(OficinaNomeFantasia)) return false;

        // Oficina CNPJ
        if (string.IsNullOrEmpty(OficinaCnpj)) return false;

        // Oficina Fone
        if (string.IsNullOrEmpty(OficinaTelefone)) return false;

        // Oficina Nome Responsável
        if (string.IsNullOrEmpty(OficinaNomeResponsavel)) return false;

        return true;
    }
}