using MyCarOffice.Domain.Enums;

namespace MyCarOffice.Domain.Entities
{
    public class OrdemDeServico : EntityBase
    {
        public DateTime DataHoraInicio { get; private set; } = DateTime.Now;
        public string ClienteNome { get; private set; } = "";
        public string ClienteCPF { get; private set; } = "";
        public string ClienteEmail { get; private set; } = "";
        public string ClienteTelefone { get; private set; } = "";
        public string VeiculoMarca { get; private set; } = "";
        public string VeiculoModelo { get; private set; } = "";
        public string VeiculoPlaca { get; private set; } = "";
        public int VeiculoAno { get; private set; }
        public string VeiculoCor { get; set; } = "";
        public AreaEnum ServicoArea { get; private set; } = AreaEnum.Mecanica;
        public string ServicoNome { get; private set; } = "";
        public decimal ServicoValor { get; private set; }
        public DateTime? DataHoraEncerramento { get; set; }
        public DateTime? TempoTotal { get; set; }
        public string ProfissionalNome { get; private set; } = "";
        public string ProfissionalCPF { get; private set; } = "";
        public string OficinaNomeFantasia { get; private set; } = "";
        public string OficinaCNPJ { get; private set; } = "";
        public string OficinaFone { get; private set; } = "";
        public string OficinaEmail { get; set; } = "";
        public string OficinaNomeResponsavel { get; private set; } = "";


        public OrdemDeServico(DateTime dataHoraInicio, string clienteNome, string clienteCPF, string clienteEmail, string clienteTelefone, string veiculoMarca, string veiculoModelo, string veiculoPlaca, int veiculoAno, AreaEnum servicoArea, string servicoNome, decimal servicoValor, string profissionalNome, string profissionalCPF, string oficinaNomeFantasia, string oficinaCNPJ, string oficinaFone, string oficinaNomeResponsavel)
        {
            if (Validar())
            {
                DataHoraInicio = dataHoraInicio;
                ClienteNome = clienteNome;
                ClienteCPF = clienteCPF;
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
                ProfissionalCPF = profissionalCPF;
                OficinaNomeFantasia = oficinaNomeFantasia;
                OficinaCNPJ = oficinaCNPJ;
                OficinaFone = oficinaFone;
                OficinaNomeResponsavel = oficinaNomeResponsavel;
            }
        }

        private bool Validar()
        {
            // DataHora Inicio
            if (DataHoraInicio.Equals(null)) return false;

            // Cliente Nome
            if (string.IsNullOrEmpty(ClienteNome)) return false;

            // Cliente CPF
            if (string.IsNullOrEmpty(ClienteCPF)) return false;

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
            if (string.IsNullOrEmpty(ProfissionalCPF)) return false;

            // Oficina Nome Fantasia
            if (string.IsNullOrEmpty(OficinaNomeFantasia)) return false;

            // Oficina CNPJ
            if (string.IsNullOrEmpty(OficinaCNPJ)) return false;

            // Oficina Fone
            if (string.IsNullOrEmpty(OficinaFone)) return false;

            // Oficina Nome Responsável
            if (string.IsNullOrEmpty(OficinaNomeResponsavel)) return false;

            return true;
        }
    }
}
