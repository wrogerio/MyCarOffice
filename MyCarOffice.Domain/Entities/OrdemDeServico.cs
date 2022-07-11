using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities;

public class OrdemDeServico : EntityBase
{
    public OrdemDeServico(string oficinaNomeFantasia, string oficinaCnpj, string oficinaNomeResponsavel,
        string oficinaTelefone, string oficinaEmail, string oficinaSite, string oficinaLogradouro, string oficinaNumero,
        string oficinaComplemento, string oficinaBairro, string oficinaCep, string profissionalNome,
        string profissionalCpf, DateTime profissionalDataNasc, int profissionalArea, string clienteNome,
        string clienteCpf, DateTime clienteDataNasc, string clienteEmail, string clienteTelefone, string clienteSexo,
        string clienteLogradouro, string clienteNumero, string clienteComplemento, string clienteBairro,
        string clienteCep, string veiculoMarca, string veiculoModelo, string veiculoPlaca, int veiculoAno,
        string veiculoCor, string veiculoObservacao, int servicoArea, string servicoNome, double servicoValor,
        double servicoTempoMedio, bool concluida)
    {
        OficinaNomeFantasia = oficinaNomeFantasia;
        OficinaCnpj = oficinaCnpj;
        OficinaNomeResponsavel = oficinaNomeResponsavel;
        OficinaTelefone = oficinaTelefone;
        OficinaEmail = oficinaEmail;
        OficinaSite = oficinaSite;
        OficinaLogradouro = oficinaLogradouro;
        OficinaNumero = oficinaNumero;
        OficinaComplemento = oficinaComplemento;
        OficinaBairro = oficinaBairro;
        OficinaCep = oficinaCep;
        ProfissionalNome = profissionalNome;
        ProfissionalCpf = profissionalCpf;
        ProfissionalDataNasc = profissionalDataNasc;
        ProfissionalArea = profissionalArea;
        ClienteNome = clienteNome;
        ClienteCpf = clienteCpf;
        ClienteDataNasc = clienteDataNasc;
        ClienteEmail = clienteEmail;
        ClienteTelefone = clienteTelefone;
        ClienteSexo = clienteSexo;
        ClienteLogradouro = clienteLogradouro;
        ClienteNumero = clienteNumero;
        ClienteComplemento = clienteComplemento;
        ClienteBairro = clienteBairro;
        ClienteCep = clienteCep;
        VeiculoMarca = veiculoMarca;
        VeiculoModelo = veiculoModelo;
        VeiculoPlaca = veiculoPlaca;
        VeiculoAno = veiculoAno;
        VeiculoCor = veiculoCor;
        VeiculoObservacao = veiculoObservacao;
        ServicoArea = servicoArea;
        ServicoNome = servicoNome;
        ServicoValor = servicoValor;
        ServicoTempoMedio = servicoTempoMedio;
        Concluida = concluida;
    }

    public string OficinaNomeFantasia { get; set; }
    public string OficinaCnpj { get; set; }
    public string OficinaNomeResponsavel { get; set; }
    public string OficinaTelefone { get; set; }
    public string OficinaEmail { get; set; }
    public string OficinaSite { get; set; }
    public string OficinaLogradouro { get; set; }
    public string OficinaNumero { get; set; }
    public string OficinaComplemento { get; set; }
    public string OficinaBairro { get; set; }
    public string OficinaCep { get; set; }
    public string ProfissionalNome { get; set; }
    public string ProfissionalCpf { get; set; }
    public DateTime ProfissionalDataNasc { get; set; }
    public int ProfissionalArea { get; set; }
    public string ClienteNome { get; set; }
    public string ClienteCpf { get; set; }
    public DateTime ClienteDataNasc { get; set; }
    public string ClienteEmail { get; set; }
    public string ClienteTelefone { get; set; }
    public string ClienteSexo { get; set; }
    public string ClienteLogradouro { get; set; }
    public string ClienteNumero { get; set; }
    public string ClienteComplemento { get; set; }
    public string ClienteBairro { get; set; }
    public string ClienteCep { get; set; }
    public string VeiculoMarca { get; set; }
    public string VeiculoModelo { get; set; }
    public string VeiculoPlaca { get; set; }
    public int VeiculoAno { get; set; }
    public string VeiculoCor { get; set; }
    public string VeiculoObservacao { get; set; }
    public int ServicoArea { get; set; }
    public string ServicoNome { get; set; }
    public double ServicoValor { get; set; }
    public double ServicoTempoMedio { get; set; }
    public bool Concluida { get; set; }

    private bool Validar()
    {
        if (string.IsNullOrEmpty(OficinaNomeFantasia)) return false;

        if (string.IsNullOrEmpty(OficinaCnpj)) return false;

        if (string.IsNullOrEmpty(OficinaNomeResponsavel)) return false;

        if (string.IsNullOrEmpty(OficinaTelefone)) return false;

        if (string.IsNullOrEmpty(OficinaEmail)) return false;

        if (string.IsNullOrEmpty(OficinaSite)) return false;

        if (string.IsNullOrEmpty(OficinaLogradouro)) return false;

        if (string.IsNullOrEmpty(OficinaNumero)) return false;

        if (string.IsNullOrEmpty(OficinaComplemento)) return false;

        if (string.IsNullOrEmpty(OficinaBairro)) return false;

        if (string.IsNullOrEmpty(OficinaCep)) return false;

        if (string.IsNullOrEmpty(ProfissionalNome)) return false;

        if (string.IsNullOrEmpty(ProfissionalCpf)) return false;

        if (ProfissionalDataNasc > DateTime.Now) return false;

        if (ProfissionalArea <= 0) return false;

        if (string.IsNullOrEmpty(ClienteNome)) return false;

        if (string.IsNullOrEmpty(ClienteCpf)) return false;

        if (ClienteDataNasc > DateTime.Now) return false;

        if (string.IsNullOrEmpty(ClienteEmail)) return false;

        if (string.IsNullOrEmpty(ClienteTelefone)) return false;

        if (string.IsNullOrEmpty(ClienteSexo)) return false;

        if (string.IsNullOrEmpty(ClienteLogradouro)) return false;

        if (string.IsNullOrEmpty(ClienteNumero)) return false;

        if (string.IsNullOrEmpty(ClienteComplemento)) return false;

        if (string.IsNullOrEmpty(ClienteBairro)) return false;

        if (string.IsNullOrEmpty(ClienteCep)) return false;

        if (string.IsNullOrEmpty(VeiculoMarca)) return false;

        if (string.IsNullOrEmpty(VeiculoModelo)) return false;

        if (string.IsNullOrEmpty(VeiculoPlaca)) return false;

        if (VeiculoAno <= 0 || VeiculoAno > DateTime.Now.AddYears(3).Year) return false;

        if (string.IsNullOrEmpty(VeiculoCor)) return false;

        if (string.IsNullOrEmpty(VeiculoObservacao)) return false;

        if (ServicoArea <= 0) return false;

        if (string.IsNullOrEmpty(ServicoNome)) return false;

        if (ServicoValor <= 0) return false;

        if (ServicoTempoMedio <= 0) return false;

        return true;
    }
}