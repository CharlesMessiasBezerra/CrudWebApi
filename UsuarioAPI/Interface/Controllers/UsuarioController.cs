using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Usuario.Service.ApplicationService;
using Usuario.Common.DTO.UsuarioContext;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Usuario.Interface.Controllers
{
    [Route("api/usuario/")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioApplicationService _appService;

        public UsuarioController(UsuarioApplicationService appService)
        {
            _appService = appService;
        }

        [HttpGet("{id:int}")]
        public UsuarioDto getUsuario(int id)
        {
            return _appService.GetById(id);
                        
        }

        [HttpGet("")]
        public List<UsuarioDto> ListarUsuarios(int id)
        {
            return _appService.GetAll();
        }

        [HttpPost("")]
        public ActionResult Insert(UsuarioDto dto)
        {
            _appService.Insert(dto);
            return Ok();
        }

        [HttpPut("{id:int}")]
        public ActionResult Update(UsuarioDto dto, int id)
        {
            _appService.Update(dto, id);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete( int id)
        {
            _appService.Delete( id);
            return Ok();
        }
    }
}