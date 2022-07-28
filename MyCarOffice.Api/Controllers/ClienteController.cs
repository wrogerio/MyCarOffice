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
using MyCarOffice.Helpers.Constants;
using MyCarOffice.Helpers.Methods;
using MyCarOffice.Uow;

namespace MyCarOffice.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public ClienteController(IClienteService clienteService, IUow uow, IMapper mapper)
        {
            _clienteService = clienteService;
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var clientes = await _clienteService.GetAllAsync();
            var clienteDto = _mapper.Map<IEnumerable<ClienteDto>>(clientes);

            return Ok(clienteDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var cliente = await _clienteService.GetByIdAsync(id);
            var clienteDto = _mapper.Map<ClienteDto>(cliente);

            return Ok(clienteDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteDto clienteDto)
        {
            var responseModel = new ResponseModel();
            
            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<ClienteDto>(clienteDto)) return BadRequest(Constants.ErrorRequired);
            
            // create localy
            clienteDto =  await _clienteService.CreateAsync(clienteDto);
            try
            {
                // try to commit
                await _uow.Commit();
                
                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Cliente created successfully!";
                responseModel.Data = clienteDto;
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
        public async Task<IActionResult> Put(Guid id, [FromBody] ClienteDto clienteDto)
        {
            var responseModel = new ResponseModel();
            
            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<ClienteDto>(clienteDto)) return BadRequest(Constants.ErrorRequired);

            clienteDto.Id = id;
            
            // create localy
            clienteDto =  await _clienteService.UpdateAsync(clienteDto);
            try
            {
                // try to commit
                await _uow.Commit();
                
                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Cliente updated successfully!";
                responseModel.Data = clienteDto;
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

            var cliente = await _clienteService.GetByIdAsync(id);
            var clienteDto = _mapper.Map<ClienteDto>(cliente);
            
            // valid requireds
            if (!MyOfficeMethods.ValidarRequeridos<ClienteDto>(clienteDto)) return BadRequest(Constants.ErrorRequired);
            
            // create localy
            await _clienteService.RemoveAsync(clienteDto);
            try
            {
                // try to commit
                await _uow.Commit();
                
                // return response to caller
                responseModel.IsError = false;
                responseModel.Message = "Cliente removed successfully!";
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
