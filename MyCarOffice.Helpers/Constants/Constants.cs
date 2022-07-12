namespace MyCarOffice.Helpers.Constants;

public static class Constants
{
    #region Shared Constants

    public const string SystemName = "MyCarOffice - Sua oficina inteligente.";
    public const string DatetimeDefault = "GETDATE()";

    #endregion

    #region Configuração da entidade Cliente

    // Max Length
    public const int ClienteNomeMaxLength = 100;
    public const int ClienteCpfMaxLength = 14;
    public const int ClienteEmailMaxLength = 150;
    public const int ClienteTelefoneMaxLength = 14;
    public const int ClienteSexoMaxLength = 1;
    public const int ClienteLogradouroMaxLength = 100;
    public const int ClienteNumeroMaxLength = 10;
    public const int ClienteComplementoMaxLength = 100;
    public const int ClienteBairroMaxLength = 80;
    public const int ClienteCepMaxLength = 5;

    // Display
    public const string ClienteNomeDisplay = "Nome";
    public const string ClienteCpfDisplay = "CPF";
    public const string ClienteDataNascDisplay = "Data Nascimento";
    public const string ClienteEmailDisplay = "E-mail";
    public const string ClienteTelefoneDisplay = "E-mail";
    public const string ClienteSexoDisplay = "Sexo";
    public const string ClienteLogradouroDisplay = "Logradouro";
    public const string ClienteNumeroDisplay = "Número";
    public const string ClienteComplementoDisplay = "Complemento";
    public const string ClienteBairroDisplay = "Bairro";
    public const string ClienteCepDisplay = "CEP";

    // Error Required Messages
    public const string ClienteNomeErrorRequired = "O campo Nome é obrigatório!";
    public const string ClienteCpfErrorRequired = "O campo Cpf é obrigatório!";
    public const string ClienteDataNascErrorRequired = "O campo Data Nascimento é obrigatório!";
    public const string ClienteDataNascErrorAdult = "A Data Nascimento precisar ter mais de 18 anos!";
    public const string ClienteSexoErrorRequired = "O campo Sexo é obrigatório!";
    public const string ClienteLogradouroErrorRequired = "O campo Logradouro é obrigatório!";
    public const string ClienteTelefoneErrorRequired = "O campo Telefone é obrigatório!";

    // Error Max Length Messages
    public const string ClienteNomeErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string ClienteCpfErrorMaxLength = "Permitido no máximo 14 caracteres!";
    public const string ClienteEmailErrorMaxLength = "Permitido no máximo 150 caracteres!";
    public const string ClienteTelefoneErrorMaxLength = "Permitido no máximo 14 caracteres!";
    public const string ClienteSexoErrorMaxLength = "Permitido no máximo 1 caracter!";
    public const string ClienteLogradouroErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string ClienteNumeroErrorMaxLength = "Permitido no máximo 10 caracteres!";
    public const string ClienteComplementoErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string ClienteBairroErrorMaxLength = "Permitido no máximo 80 caracteres!";
    public const string ClienteCepErrorMaxLength = "Permitido no máximo 5 caracteres!";

    #endregion

    #region Configuração da entidade Especialização

    // Max Length
    public const int EspecializacaoNomeMaxLength = 100;

    // Display
    public const string EspecializacaoNomeDisplay = "Nome";
    public const string EspecializacaoSinceDisplay = "Desde";

    // Error Required Messages
    public const string EspecializacaoNomeErrorRequired = "O campo Nome é obrigatório!";
    public const string EspecializacaoSinceErrorRequired = "O campo Since é obrigatório!";
    public const string EspecializacaoSinceErrorExperience = "A especialização deve ter mais de um ano!";

    // Error Max Length Messages
    public const string EspecializacaoNomeErrorMaxLength = "Permitido no máximo 100 caracteres!";

    #endregion

    #region Configuração da entidade Oficina

    // Max Length
    public const int OficinaNomeFantasiaMaxLength = 100;
    public const int OficinaCnpjMaxLength = 14;
    public const int OficinaNomeResponsavelMaxLength = 150;
    public const int OficinaTelefoneMaxLength = 14;
    public const int OficinaEmailMaxLength = 120;
    public const int OficinaSiteMaxLength = 100;
    public const int OficinaLogradouroMaxLength = 100;
    public const int OficinaNumeroMaxLength = 10;
    public const int OficinaComplementoMaxLength = 100;
    public const int OficinaBairroMaxLength = 80;
    public const int OficinaCepMaxLength = 5;

