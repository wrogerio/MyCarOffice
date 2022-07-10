using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarOffice.Helpers.Constants;

public static class Constants
{
    // Shared Constants
    public const string SystemName = "MyCarOffice - Sua oficina inteligente.";
    public const string DatetimeDefault = "GETDATE()";
    public const int EnderecoLogradouroMaxLength = 100;
    public const int EnderecoNumeroMaxLength = 10;

    // Configuração Cliente
    public const int ClienteNomeMaxLength = 100;
    public const int ClienteCpfMaxLength = 14;
    public const int ClienteEmailMaxLength = 120;
    public const int ClienteSexoMaxLength = 9;
    public const int ClienteTelefoneMaxLength = 14;
    public const string ClienteNomeDisplayName = "Nome";
    public const string ClienteCpfDisplayName = "CPF";
    public const string ClienteEmailDisplayName = "Email";
    public const string ClienteSexoDisplayName = "Sexo";
    public const string ClienteTelefoneDisplayName = "Telefone";

    // Configuração Especialização
    public const int EspecializacaoNomeMaxLength = 100;
    public const string EspecializacaoNomeDisplayName = "Nome";

    // Configuração Oficina
    public const int OficinaNomeFantasiaMaxLength = 100;
    public const int OficinaCnpjMaxLength = 14;
    public const int OficinaNomeResponsavelMaxLength = 150;
    public const int OficinaTelefoneMaxLength = 14;
    public const int OficinaEmailMaxLength = 120;
    public const int OficinaSiteMaxLength = 100;
    public const string OficinaNomeFantasiaDisplayName = "Nome Fantasia";
    public const string OficinaCnpjDisplayName = "CNPJ";
    public const string OficinaNomeResponsavelDisplayName = "Nome Responsável";
    public const string OficinaTelefoneDisplayName = "Telefone";
    public const string OficinaEmailDisplayName = "E-mail";
    public const string OficinaSiteDisplayName = "URL Site";

    // Configuração Profissional
    public const int ProfissionalNomeMaxLength = 150;
    public const int ProfissionalCpfMaxLength = 11;
    public const string ProfissionalNomeDisplayName = "Nome Fantasia";
    public const string ProfissionalCpfDisplayName = "CPF";

    // Configuração Serviço
    public const int ServicoNomeMaxLength = 100;
    public const string ServicoNomeDisplayName = "Nome";

    // Configuração Veículo
    public const int VeiculoMarcaMaxLength = 100;
    public const int VeiculoModeloMaxLength = 100;
    public const int VeiculoPlacaMaxLength = 7;
    public const int VeiculoCorMaxLength = 100;
    public const int VeiculoObservacaoMaxLength = 200;
    public const string VeiculoMarcaDisplayName = "Marca";
    public const string VeiculoModeloDisplayName = "Modelo";
    public const string VeiculoPlacaDisplayName = "Placa";
    public const string VeiculoCorDisplayName = "Cor";
    public const string VeiculoObservacaoDisplayName = "Observação";
}