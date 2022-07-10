using MyCarOffice.Domain.ValueObjects;

namespace MyCarOffice.Domain.Entities
{
    public class Oficina : EntityBase
    {
        public string NomeFantasia { get; private set; } = "";
        public string CNPJ { get; private set; } = "";
        public string NomeResponsavel { get; private set; } = "";
        public string Telefone { get; private set; } = "";
        public string Email { get; set; } = "";
        public string Site { get; set; } = "";
        public string Logradouro { get; private set; } = "";
        public string Numero { get; private set; } = "";

        public Oficina(string nomeFantasia, string cNPJ, string nomeResponsavel, string telefone, string logradouro, string numero)
        {
            if (Validar())
            {
                NomeFantasia = nomeFantasia;
                CNPJ = cNPJ;
                NomeResponsavel = nomeResponsavel;
                Telefone = telefone;
                Logradouro = logradouro;
                Numero = numero;
            }
        }

        private bool Validar()
        {
            // Nome Fantasia
            if (string.IsNullOrEmpty(NomeFantasia)) return false;

            // CNPJ
            if (string.IsNullOrEmpty(CNPJ)) return false;

            // Nome Responsável
            if (string.IsNullOrEmpty(NomeResponsavel)) return false;

            // Telefone
            if (string.IsNullOrEmpty(Telefone)) return false;

            // Logradouro
            if (string.IsNullOrEmpty(Logradouro)) return false;

            // Numero
            if (string.IsNullOrEmpty(Numero)) return false;

            return true;
        }
    }
}
