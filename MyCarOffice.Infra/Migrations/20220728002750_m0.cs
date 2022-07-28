using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCarOffice.Infra.Migrations
{
    public partial class m0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbClientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbOficinas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    NomeResponsavel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    Site = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbOficinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbOrdensDeServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OficinaNomeFantasia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OficinaCnpj = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    OficinaNomeResponsavel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OficinaTelefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    OficinaEmail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    OficinaSite = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OficinaLogradouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OficinaNumero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    OficinaComplemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OficinaBairro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    OficinaCep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    ProfissionalNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProfissionalCpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ProfissionalDataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfissionalArea = table.Column<int>(type: "int", nullable: false),
                    ClienteNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClienteCpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    ClienteDataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ClienteTelefone = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    ClienteSexo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    ClienteLogradouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClienteNumero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ClienteComplemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClienteBairro = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ClienteCep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    VeiculoMarca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VeiculoModelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VeiculoPlaca = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    VeiculoAno = table.Column<int>(type: "int", nullable: false),
                    VeiculoCor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VeiculoObservacao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ServicoArea = table.Column<int>(type: "int", nullable: false),
                    ServicoNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServicoValor = table.Column<double>(type: "float", nullable: false),
                    ServicoTempoMedio = table.Column<double>(type: "float", nullable: false),
                    Concluida = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbOrdensDeServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbProfissionais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DataNasc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProfissionais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbServicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    TempoMedio = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbServicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbVeiculos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Observacao = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbVeiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbVeiculos_tbClientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tbClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbEspecializacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Since = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfissionalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEspecializacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbEspecializacoes_tbProfissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "tbProfissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbEspecializacoes_ProfissionalId",
                table: "tbEspecializacoes",
                column: "ProfissionalId");

            migrationBuilder.CreateIndex(
                name: "IX_tbVeiculos_ClienteId",
                table: "tbVeiculos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbEspecializacoes");

            migrationBuilder.DropTable(
                name: "tbOficinas");

            migrationBuilder.DropTable(
                name: "tbOrdensDeServico");

            migrationBuilder.DropTable(
                name: "tbServicos");

            migrationBuilder.DropTable(
                name: "tbVeiculos");

            migrationBuilder.DropTable(
                name: "tbProfissionais");

            migrationBuilder.DropTable(
                name: "tbClientes");
        }
    }
}