    // Display
    public const string OficinaNomeFantasiaDisplay = "Nome Fantasia";
    public const string OficinaCnpjDisplay = "CNPJ";
    public const string OficinaNomeResponsavelDisplay = "Nome Responsável";
    public const string OficinaTelefoneDisplay = "Telefone";
    public const string OficinaEmailDisplay = "E-mail";
    public const string OficinaSiteDisplay = "URL Site";
    public const string OficinaLogradouroDisplay = "Logradouro";
    public const string OficinaNumeroDisplay = "Número";
    public const string OficinaComplementoDisplay = "Complemento";
    public const string OficinaBairroDisplay = "Bairro";
    public const string OficinaCepDisplay = "CEP";

    // Error Required Messages
    public const string OficinaNomeFantasiaErrorRequired = "O campo Nome Fantasia é obrigatório!";
    public const string OficinaCnpjErrorRequired = "O campo Cnpj é obrigatório!";
    public const string OficinaNomeResponsavelErrorRequired = "O campo Nome Responsável é obrigatório!";
    public const string OficinaTelefoneErrorRequired = "O campo Telefone é obrigatório!";
    public const string OficinaLogradouroErrorRequired = "O campo Logradouro é obrigatório!";

    // Error Max Length Messages
    public const string OficinaNomeFantasiaErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaCnpjErrorMaxLength = "Permitido no máximo 14 caracteres!";
    public const string OficinaNomeResponsavelErrorMaxLength = "Permitido no máximo 150 caracteres!";
    public const string OficinaTelefoneErrorMaxLength = "Permitido no máximo 14 caracteres!";
    public const string OficinaEmailErrorMaxLength = "Permitido no máximo 120 caracteres!";
    public const string OficinaSiteErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaLogradouroErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaNumeroErrorMaxLength = "Permitido no máximo 10 caracteres!";
    public const string OficinaComplementoErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaBairroErrorMaxLength = "Permitido no máximo 80 caracteres!";
    public const string OficinaCepErrorMaxLength = "Permitido no máximo 5 caracteres!";

    #endregion

    #region Configuração da entidade Profissional

    // Max Length
    public const int ProfissionalNomeMaxLength = 100;
    public const int ProfissionalCpfMaxLength = 11;

    // Display
    public const string ProfissionalNomeDisplay = "Nome";
    public const string ProfissionalCpfDisplay = "CPF";
    public const string ProfissionalDataNascDisplay = "Data Nascimento";
    public const string ProfissionalAreaDisplay = "Área";

    // Error Required Messages
    public const string ProfissionalNomeErrorRequired = "O campo Nome é obrigatório!";
    public const string ProfissionalCpfErrorRequired = "O campo Cpf é obrigatório!";
    public const string ProfissionalDataNascErrorRequired = "O campo Data Nascimento é obrigatório!";
    public const string ProfissionalAreaErrorRequired = "O campo Área é obrigatório!";

    // Error Max Length Messages
    public const string ProfissionalNomeErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string ProfissionalCpfErrorMaxLength = "Permitido no máximo 11 caracteres!";

    #endregion

    #region Configuração da entidade Serviço

    // Max Length
    public const int ServicoNomeMaxLength = 100;

    // Display
    public const string ServicoAreaDisplay = "Área";
    public const string ServicoNomeDisplay = "Nome";
    public const string ServicoValorDisplay = "Valor";
    public const string ServicoTempoMedioDisplay = "Tempo Médio";

    // Error Required Messages
    public const string ServicoAreaErrorRequired = "O campo Área é obrigatório!";
    public const string ServicoNomeErrorRequired = "O campo Nome é obrigatório!";
    public const string ServicoValorErrorRequired = "O campo Valor é obrigatório!";
    public const string ServicoTempoMedioErrorRequired = "O campo Tempo Médio é obrigatório!";

    // Error Max Length Messages
    public const string ServicoNomeErrorMaxLength = "Permitido no máximo 100 caracteres!";

    #endregion

    #region Configuração da entidade Veiculo

    // Max Length
    public const int VeiculoMarcaMaxLength = 100;
    public const int VeiculoModeloMaxLength = 100;
    public const int VeiculoPlacaMaxLength = 7;
    public const int VeiculoCorMaxLength = 100;
    public const int VeiculoObservacaoMaxLength = 200;

