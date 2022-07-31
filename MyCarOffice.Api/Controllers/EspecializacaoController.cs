using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs.Especializacao;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class EspecializacaoController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUow _uow;
    private readonly IEspecializacaoService _especializacaoService;

    public EspecializacaoController(IEspecializacaoService especializacaoService, IUow uow, IMapper mapper)
    {
        _especializacaoService = especializacaoService;
        _uow = uow;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var especializacoes = await _especializacaoService.GetAllAsync();
        return Ok(especializacoes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var especializacao = await _especializacaoService.GetByIdAsync(id);
        return Ok(especializacao);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EspecializacaoDtoCreate especializacaoDtoCreate)
    {
        var responseModel = new ResponseModel();

        // create localy
        await _especializacaoService.CreateAsync(especializacaoDtoCreate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Especializacao created successfully!";
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
    public async Task<IActionResult> Put(Guid id, [FromBody] EspecializacaoDtoUpdate especializacaoDtoUpdate)
    {
        var responseModel = new ResponseModel();
        especializacaoDtoUpdate.Id = id;

        // create localy
        await _especializacaoService.UpdateAsync(especializacaoDtoUpdate);
        try
        {
            // try to commit
            await _uow.Commit();

            var x = await _especializacaoService.GetByIdAsync(id);

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Especializacao updated successfully!";
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

        var especializacao = await _especializacaoService.GetByIdAsync(id);
        var especializacaoDto = _mapper.Map<EspecializacaoDto>(especializacao);

        // create localy
        await _especializacaoService.RemoveAsync(especializacaoDto);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Especializacao removed successfully!";
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