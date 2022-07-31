using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs.OrdemDeServico;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = false)]
public class OrdemDeServicoController : ControllerBase
{
    private readonly IOrdemDeServicoService _ordemDeServicoService;
    private readonly IMapper _mapper;
    private readonly IUow _uow;

    public OrdemDeServicoController(IOrdemDeServicoService ordemDeServicoService, IUow uow, IMapper mapper)
    {
        _ordemDeServicoService = ordemDeServicoService;
        _uow = uow;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var ordensDeServicos = await _ordemDeServicoService.GetAllAsync();
        return Ok(ordensDeServicos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var ordemDeServico = await _ordemDeServicoService.GetByIdAsync(id);
        return Ok(ordemDeServico);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] OrdemDeServicoDtoCreate ordemDeServicoDtoCrate)
    {
        var responseModel = new ResponseModel();

        // create localy
        await _ordemDeServicoService.CreateAsync(ordemDeServicoDtoCrate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "OrdemDeServico created successfully!";
            return Ok(responseModel);
        }
        catch (Exception ex)
        {
            // rolback actions
            await _uow.RollBack();

            // return response to caller
            responseModel.IsError = true;
            responseModel.Message = ex.Message;
            return BadRequest(responseModel);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] OrdemDeServicoDtoUpdate ordemDeServicoDtoUpdate)
    {
        var responseModel = new ResponseModel();
        ordemDeServicoDtoUpdate.Id = id;

        // create localy
        await _ordemDeServicoService.UpdateAsync(ordemDeServicoDtoUpdate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "OrdemDeServico updated successfully!";
            return Ok(responseModel);
        }
        catch (Exception ex)
        {
            // rolback actions
            await _uow.RollBack();

            // return response to caller
            responseModel.IsError = true;
            responseModel.Message = ex.Message;
            return BadRequest(responseModel);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var responseModel = new ResponseModel();

        var ordemDeServico = await _ordemDeServicoService.GetByIdAsync(id);
        var ordemDeServicoDto = _mapper.Map<OrdemDeServicoDto>(ordemDeServico);

        // create localy
        await _ordemDeServicoService.RemoveAsync(ordemDeServicoDto);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "OrdemDeServico removed successfully!";
            return Ok(responseModel);
        }
        catch (Exception ex)
        {
            // rolback actions
            await _uow.RollBack();

            // return response to caller
            responseModel.IsError = true;
            responseModel.Message = ex.Message;
            return BadRequest(responseModel);
        }
    }
}