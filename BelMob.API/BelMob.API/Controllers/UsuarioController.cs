using BelMob.Core.DTOs.Request;
using BelMob.Core.DTOs.Response;
using BelMob.Core.Interfaces.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace BelMob.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        public IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CadastroUsuarioRequest usuario)
        {
            _usuarioService.Cadastrar(usuario);
            return Ok();
        }

        [HttpGet]
        public ActionResult<List<UsuarioResponse>> GetAll()
        {
            return Ok(_usuarioService.Listar());
        }
    }
}
