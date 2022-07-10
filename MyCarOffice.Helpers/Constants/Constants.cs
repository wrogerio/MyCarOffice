using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarOffice.Helpers.Constants;

public static class Constants
{
    #region Shared Constants
    public const string SystemName = "MyCarOffice - Sua oficina inteligente.";
    public const string DatetimeDefault = "GETDATE()";
    public const int EnderecoLogradouroMaxLength = 100;
    public const int EnderecoNumeroMaxLength = 10;
    public const int EnderecoComplementoMaxLength = 100;
    public const int EnderecoBairroMaxLength = 80;
    public const int EnderecoCepMaxLength = 5;
    public const int TelefoneMaxLength = 14;
    // Error Required Messages
    public const string EnderecoLogradouroErrorRequired = "O campo Logradouro é obrigatório!";
    // Error Max Length Messages
    public const string EnderecoLogradouroErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string EnderecoNumeroErrorMaxLength = "Permitido no máximo 10 caracteres!";
    public const string EnderecoComplementoErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string EnderecoBairroErrorMaxLength = "Permitido no máximo 80 caracteres!";
    public const string EnderecoCepErrorMaxLength = "Permitido no máximo 5 caracteres!";
    public const string TelefoneErrorMaxLength = "Permitido no máximo 14 caracteres!";
    #endregion

    #region Configuração da entidade Cliente
    // Max Length
    public const int ClienteNomeMaxLength = 100;
    public const int ClienteCpfMaxLength = 14;
    public const int ClienteEmailMaxLength = 150;
    public const int ClienteSexoMaxLength = 1;
    // Display
    public const string ClienteNomeDisplay = "Nome";
    public const string ClienteCpfDisplay = "CPF";
    public const string ClienteDataNascDisplay = "Data Nascimento";
    public const string ClienteEmailDisplay = "E-mail";
    public const string ClienteSexoDisplay = "Sexo";
    public const string ClienteTelefoneDisplay = "Telefone";
    public const string ClienteLogradouroDisplay = "Logradouro";
    public const string ClienteNumeroDisplay = "Número";
    public const string ClienteComplementoDisplay = "Complemento";
    public const string ClienteBairroDisplay = "Bairro";
    public const string ClienteCepDisplay = "CEP";
    // Error Required Messages
    public const string ClienteNomeErrorRequired = "O campo Nome é obrigatório!";
    public const string ClienteCpfErrorRequired = "O campo Cpf é obrigatório!";
    public const string ClienteDataNascErrorRequired = "O campo Data Nascimento é obrigatório!";
    public const string ClienteSexoErrorRequired = "O campo Sexo é obrigatório!";
    public const string ClienteLogradouroErrorRequired = "O campo Logradouro é obrigatório!";
    public const string ClienteTelefoneErrorRequired = "O campo Telefone é obrigatório!";
    // Error Max Length Messages
    public const string ClienteNomeErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string ClienteCpfErrorMaxLength = "Permitido no máximo 14 caracteres!";
    public const string ClienteEmailErrorMaxLength = "Permitido no máximo 150 caracteres!";
    public const string ClienteSexolErrorMaxLength = "Permitido no máximo 1 caracteres!";
    #endregion

    #region Configuração da entidade Especialização
    public const int EspecializacaoNomeMaxLength = 100;
    public const string EspecializacaoNomeDisplay = "Nome";
    #endregion

    #region Configuração da entidade Oficina
    public const int OficinaNomeFantasiaMaxLength = 100;
    public const int OficinaCnpjMaxLength = 14;
    public const int OficinaNomeResponsavelMaxLength = 150;
    public const int OficinaEmailMaxLength = 120;
    public const int OficinaSiteMaxLength = 100;
    public const string OficinaNomeFantasiaDisplay = "Nome Fantasia";
    public const string OficinaCnpjDisplay = "CNPJ";
    public const string OficinaNomeResponsavelDisplay = "Nome Responsável";
    public const string OficinaTelefoneDisplay = "Telefone";
    public const string OficinaEmailDisplay = "E-mail";
    public const string OficinaSiteDisplay = "URL Site";
    #endregion

    #region Configuração da entidade Profissional
    public const int ProfissionalNomeMaxLength = 150;
    public const int ProfissionalCpfMaxLength = 11;
    public const string ProfissionalNomeDisplay = "Nome Fantasia";
    public const string ProfissionalCpfDisplay = "CPF";
    #endregion

    #region Configuração da entidade Serviço
    public const int ServicoNomeMaxLength = 100;
    public const string ServicoNomeDisplay = "Nome";
    #endregion

    #region Configuração da entidade Veiculo
    public const int VeiculoMarcaMaxLength = 100;
    public const int VeiculoModeloMaxLength = 100;
    public const int VeiculoPlacaMaxLength = 7;
    public const int VeiculoCorMaxLength = 100;
    public const int VeiculoObservacaoMaxLength = 200;
    public const string VeiculoMarcaDisplay = "Marca";
    public const string VeiculoModeloDisplay = "Modelo";
    public const string VeiculoPlacaDisplay = "Placa";
    public const string VeiculoCorDisplay = "Cor";
    public const string VeiculoObservacaoDisplay = "Observação";
    #endregion
}