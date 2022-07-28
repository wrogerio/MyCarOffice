using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Helpers.Constants;
using MyCarOffice.Helpers.Methods;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EspecializacaoController : Controller
    {
        private readonly IEspecializacaoService _especializacaoService;
        private readonly IUow _uow;
        private readonly IMapper _mapper;

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
            var especializacoesDto = _mapper.Map<IEnumerable<EspecializacaoDto>>(especializacoes);

            return Ok(especializacoesDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var especializacao = await _especializacaoService.GetByIdAsync(id);
            var especializacaoDto = _mapper.Map<EspecializacaoDto>(especializacao);

            return Ok(especializacaoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EspecializacaoDto especializacaoDto)
        {
            var responseModel = new ResponseModel();

            // valid requires
            if (!MyOfficeMethods.ValidarRequeridos<EspecializacaoDto>(especializacaoDto)) return BadRequest(Constants.ErrorRequired);

            // create localy
            await _especializacaoService.CreateAsync(especializacaoDto);

            try
            {
                // try to commit
                await _uow.Commit();

                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Especialização created successfully!";
                responseModel.Data = especializacaoDto;
                return Ok(responseModel);
            }
            catch (Exception ex)
            {

                // rollback actions
                await _uow.RollBack();

                // return response to caller
                responseModel.IsError = true;
                responseModel.Message = ex.Message;
                responseModel.Data = especializacaoDto;
                return BadRequest(responseModel);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] EspecializacaoDto especializacaoDto)
        {
            var responseModel = new ResponseModel();

            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<EspecializacaoDto>(especializacaoDto)) return BadRequest(Constants.ErrorRequired);

            especializacaoDto.Id = id;

            // create localy
            await _especializacaoService.UpdateAsync(especializacaoDto);
            try
            {
                // try to commit
                await _uow.Commit();

                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Especialização updated successfully!";
                responseModel.Data = especializacaoDto;
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

            var especializacao = await _especializacaoService.GetByIdAsync(id);
            var especializacaoDto = _mapper.Map<EspecializacaoDto>(especializacao);

            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<EspecializacaoDto>(especializacaoDto)) return BadRequest(Constants.ErrorRequired);

            // create localy
            await _especializacaoService.RemoveAsync(especializacaoDto);
            try
            {
                // try to commit
                await _uow.Commit();

                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Especialização removed successfully!";
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
}
