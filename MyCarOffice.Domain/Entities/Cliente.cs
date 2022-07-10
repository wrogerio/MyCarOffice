using MyCarOffice.Domain.ValueObjects;

namespace MyCarOffice.Domain.Entities
{
    public class Cliente : EntityBase
    {
        public string Nome { get; private set; } = "";
        public string CPF { get; private set; } = "";
        public DateTime DataNasc { get; private set; } = DateTime.Now;
        public string Email { get; private set; } = "";
        public string Sexo { get; private set; } = "";
        public string Logradouro { get; private set; } = "";
        public string Numero { get; private set; } = "";
        public string Telefone { get; private set; } = "";

        // Relacionamentos
        public virtual IEnumerable<Veiculo>? Veiculos { get; set; }

        public Cliente(string nome, string cPF, DateTime dataNasc, string email, string sexo, string logradouro, string numero, string telefone)
        {
            if (Validar())
            {
                Nome = nome;
                CPF = cPF;
                DataNasc = dataNasc;
                Email = email;
                Sexo = sexo;
                Logradouro = logradouro;
                Numero = numero;
                Telefone = telefone;
            }
        }

        private bool Validar()
        {
            // Nome 
            if (string.IsNullOrEmpty(Nome)) return false;

            // CPF 
            if (string.IsNullOrEmpty(CPF)) return false;

            // Data Nascimento
            if (DataNasc.Equals(null)) return false;

            // Email 
            if (string.IsNullOrEmpty(Email)) return false;

            // Sexo 
            if (string.IsNullOrEmpty(Sexo)) return false;

            // Logradouro 
            if (string.IsNullOrEmpty(Logradouro)) return false;

            // Numero 
            if (string.IsNullOrEmpty(Numero)) return false;

            // Telefone
            if (string.IsNullOrEmpty(Telefone)) return false;

            return true;
        }
    }
}
