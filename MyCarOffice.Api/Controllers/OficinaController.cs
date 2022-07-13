using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCarOffice.Api.Model;
using MyCarOffice.Application.DTOs;
using MyCarOffice.Application.Interfaces;
using MyCarOffice.Domain.Entities;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OficinaController : ControllerBase
    {
        private readonly IOficinaService _oficina;
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public OficinaController(IOficinaService oficina, IUow uow, IMapper mapper)
        {
            _oficina = oficina ?? throw new ArgumentNullException(nameof(oficina));
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IEnumerable<OficinaDto>> Get()
        {
            var oficinas = await _oficina.GetAllAsync();
            var oficinasDto = _mapper.Map<IEnumerable<OficinaDto>>(oficinas);

            return oficinasDto;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<OficinaDto> Get(Guid id)
        {
            var oficinas = await _oficina.GetByIdAsync(id);
            var oficinasDto = _mapper.Map<OficinaDto>(oficinas);

            return oficinasDto;
        }

        [HttpPost]
        public async Task<IActionResult> Post(OficinaDto oficinaDto)
        {
            var responseModel = new ResponseModel();
            
            // valid requireds
            if (!oficinaDto.ValidarEntidade(oficinaDto)) return BadRequest(responseModel);
            
            // create localy
            await _oficina.CreateAsync(oficinaDto);
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
    }
}