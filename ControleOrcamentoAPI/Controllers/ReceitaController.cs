using ControleOrcamentoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleOrcamentoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceitaController : ControllerBase
    {
        [HttpPost]
        public void add([FromBody] Receita receita)
        {

        }
    }
}
