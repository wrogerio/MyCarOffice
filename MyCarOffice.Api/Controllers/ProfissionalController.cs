using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs.Queries;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProfissionalController : Controller
{
    private readonly IMapper _mapper;
    private readonly IProfissionalService _profissionalService;
    private readonly IUow _uow;

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
    public async Task<IActionResult> Post([FromBody] ProfissionalDto profissionalDto)
    {
        var responseModel = new ResponseModel();

        // create localy
        profissionalDto = await _profissionalService.CreateAsync(profissionalDto);

        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Profissional created successfully!";
            responseModel.Data = profissionalDto;
            return Ok(responseModel);
        }
        catch (Exception ex)
        {
            // rollback actions
            await _uow.RollBack();

            // return response to caller
            responseModel.IsError = true;
            responseModel.Message = ex.Message;
            responseModel.Data = profissionalDto;
            return BadRequest(responseModel);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] ProfissionalDto profissionalDto)
    {
        var responseModel = new ResponseModel();
        profissionalDto.Id = id;

        // create localy
        profissionalDto = await _profissionalService.UpdateAsync(profissionalDto);
        try
        {
            // try to commit
            await _uow.Commit();

            // return response to caller
            responseModel.IsError = false;
            responseModel.Message = "Profissional updated successfully!";
            responseModel.Data = profissionalDto;
            return Ok(responseModel);
        }
        catch (Exception ex)
        {
            // rollback actions
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
            // rollback actions
            await _uow.RollBack();

            // return response to caller
            responseModel.IsError = true;
            responseModel.Message = ex.Message;
            return BadRequest(responseModel);
        }
    }
}