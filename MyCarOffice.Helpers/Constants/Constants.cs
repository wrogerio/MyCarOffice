using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarOffice.Helpers.Constants
{
    public static class Constants
    {
        // Shared Constants
        public const string SystemName = "MyCarOffice - Sua oficina inteligente.";
        public const string DatetimeDefault = "GETDATE()";

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
        public const int ProfissionalNomeFantasiaMaxLength = 150;
        public const int ProfissionalCpfMaxLength = 11;
        public const string ProfissionalNomeFantasiaMaxDisplayName = "Nome Fantasia";
        public const string ProfissionalCpfMaxDisplayName = "CPF";
        
        // Configuração Especializacao
        public const int EspecializacaoNomeMaxLength = 100;
        public const string EspecializacaoNomeDisplayName = "Especialização";
    }
}