    // Display
    public const string VeiculoMarcaDisplay = "Marca";
    public const string VeiculoModeloDisplay = "Modelo";
    public const string VeiculoPlacaDisplay = "Placa";
    public const string VeiculoAnoDisplay = "Ano";
    public const string VeiculoCorDisplay = "Cor";
    public const string VeiculoObservacaoDisplay = "Observação";

    // Error Required Messages
    public const string VeiculoMarcaErrorRequired = "O campo Marca é obrigatório!";
    public const string VeiculoModeloErrorRequired = "O campo Modelo é obrigatório!";
    public const string VeiculoPlacaErrorRequired = "O campo Placa é obrigatório!";
    public const string VeiculoAnoErrorRequired = "O campo Ano é obrigatório!";

    // Error Max Length Messages
    public const string VeiculoMarcaErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string VeiculoModeloErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string VeiculoPlacaErrorMaxLength = "Permitido no máximo 7 caracteres!";
    public const string VeiculoCorErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string VeiculoObservacaoErrorMaxLength = "Permitido no máximo 200 caracteres!";

    #endregion

    #region Configuração da entidade Ordem De Servico

    // Error Required Messages
    public const string OrdemDeServicoDataHoraInicioErrorRequired = "O campo Início é obrigatório!";
    public const string OrdemDeServicoOficinaNomeFantasiaErrorRequired = "O campo Oficina Nome Fantasia é obrigatório!";
    public const string OrdemDeServicoOficinaCnpjErrorRequired = "O campo Oficina Cnpj é obrigatório!";

    public const string OrdemDeServicoOficinaNomeResponsavelErrorRequired =
        "O campo Oficina Nome Responsavel é obrigatório!";

    public const string OrdemDeServicoOficinaTelefoneErrorRequired = "O campo Oficina Telefone é obrigatório!";
    public const string OrdemDeServicoOficinaEmailErrorRequired = "O campo Oficina Email é obrigatório!";
    public const string OrdemDeServicoOficinaSiteErrorRequired = "O campo Oficina Site é obrigatório!";
    public const string OrdemDeServicoOficinaLogradouroErrorRequired = "O campo Oficina Logradouro é obrigatório!";
    public const string OrdemDeServicoOficinaNumeroErrorRequired = "O campo Oficina Numero é obrigatório!";
    public const string OrdemDeServicoOficinaComplementoErrorRequired = "O campo Oficina Complemento é obrigatório!";
    public const string OrdemDeServicoOficinaBairroErrorRequired = "O campo Oficina Bairro é obrigatório!";
    public const string OrdemDeServicoOficinaCepErrorRequired = "O campo Oficina Cep é obrigatório!";
    public const string OrdemDeServicoProfissionalNomeErrorRequired = "O campo Profissional Nome é obrigatório!";
    public const string OrdemDeServicoProfissionalCpfErrorRequired = "O campo Profissional Cpf é obrigatório!";

    public const string OrdemDeServicoProfissionalDataNascErrorRequired =
        "O campo Profissional Data Nascimento é obrigatório!";

    public const string OrdemDeServicoProfissionalAreaErrorRequired = "O campo Profissional Área é obrigatório!";
    public const string OrdemDeServicoClienteNomeErrorRequired = "O campo Cliente Nome é obrigatório!";
    public const string OrdemDeServicoClienteCpfErrorRequired = "O campo Cliente Cpf é obrigatório!";
    public const string OrdemDeServicoClienteDataNascErrorRequired = "O campo Cliente Data Nascimento é obrigatório!";
    public const string OrdemDeServicoClienteEmailErrorRequired = "O campo Cliente Email é obrigatório!";
    public const string OrdemDeServicoClienteTelefoneErrorRequired = "O campo Cliente Telefone é obrigatório!";
    public const string OrdemDeServicoClienteSexoErrorRequired = "O campo Cliente Sexo é obrigatório!";
    public const string OrdemDeServicoClienteLogradouroErrorRequired = "O campo Cliente Logradouro é obrigatório!";
    public const string OrdemDeServicoClienteNumeroErrorRequired = "O campo Cliente Número é obrigatório!";
    public const string OrdemDeServicoClienteComplementoErrorRequired = "O campo Cliente Complemento é obrigatório!";
    public const string OrdemDeServicoClienteBairroErrorRequired = "O campo Cliente Bairro é obrigatório!";
    public const string OrdemDeServicoClienteCepErrorRequired = "O campo Cliente Cep é obrigatório!";
    public const string OrdemDeServicoVeiculoMarcaErrorRequired = "O campo Veiculo Marca é obrigatório!";
    public const string OrdemDeServicoVeiculoModeloErrorRequired = "O campo Veiculo Modelo é obrigatório!";
    public const string OrdemDeServicoVeiculoPlacaErrorRequired = "O campo Veiculo Placa é obrigatório!";
    public const string OrdemDeServicoVeiculoAnoErrorRequired = "O campo Veiculo Ano é obrigatório!";
    public const string OrdemDeServicoServicoAreaErrorRequired = "O campo Serviço Área é obrigatório!";
    public const string OrdemDeServicoServicoNomeErrorRequired = "O campo Serviço Nome é obrigatório!";
    public const string OrdemDeServicoServicoValorErrorRequired = "O campo Serviço Valor é obrigatório!";
    public const string OrdemDeServicoServicoTempoMedioErrorRequired = "O Serviço Tempo Médio Marca é obrigatório!";

