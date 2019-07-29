using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Usuario.Service.ApplicationService;

namespace Interface.Controllers
{
    [Route("api/usuario/")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioApplicationService _appService;

        [HttpGet]
        public IActionResult ListarUsuarios()
        {
            return Ok(1);             
        }

    }
}