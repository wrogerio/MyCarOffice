﻿
namespace MyCarOffice.Domain.ValueObjects
{
    public class Endereco
    {
        public string Logradouro { get; set; } = "";
        public string Numero { get; set; } = "";
        public string Complemento { get; set; } = "";
        public string Bairro { get; set; } = "";
        public string CEP { get; set; } = "";

        public Endereco(string logradouro, string numero)
        {
            Logradouro = logradouro;
            Numero = numero;
        }
    }
}
