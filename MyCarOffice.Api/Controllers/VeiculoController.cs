using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs.Commands;
using MyCarOffice.Application.DTOs.Commands.Create;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.DTOs.Veiculos;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class VeiculoController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUow _uow;
    private readonly IVeiculoService _veiculoService;

    public VeiculoController(IVeiculoService veiculoService, IUow uow, IMapper mapper)
    {
        _veiculoService = veiculoService;
        _uow = uow;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var veiculos = await _veiculoService.GetAllAsync();
        return Ok(veiculos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var veiculo = await _veiculoService.GetByIdAsync(id);
        return Ok(veiculo);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] VeiculoDtoCreate veiculoDtoCreate)
    {
        var responseModel = new ResponseModel();

        // create localy
        await _veiculoService.CreateAsync(veiculoDtoCreate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Veiculo created successfully!";
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
    public async Task<IActionResult> Put(Guid id, [FromBody] VeiculoDtoUpdate veiculoDtoUpdate)
    {
        var responseModel = new ResponseModel();
        veiculoDtoUpdate.Id = id;

        // create localy
        await _veiculoService.UpdateAsync(veiculoDtoUpdate);
        try
        {
            // try to commit
            await _uow.Commit();

            var x = await _veiculoService.GetByIdAsync(id);

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Veiculo updated successfully!";
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

        var veiculo = await _veiculoService.GetByIdAsync(id);
        var veiculoDto = _mapper.Map<VeiculoDto>(veiculo);

        // create localy
        await _veiculoService.RemoveAsync(veiculoDto);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Veiculo removed successfully!";
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