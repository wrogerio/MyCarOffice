using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Helpers.Constants;
using MyCarOffice.Helpers.Methods;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class VeiculoController: ControllerBase
{
    private readonly IVeiculoService _veiculoService;
    private readonly IUow _uow;
    private readonly IMapper _mapper;

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
        var veiculosDto = _mapper.Map<List<VeiculoDto>>(veiculos);

        return Ok(veiculosDto);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var veiculo = await _veiculoService.GetByIdAsync(id);
        var veiculoDto = _mapper.Map<VeiculoDto>(veiculo);

        return Ok(veiculoDto);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] VeiculoDto veiculoDto)
    {
        var responseModel = new ResponseModel();
            
        // valid requireds
        if (!MyOfficeMethods.ValidarRequeridos<VeiculoDto>(veiculoDto)) return BadRequest(Constants.ErrorRequired);
            
        // create localy
        veiculoDto = await _veiculoService.CreateAsync(veiculoDto);
        try
        {
            // try to commit
            await _uow.Commit();
                
            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Veiculo created successfully!";
            responseModel.Data = veiculoDto;
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
    public async Task<IActionResult> Put(Guid id, [FromBody] VeiculoDto veiculoDto)
    {
        var responseModel = new ResponseModel();
            
        // valid requireds
        if (!MyOfficeMethods.ValidarRequeridos<VeiculoDto>(veiculoDto)) return BadRequest(Constants.ErrorRequired);

        veiculoDto.Id = id;
            
        // create localy
        veiculoDto = await _veiculoService.UpdateAsync(veiculoDto);
        try
        {
            // try to commit
            await _uow.Commit();
                
            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Veiculo updated successfully!";
            responseModel.Data = veiculoDto;
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
            
        // valid requireds
        if (!MyOfficeMethods.ValidarRequeridos<VeiculoDto>(veiculoDto)) return BadRequest(Constants.ErrorRequired);
            
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