using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs.Servico;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class ServicoController : ControllerBase
{
    private readonly IServicoService _servicoService;
    private readonly IMapper _mapper;
    private readonly IUow _uow;

    public ServicoController(IServicoService servicoService, IUow uow, IMapper mapper)
    {
        _servicoService = servicoService;
        _uow = uow;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var servicos = await _servicoService.GetAllAsync();
        return Ok(servicos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var servico = await _servicoService.GetByIdAsync(id);
        return Ok(servico);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ServicoDtoCreate servicoDtoCrate)
    {
        var responseModel = new ResponseModel();

        // create localy
        await _servicoService.CreateAsync(servicoDtoCrate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Servico created successfully!";
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
    public async Task<IActionResult> Put(Guid id, [FromBody] ServicoDtoUpdate servicoDtoUpdate)
    {
        var responseModel = new ResponseModel();
        servicoDtoUpdate.Id = id;

        // create localy
        await _servicoService.UpdateAsync(servicoDtoUpdate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Servico updated successfully!";
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

        var servico = await _servicoService.GetByIdAsync(id);
        var servicoDto = _mapper.Map<ServicoDto>(servico);

        // create localy
        await _servicoService.RemoveAsync(servicoDto);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Servico removed successfully!";
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