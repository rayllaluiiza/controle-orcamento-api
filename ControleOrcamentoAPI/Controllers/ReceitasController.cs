using ControleOrcamentoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleOrcamentoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceitasController : ControllerBase
    {
        [HttpPost]
        public void add([FromBody] Receitas receita)
        {

        }
    }
}
