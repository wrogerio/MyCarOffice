using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Application.Mapping;
using MyCarOffice.Application.Services;
using MyCarOffice.Application.Validations;
using MyCarOffice.Infra.Context;
using MyCarOffice.Infra.Interfaces;
using MyCarOffice.Infra.Repositories;
using MyCarOffice.Uow;

namespace MyCarOffice.IoC;

public static class NativeInjector
{
    public static void RegisterApps(this IServiceCollection _service)
    {
        // Services
        _service.AddScoped<IClienteService, ClienteService>();
        _service.AddScoped<IEspecializacaoService, EspecializacaoService>();
        _service.AddScoped<IOficinaService, OficinaService>();
        _service.AddScoped<IOrdemDeServicoService, OrdemDeServicoService>();
        _service.AddScoped<IProfissionalService, ProfissionalService>();
        _service.AddScoped<IServicoService, ServicoService>();
        _service.AddScoped<IVeiculoService, VeiculoService>();

        // Repositories
        _service.AddScoped<IClienteRepository, ClienteRepository>();
        _service.AddScoped<IEspecializacaoRepository, EspecializacaoRepository>();
        _service.AddScoped<IOficinaRepository, OficinaRepository>();
        _service.AddScoped<IOrdemDeServicoRepository, OrdemDeServicoRepository>();
        _service.AddScoped<IProfissionalRepository, ProfissionalRepository>();
        _service.AddScoped<IServicoRepository, ServicoRepository>();
        _service.AddScoped<IVeiculoRepository, VeiculoRepository>();

        // FLuent Validation
        _service.AddScoped<IValidator<ClienteDto>, ClienteValidation>();
        _service.AddScoped<IValidator<EspecializacaoDto>, EspecializacaoValidation>();
        _service.AddScoped<IValidator<OficinaDto>, OficinaValidation>();
        _service.AddScoped<IValidator<OrdemDeServicoDto>, OrdemDeServicoValidation>();
        _service.AddScoped<IValidator<ProfissionalDto>, ProfissionalValidation>();
        _service.AddScoped<IValidator<ServicoDto>, ServicoValidation>();
        _service.AddScoped<IValidator<VeiculoDto>, VeiculoValidation>();

        // Unit of Work
        _service.AddScoped<IUow, Uow.Uow>();

        // AutoMapper
        _service.AddAutoMapper(typeof(MappingProfile));

        // DbContext
        _service.AddDbContext<MyCarOfficeContext>();
    }
}