using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs.Oficina;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class OficinaController : ControllerBase
{
    private readonly IOficinaService _oficinaService;
    private readonly IMapper _mapper;
    private readonly IUow _uow;

    public OficinaController(IOficinaService oficinaService, IUow uow, IMapper mapper)
    {
        _oficinaService = oficinaService;
        _uow = uow;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var oficinas = await _oficinaService.GetAllAsync();
        return Ok(oficinas);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var oficina = await _oficinaService.GetByIdAsync(id);
        return Ok(oficina);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] OficinaDtoCreate oficinaDtoCrate)
    {
        var responseModel = new ResponseModel();

        // create localy
        await _oficinaService.CreateAsync(oficinaDtoCrate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Oficina created successfully!";
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
    public async Task<IActionResult> Put(Guid id, [FromBody] OficinaDtoUpdate oficinaDtoUpdate)
    {
        var responseModel = new ResponseModel();
        oficinaDtoUpdate.Id = id;

        // create localy
        await _oficinaService.UpdateAsync(oficinaDtoUpdate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Oficina updated successfully!";
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

        var oficina = await _oficinaService.GetByIdAsync(id);
        var oficinaDto = _mapper.Map<OficinaDto>(oficina);

        // create localy
        await _oficinaService.RemoveAsync(oficinaDto);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Oficina removed successfully!";
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