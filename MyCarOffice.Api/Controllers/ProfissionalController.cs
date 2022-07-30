using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs.Profissional;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
[ApiExplorerSettings(IgnoreApi = true)]
public class ProfissionalController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUow _uow;
    private readonly IProfissionalService _profissionalService;

    public ProfissionalController(IProfissionalService profissionalService, IUow uow, IMapper mapper)
    {
        _profissionalService = profissionalService;
        _uow = uow;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var profissionais = await _profissionalService.GetAllAsync();
        return Ok(profissionais);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var profissional = await _profissionalService.GetByIdAsync(id);
        return Ok(profissional);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ProfissionalDtoCreate profissionalDtoCreate)
    {
        var responseModel = new ResponseModel();

        // create localy
        await _profissionalService.CreateAsync(profissionalDtoCreate);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Profissional created successfully!";
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
    public async Task<IActionResult> Put(Guid id, [FromBody] ProfissionalDtoUpdate profissionalDtoUpdate)
    {
        var responseModel = new ResponseModel();
        profissionalDtoUpdate.Id = id;

        // create localy
        await _profissionalService.UpdateAsync(profissionalDtoUpdate);
        try
        {
            // try to commit
            await _uow.Commit();

            var x = await _profissionalService.GetByIdAsync(id);

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Profissional updated successfully!";
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

        var profissional = await _profissionalService.GetByIdAsync(id);
        var profissionalDto = _mapper.Map<ProfissionalDto>(profissional);

        // create localy
        await _profissionalService.RemoveAsync(profissionalDto);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Profissional removed successfully!";
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