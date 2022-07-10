﻿using System;
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
    // Max Length
    public const int EspecializacaoNomeMaxLength = 100;
    // Display
    public const string EspecializacaoNomeDisplay = "Nome";
    // Error Required Messages
    public const string EspecializacaoNomeErrorRequired = "O campo Nome é obrigatório!";
    public const string EspecializacaoSinceErrorRequired = "O campo Since é obrigatório!";
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
    public const int OficinaNumeroMaxLength = 6;
    public const int OficinaComplementoMaxLength = 6;
    public const int OficinaBairroMaxLength = 100;
    public const int OficinaCepMaxLength = 8;
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
    public const string OficinaCnpjErrorRequired = "O campo Cpf é obrigatório!";
    public const string OficinaNomeResponsavelErrorRequired = "O campo Nome Responsável é obrigatório!";
    public const string OficinaTelefoneErrorRequired = "O campo Telefone é obrigatório!";
    public const string OficinaLogradouroErrorRequired = "O campo Logradouro é obrigatório!";
    public const string OficinaNumeroErrorRequired = "O campo Número é obrigatório!";
    // Error Max Length Messages
    public const string OficinaNomeFantasiaErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaCnpjErrorMaxLength = "Permitido no máximo 14 caracteres!";
    public const string OficinaNomeResponsavelErrorMaxLength = "Permitido no máximo 150 caracteres!";
    public const string OficinaEmailErrorMaxLength = "Permitido no máximo 120 caracteres!";
    public const string OficinaSiteErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaLogradouroErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaNumeroErrorMaxLength = "Permitido no máximo 6 caracteres!";
    public const string OficinaComplementoErrorMaxLength = "Permitido no máximo 6 caracteres!";
    public const string OficinaBairroErrorMaxLength = "Permitido no máximo 100 caracteres!";
    public const string OficinaCepErrorMaxLength = "Permitido no máximo 8 caracteres!";


    #endregion

    #region Configuração da entidade Profissional
    // Max Length
    public const int ProfissionalNomeMaxLength = 100;
    public const int ProfissionalCpfMaxLength = 11;
    // Display
    public const string ProfissionalNomeDisplay = "Nome Fantasia";
    public const string ProfissionalCpfDisplay = "CPF";
    public const string ProfissionalDataNascDisplay = "Data Nascimento";
    public const string ProfissionalAreaDisplay = "Área";
    // Error Required Messages
    public const string ProfissionalNomeErrorRequired = "O campo Nome é obrigatório!";
    public const string ProfissionalCpfeErrorRequired = "O campo Cpf é obrigatório!";
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
}