using ApiDelivey.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiDelivey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntregasController : ControllerBase
    {
        private static List<Entregas> entregas = new List<Entregas>
        {
                  new Entregas
                {
                    id = 1,
                    nrEntrega = "01",
                    dataDaEntrega = DateTime.Now
                }
        };

        [HttpGet]
        public async Task<ActionResult<List<Entregas>>> Get()
        {
            return Ok(entregas);
        }
        
        [HttpPost]
        public async Task<ActionResult<List<Entregas>>> AddEntrega([FromBody]Entregas entrega)
        {
            entregas.Add(entrega);
            return Ok(entregas);
        }
    }
}
