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
using MyCarOffice.Helpers.Constants;
using MyCarOffice.Helpers.Methods;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OficinaController : ControllerBase
    {
        private readonly IOficinaService _oficinaService;
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public OficinaController(IOficinaService oficina, IUow uow, IMapper mapper)
        {
            _oficinaService = oficina ?? throw new ArgumentNullException(nameof(oficina));
            _uow = uow ?? throw new ArgumentNullException(nameof(uow));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var oficinas = await _oficinaService.GetAllAsync();
            var oficinasDto = _mapper.Map<IEnumerable<OficinaDto>>(oficinas);

            return Ok(oficinasDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var oficina = await _oficinaService.GetByIdAsync(id);
            var oficinaDto = _mapper.Map<OficinaDto>(oficina);

            return Ok(oficinaDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OficinaDto oficinaDto)
        {
            var responseModel = new ResponseModel();
            
            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<OficinaDto>(oficinaDto)) return BadRequest(Constants.ErrorRequired);
            
            // create localy
            oficinaDto = await _oficinaService.CreateAsync(oficinaDto);
            try
            {
                // try to commit
                await _uow.Commit();
                
                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Oficina created successfully!";
                responseModel.Data = oficinaDto;
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
        public async Task<IActionResult> Put(Guid id, [FromBody] OficinaDto oficinaDto)
        {
            var responseModel = new ResponseModel();
            
            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<OficinaDto>(oficinaDto)) return BadRequest(Constants.ErrorRequired);

            oficinaDto.Id = id;
            
            // create localy
            oficinaDto = await _oficinaService.UpdateAsync(oficinaDto);
            try
            {
                // try to commit
                await _uow.Commit();
                
                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Oficina updated successfully!";
                responseModel.Data = oficinaDto;
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
            
            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<OficinaDto>(oficinaDto)) return BadRequest(Constants.ErrorRequired);
            
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
}