    // Display
    public const string OrdemDeServicoDataHoraInicioDisplay = "Início";
    public const string OrdemDeServicoDataHoraEncerramentoDisplay = "Encerramento";
    public const string OrdemDeServicoTempoTotalDisplay = "Tempo Total";
    public const string OrdemDeServicoOficinaNomeFantasiaDisplay = "Oficina Nome Fantasia";
    public const string OrdemDeServicoOficinaCnpjDisplay = "Oficina CNPJ";
    public const string OrdemDeServicoOficinaNomeResponsavelDisplay = "Oficina Nome Responsável";
    public const string OrdemDeServicoOficinaTelefoneDisplay = "Oficina Telefone";
    public const string OrdemDeServicoOficinaEmailDisplay = "Oficina E-mail";
    public const string OrdemDeServicoOficinaSiteDisplay = "Oficina URL Site";
    public const string OrdemDeServicoOficinaLogradouroDisplay = "Oficina Logradouro";
    public const string OrdemDeServicoOficinaNumeroDisplay = "Oficina Número";
    public const string OrdemDeServicoOficinaComplementoDisplay = "Oficina Complemento";
    public const string OrdemDeServicoOficinaBairroDisplay = "Oficina Bairro";
    public const string OrdemDeServicoOficinaCepDisplay = "Oficina CEP";
    public const string OrdemDeServicoProfissionalNomeDisplay = "Profissional Nome";
    public const string OrdemDeServicoProfissionalCpfDisplay = "Profissional CPF";
    public const string OrdemDeServicoProfissionalDataNascDisplay = "Profissional Data Nascimento";
    public const string OrdemDeServicoProfissionalAreaDisplay = "Profissional Área";
    public const string OrdemDeServicoClienteNomeDisplay = "Cliente Nome";
    public const string OrdemDeServicoClienteCpfDisplay = "Cliente CPF";
    public const string OrdemDeServicoClienteDataNascDisplay = "Cliente Data Nascimento";
    public const string OrdemDeServicoClienteEmailDisplay = "Cliente E-mail";
    public const string OrdemDeServicoClienteTelefoneDisplay = "Cliente E-mail";
    public const string OrdemDeServicoClienteSexoDisplay = "Cliente Sexo";
    public const string OrdemDeServicoClienteLogradouroDisplay = "Cliente Logradouro";
    public const string OrdemDeServicoClienteNumeroDisplay = "Cliente Número";
    public const string OrdemDeServicoClienteComplementoDisplay = "Cliente Complemento";
    public const string OrdemDeServicoClienteBairroDisplay = "Cliente Bairro";
    public const string OrdemDeServicoClienteCepDisplay = "Cliente CEP";
    public const string OrdemDeServicoVeiculoMarcaDisplay = "Veiculo Marca";
    public const string OrdemDeServicoVeiculoModeloDisplay = "Veiculo Modelo";
    public const string OrdemDeServicoVeiculoPlacaDisplay = "Veiculo Placa";
    public const string OrdemDeServicoVeiculoAnoDisplay = "Veiculo Ano";
    public const string OrdemDeServicoVeiculoCorDisplay = "Veiculo Cor";
    public const string OrdemDeServicoVeiculoObservacaoDisplay = "Veiculo Observação";
    public const string OrdemDeServicoServicoAreaDisplay = "Serviço Área";
    public const string OrdemDeServicoServicoNomeDisplay = "Serviço Nome";
    public const string OrdemDeServicoServicoValorDisplay = "Serviço Valor";
    public const string OrdemDeServicoServicoTempoMedioDisplay = "Serviço Tempo Médio";

    // Error Required Messages


    // Error Max Length Messages

    #endregion
}