using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Usuario.Service.ApplicationService;
using Usuario.Common.DTO.UsuarioContext;

namespace Usuario.Interface.Controllers
{
    [Route("api/usuario/")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioApplicationService _appService;

        [HttpGet("{id:int}")]
        public UsuarioDto ListarUsuarios(int id)
        {
            return _appService.GetById(id);
                        
        }

    }
}