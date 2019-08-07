using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Usuario.Service.ApplicationService;

namespace Usuario.Interface.Controllers
{
    [Route("api/usuario/")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioApplicationService _appService;

        [HttpGet("{id:int}")]
        public IActionResult ListarUsuarios(int id)
        {
            return _appService.GetById(id);
            
        }

    }
}